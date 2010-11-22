namespace CsCompiler.AS3Writer {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public static class ClassParser {
		public const string IMPORT_MARKER = "*-MoreImportsHere-*";
		public static bool IsMainClass;
		public static bool IsExtension;
		public static string ExtensionName;

		private static readonly Dictionary<string, string> _notValidClassMod =
			new Dictionary<string, string> {
				{"private", null},
				{"abstract", null},
				{"static", "final"}
			};

		public static void Parse(CsClass pCsClass, As3Builder pBuilder) {
			ExtensionName = null;

			StringBuilder sb = new StringBuilder();
			As3Builder privateClasses = new As3Builder("\t");

			TheClass myClass = TheClassFactory.Get(pCsClass);

			IsMainClass = Helpers.HasAttribute(pCsClass.attributes, "As3MainClassAttribute");
			bool isResource = Helpers.HasAttribute(pCsClass.attributes, "As3EmbedAttribute");
			IsExtension = Helpers.HasAttribute(pCsClass.attributes, "As3ExtensionAttribute");

			if (IsMainClass) {
				As3NamespaceParser.MainClassName = myClass.FullName;
				AttributeItem vals = Helpers.GetAttributeValue(pCsClass.attributes, "As3MainClassAttribute")[0];
				sb.AppendFormat(@"[SWF(width=""{0}"", height=""{1}"", frameRate=""{2}"", backgroundColor=""{3}"")]",
				                vals.Parameters[0],
								vals.Parameters[1],
								vals.Parameters[2],
								vals.Parameters[3]
					);
				sb.AppendLine();
				sb.Append("\t");
			}

			if (isResource) {
				AttributeItem vals = Helpers.GetAttributeValue(pCsClass.attributes, "As3EmbedAttribute")[0];
				
				string path = vals.Parameters[0] as String;
				if (!string.IsNullOrEmpty(path)) {
					path = Path.Combine(Project.Root, path);
					string ex = Path.GetExtension(path).Substring(1);
					string mimeType;

					if (vals.NamedArguments.ContainsKey("mimeType")) {
						mimeType = vals.NamedArguments["mimeType"].Value;

					} else {
						switch (ex) {
							case @"gif":
							case @"png":
							case @"jpg":
							case @"jpeg":
							case @"svg":
								mimeType = "image/" + ex;
								break;

							case @"mp3":
								mimeType = @"audio/mpeg";
								break;

							case @"swf":
								mimeType = @"application/x-shockwave-flash";
								break;

							case @"ttf":
							case @"otf":
								mimeType = @"application/x-font";
								break;

							default:
								mimeType = @"application/octet-stream";
								break;
						}
					}

					StringBuilder addParams = new StringBuilder();
					foreach (var item in vals.NamedArguments.Where(pItem => !pItem.Key.Equals("mimeType"))) {
						addParams.AppendFormat(@", {0}=""{1}""", item.Key, item.Value.Value);
					}

					sb.AppendFormat(@"[Embed(source=""{0}"", mimeType=""{1}""{2})]",
									path.Replace("\\", "\\\\"),
									mimeType,
									addParams
					);

					sb.AppendLine();
					sb.Append("\t");

				}
			}

			if (!IsExtension) {
				sb.AppendFormat("{1}class {0}",
							myClass.Name,
							As3Helpers.ConvertModifiers(myClass.Modifiers, _notValidClassMod));

				if (myClass.Extends.Count != 0) {
					sb.AppendFormat(" extends {0}", As3Helpers.Convert(myClass.Extends[0]));
				}

				if (myClass.Implements.Count != 0) {
					sb.Append(" implements ");
					foreach (string s in myClass.Implements) {
						sb.Append(As3Helpers.Convert(s));
						sb.Append(", ");
					}

					sb.Remove(sb.Length - 2, 2);
				}

				sb.Append(" {");
				sb.AppendLine();

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLineAndIndent();
			}

			if (IsMainClass) {
				ImportStatementList.List.Add("flash.events.Event");
				pBuilder.AppendFormat(
									  @"public function {0}() {{
			if (stage) $ctor();
			else addEventListener(Event.ADDED_TO_STAGE, __loaded);
		}}

		private function __loaded(e:Event = null):void {{
			removeEventListener(Event.ADDED_TO_STAGE, __loaded);
			$ctor();
		}}
",
				                      myClass.Name);
				pBuilder.AppendLine();
			}

			if (pCsClass.member_declarations != null) {
				if (!myClass.IsPrivate)
					ImportStatementList.List.Add(myClass.NameSpace+".*");

				foreach (CsNode memberDeclaration in pCsClass.member_declarations) {
					if (memberDeclaration is CsConstructor) {
						MethodParser.Parse(myClass.GetConstructor((CsConstructor)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsMethod) {
						MethodParser.Parse(myClass.GetMethod((CsMethod)memberDeclaration), pBuilder);
						if (IsExtension && string.IsNullOrEmpty(ExtensionName)) {
							ExtensionName = ((CsMethod)memberDeclaration).identifier.identifier;
						}

					} else if (memberDeclaration is CsIndexer) {
						IndexerParser.Parse(myClass.GetIndexer((CsIndexer)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsVariableDeclaration) {
						VariableParser.Parse(myClass.GetVariable((CsVariableDeclaration)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsConstantDeclaration) {
						ConstantParser.Parse(myClass.GetConstant((CsConstantDeclaration)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsDelegate) {
						DelegateParser.Parse(myClass.GetDelegate((CsDelegate)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsEvent) {
						EventParser.Parse(myClass.GetEvent(((CsEvent)memberDeclaration).declarators.First.Value.identifier.identifier), pBuilder);

					} else if (memberDeclaration is CsProperty) {
						PropertyParser.Parse(myClass.GetProperty((CsProperty)memberDeclaration), pBuilder);

					} else if (memberDeclaration is CsClass) {
						Parse((CsClass)memberDeclaration, privateClasses);

					} else {
						throw new NotSupportedException();
					}
				}
			}
			
			string imports = getImports();
			pBuilder.Replace(IMPORT_MARKER, imports);

			pBuilder.AppendLineAndUnindent("}");

			if (IsExtension) {
				return;
			}

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

		internal static string getImports() {
			if (ImportStatementList.List.Count > 0) {
				StringBuilder i = new StringBuilder();
				foreach (string import in
					ImportStatementList.List.Where(pImport => !pImport.Equals("flash.*", StringComparison.Ordinal))) {
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
