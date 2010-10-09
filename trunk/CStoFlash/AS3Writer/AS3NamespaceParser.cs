namespace CStoFlash.AS3Writer {
	using System;
	using System.IO;
	using System.Text;
	using CsParser;
	using Expressions;

	using Metaspec;
	using Tools;
	using System.Collections.Generic;

	public class As3NamespaceParser : INamespaceParser {
		private static readonly Dictionary<string , string> _notValidClassMod = 
			new Dictionary<string, string> {
				{ "private", null },
				{ "abstract", null }
			};

		static As3NamespaceParser() {
			FactoryExpressionCreator.AddParser(typeof(CsBinaryExpression), new BinaryExpression());
			FactoryExpressionCreator.AddParser(typeof(CsArrayInitializer), new ArrayInitializer());
			FactoryExpressionCreator.AddParser(typeof(CsAsIsExpression), new AsIsExpression());
			FactoryExpressionCreator.AddParser(typeof(CsAssignmentExpression), new AssignmentExpression());
			FactoryExpressionCreator.AddParser(typeof(CsConditionalExpression), new ConditionalExpression());
			FactoryExpressionCreator.AddParser(typeof(CsLambdaExpression), new LambdaExpression());

			FactoryExpressionCreator.AddParser(typeof(CsTypeofExpression), new TypeofExpression());
			FactoryExpressionCreator.AddParser(typeof(CsThisAccess), new ThisAccess());
			FactoryExpressionCreator.AddParser(typeof(CsSizeofExpression), new SizeofExpression());
			FactoryExpressionCreator.AddParser(typeof(CsSimpleName), new SimpleName());
			FactoryExpressionCreator.AddParser(typeof(CsRefValueExpression), new RefTypeExpression());
			FactoryExpressionCreator.AddParser(typeof(CsRefTypeExpression), new RefTypeExpression());
			FactoryExpressionCreator.AddParser(typeof(CsQueryExpression), new QueryExpression());
			FactoryExpressionCreator.AddParser(typeof(CsQualifiedAliasMemberAccess), new QualifiedAliasMemberAccess());
			FactoryExpressionCreator.AddParser(typeof(CsPrimaryExpressionMemberAccess), new PrimaryExpressionMemberAccess());
			FactoryExpressionCreator.AddParser(typeof(CsPredefinedTypeMemberAccess), new PredefinedTypeMemberAccess());
			FactoryExpressionCreator.AddParser(typeof(CsPostIncrementDecrementExpression), new PostIncrementDecrementExpression());
			FactoryExpressionCreator.AddParser(typeof(CsPointerMemberAccess), new PointerMemberAccess());
			FactoryExpressionCreator.AddParser(typeof(CsParenthesizedExpression), new ParenthesizedExpression());
			FactoryExpressionCreator.AddParser(typeof(CsNewObjectExpression), new NewObjectExpression());
			FactoryExpressionCreator.AddParser(typeof(CsNewArrayExpression), new NewArrayExpression());
			FactoryExpressionCreator.AddParser(typeof(CsMakeRefExpression), new MakeRefExpression());
			FactoryExpressionCreator.AddParser(typeof(CsLiteral), new Literal());
			FactoryExpressionCreator.AddParser(typeof(CsInvocationExpression), new InvocationExpression());
			FactoryExpressionCreator.AddParser(typeof(CsElementAccess), new ElementAccess());
			FactoryExpressionCreator.AddParser(typeof(CsDefaultValueExpression), new DefaultValueExpression());
			FactoryExpressionCreator.AddParser(typeof(CsCheckedExpression), new CheckedExpression());
			FactoryExpressionCreator.AddParser(typeof(CsBaseMemberAccess), new BaseMemberAccess());
			FactoryExpressionCreator.AddParser(typeof(CsBaseIndexerAccess), new BaseIndexerAccess());
			FactoryExpressionCreator.AddParser(typeof(CsArgListExpression), new ArgListExpression());
			FactoryExpressionCreator.AddParser(typeof(CsAnonymousObjectCreationExpression), new AnonymousObjectCreationExpression());
			FactoryExpressionCreator.AddParser(typeof(CsAnonymousMethodExpression), new AnonymousMethodExpression());
			FactoryExpressionCreator.AddParser(typeof(CsCastUnaryExpression), new CastUnaryExpression());
			FactoryExpressionCreator.AddParser(typeof(CsOperatorUnaryExpression), new OperatorUnaryExpression());
			FactoryExpressionCreator.AddParser(typeof(CsPreIncrementDecrementExpression), new PreIncrementDecrementExpression());
		}

		//public void Init() {
		//    TheClass.Init();
		//}

		public void Parse(CsNamespace pNameSpace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder) {
			if (pNameSpace == null) {
				return;
			}

			string name = getNamespace(pNameSpace);
			string packDir = pOutputFolder + name.Replace('.', '\\');
			Directory.CreateDirectory(packDir);
			As3Builder builder = new As3Builder("\t");

			foreach (CsNode cn in pNameSpace.member_declarations) {
				builder.Append("package ");

				builder.Append(name);
				builder.AppendLineAndIndent(" {");

				parseUsing(pUsing, builder);
				parseUsing(pNameSpace.using_directives, builder);
				const string importMarker = "*-MoreImportsHere-*";

				builder.AppendLine(importMarker);
				ImportStatementList.Init();

				CsClass csClass = cn as CsClass;

				if (csClass != null) {//it's a class....
					StringBuilder sb = new StringBuilder();
					TheClass myClass = TheClassFactory.Get(csClass);
					bool isMainClass = Helpers.HasAttribute(csClass.attributes, "As3MainClassAttribute");

					if (isMainClass) {
						List<object> vals = Helpers.GetAttributeValue(csClass.attributes, "As3MainClassAttribute");
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
					
					builder.Append(sb.ToString());
					builder.AppendLineAndIndent();

					if (isMainClass) {
						builder.AppendFormat(@"public function {0}():void {{
			if (stage) _init();
			else addEventListener(Event.ADDED_TO_STAGE, __loaded);
		}}

		private function __loaded(e:Event = null):void {{
			removeEventListener(Event.ADDED_TO_STAGE, __loaded);
			_init();
		}}
", myClass.Name);
						builder.AppendLine();
					}

					foreach (CsNode memberDeclaration in csClass.member_declarations) {
						if (memberDeclaration is CsConstructor) {
							MethodParser.Parse(myClass.GetConstructor((CsConstructor)memberDeclaration), builder);

						} else if (memberDeclaration is CsMethod) {
							MethodParser.Parse(myClass.GetMethod((CsMethod)memberDeclaration), builder);

						} else if (memberDeclaration is CsIndexer) {
							IndexerParser.Parse(myClass.GetIndexer((CsIndexer)memberDeclaration), builder);

						} else if (memberDeclaration is CsVariableDeclaration) {
							VariableParser.Parse(myClass.GetVariable((CsVariableDeclaration) memberDeclaration), builder);

						} else if (memberDeclaration is CsConstantDeclaration) {
							ConstantParser.Parse(myClass.GetConstant((CsConstantDeclaration)memberDeclaration), builder);

						} else if (memberDeclaration is CsDelegate) {
							DelegateParser.Parse(myClass.GetDelegate((CsDelegate)memberDeclaration), builder);

						} else if (memberDeclaration is CsEvent) {
							EventParser.Parse(myClass.GetEvent((CsEvent)memberDeclaration), builder);

						} else if (memberDeclaration is CsProperty) {
							PropertyParser.Parse(myClass.GetProperty((CsProperty)memberDeclaration), builder);

						} else {
							throw new NotSupportedException();
						}
					}


					//theClass.member_declarations
					//theClass.ctor_method??static constructor?

					string replace = string.Empty;
					if (ImportStatementList.List.Count > 0) {
						StringBuilder i = new StringBuilder();
						foreach (string import in ImportStatementList.List) {
							i.AppendLine();
							i.AppendFormat("\timport {0};", import);
							
						}
						i.AppendLine();
						replace = i.ToString();
					}

					builder.Replace(importMarker, replace);

					builder.AppendLineAndUnindent("}");
					builder.AppendLineAndUnindent("}");

					File.WriteAllText(packDir + "\\" + Helpers.GetRealName(csClass, csClass.identifier.identifier) + ".as", builder.ToString());
					builder.Length = 0;
				}

				if (csClass == null) {
					throw new Exception("Unknown type");
				}			
			}
		}

		private static string getNamespace(CsNamespace pNamespace) {
			string name = string.Empty;
			foreach (CsQualifiedIdentifierPart identifier in pNamespace.qualified_identifier) {
				name += identifier.identifier.identifier + ".";
			}

			return name.Substring(0, name.Length - 1);
		}

		private static void parseUsing(IEnumerable<CsUsingDirective> pNn, CodeBuilder pStrb) {
			if (pNn == null) return;

			foreach (CsUsingDirective directive in pNn) {
				if (directive is CsUsingNamespaceDirective) {
					string name = As3Helpers.Convert(Helpers.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal) || name.StartsWith("System", StringComparison.Ordinal))
						continue;

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				if (directive is CsUsingAliasDirective) {
					string name = As3Helpers.Convert(Helpers.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal))
						continue;

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				throw new Exception(@"Unhandled using type");
			}
		}
	}
}