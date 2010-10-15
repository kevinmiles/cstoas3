namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public static class ClassParser {
		public const string IMPORT_MARKER = "*-MoreImportsHere-*";

		private static readonly Dictionary<string, string> _notValidClassMod =
			new Dictionary<string, string> {
				{"private", null},
				{"abstract", null}
			};

		public static void Parse(CsClass pCsClass, As3Builder pBuilder) {
			StringBuilder sb = new StringBuilder();
			As3Builder privateClasses = new As3Builder("\t");

			TheClass myClass = TheClassFactory.Get(pCsClass);
			bool isMainClass = Helpers.HasAttribute(pCsClass.attributes, "As3MainClassAttribute");

			if (isMainClass) {
				List<object> vals = Helpers.GetAttributeValue(pCsClass.attributes, "As3MainClassAttribute");
				sb.AppendFormat(@"[SWF(width=""{0}"", height=""{1}"", frameRate=""{2}"", backgroundColor=""{3}"")]",
				                vals[0],
				                vals[1],
				                vals[2],
				                vals[3]
					);
				sb.AppendLine();
				sb.Append("\t");
			}

			sb.AppendFormat("{1}class {0}",
			                myClass.Name,
			                As3Helpers.ConvertModifiers(myClass.Modifiers, _notValidClassMod));

			if (myClass.Extends.Count != 0) {
				sb.AppendFormat(" extends {0}", myClass.Extends[0]);
			}

			if (myClass.Implements.Count != 0) {
				sb.Append(" implements ");
				sb.Append(myClass.Implements.Join(", "));
			}

			sb.Append(" {");
			sb.AppendLine();

			pBuilder.Append(sb.ToString());
			pBuilder.AppendLineAndIndent();

			if (isMainClass) {
				pBuilder.AppendFormat(
				                      @"public function {0}():void {{
			if (stage) _init();
			else addEventListener(Event.ADDED_TO_STAGE, __loaded);
		}}

		private function __loaded(e:Event = null):void {{
			removeEventListener(Event.ADDED_TO_STAGE, __loaded);
			_init();
		}}
",
				                      myClass.Name);
				pBuilder.AppendLine();
			}

			foreach (CsNode memberDeclaration in pCsClass.member_declarations) {
				if (memberDeclaration is CsConstructor) {
					MethodParser.Parse(myClass.GetConstructor((CsConstructor)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsMethod) {
					MethodParser.Parse(myClass.GetMethod((CsMethod)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsIndexer) {
					IndexerParser.Parse(myClass.GetIndexer((CsIndexer)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsVariableDeclaration) {
					VariableParser.Parse(myClass.GetVariable((CsVariableDeclaration)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsConstantDeclaration) {
					ConstantParser.Parse(myClass.GetConstant((CsConstantDeclaration)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsDelegate) {
					DelegateParser.Parse(myClass.GetDelegate((CsDelegate)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsEvent) {
					EventParser.Parse(myClass.GetEvent(((CsEvent)memberDeclaration).declarators.First.Value.identifier.identifier),
					                  pBuilder);
				} else if (memberDeclaration is CsProperty) {
					PropertyParser.Parse(myClass.GetProperty((CsProperty)memberDeclaration), pBuilder);
				} else if (memberDeclaration is CsClass) {
					Parse((CsClass)memberDeclaration, privateClasses);
				} else {
					throw new NotSupportedException();
				}
			}

			string imports = getImports();
			pBuilder.Replace(IMPORT_MARKER, imports);

			pBuilder.AppendLineAndUnindent("}");

			if (!myClass.IsPrivate) {
				pBuilder.AppendLineAndUnindent("}");
			}

			if (privateClasses.Length == 0) {
				return;
			}

			pBuilder.AppendLine();
			pBuilder.Append(As3NamespaceParser.Using);
			pBuilder.AppendLine(imports);
			pBuilder.Append(privateClasses);
		}

		private static string getImports() {
			if (ImportStatementList.List.Count > 0) {
				StringBuilder i = new StringBuilder();
				foreach (string import in ImportStatementList.List) {
					i.AppendLine();
					i.AppendFormat("\timport {0};", import);
				}
				i.AppendLine();
				return i.ToString();
			}

			return string.Empty;
		}
	}
}
