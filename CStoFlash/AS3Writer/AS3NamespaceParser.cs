namespace CStoFlash.AS3Writer {
	using System;
	using System.IO;
	using System.Text;

	using Expressions;

	using Metaspec;

	using Utils;
	using System.Collections.Generic;

	public class As3NamespaceParser : INamespaceParser {
		private static readonly Dictionary<CsModifierEnum, string> _notValidClassMod = 
			new Dictionary<CsModifierEnum, string> {
				{ CsModifierEnum.mSTATIC, "final" }, 
				{ CsModifierEnum.mPRIVATE, null },
				{ CsModifierEnum.mABSTRACT, null }
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

		public void Init() {
			TheClass.Init();
		}

		public void Parse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder) {
			if (pNamespace == null) {
				return;
			}

			string name = getNamespace(pNamespace);
			string packDir = pOutputFolder + name.Replace('.', '\\');
			Directory.CreateDirectory(packDir);
			AS3Builder builder = new AS3Builder("\t");

			foreach (CsNode cn in pNamespace.member_declarations) {
				builder.Append("package ");

				builder.Append(name);
				builder.AppendLineAndIndent(" {");

				parseUsing(pUsing, builder);
				parseUsing(pNamespace.using_directives, builder);
				const string IMPORT_MARKER = "*-MoreImportsHere-*";

				builder.AppendLine(IMPORT_MARKER);
				ImportStatementList.Init();

				CsClass theClass = cn as CsClass;

				if (theClass != null) {//it's a class....
					StringBuilder sb = new StringBuilder();
					string className = theClass.identifier.identifier;

					sb.AppendFormat("{1}class {0}", className, As3Helpers.GetModifiers(theClass.modifiers, _notValidClassMod));

					if (theClass.type_base != null && theClass.type_base.base_list.Count != 0) {
						bool hasImplement = false;

						foreach (CsTypeRef typeRef in theClass.type_base.base_list) {

							if (typeRef.entity_typeref.u is CsEntityInstanceSpecifier) {
								setExtendsImplements(((CsEntityInstanceSpecifier)typeRef.entity_typeref.u).type.u, ref hasImplement, sb);

							} else {
								setExtendsImplements(typeRef.entity_typeref.u, ref hasImplement, sb);
							}

							sb.Append(As3Helpers.Convert(ParserHelper.GetType(typeRef.type_name)));
						}
					}

					sb.Append(" {");
					sb.AppendLine();
					builder.Append(sb.ToString());
					builder.AppendLineAndIndent();

					foreach (CsNode memberDeclaration in theClass.member_declarations) {
						if (memberDeclaration is CsConstructor) {
							MethodParser.Parse((CsConstructor)memberDeclaration, builder);

						} else if (memberDeclaration is CsMethod) {
							MethodParser.Parse((CsMethod)memberDeclaration, builder);

						} else if (memberDeclaration is CsIndexer) {
							IndexerParser.Parse((CsIndexer) memberDeclaration, builder);

						} else if (memberDeclaration is CsVariableDeclaration) {
							VariableParser.Parse((CsVariableDeclaration) memberDeclaration, builder);

						} else if (memberDeclaration is CsConstantDeclaration) {
							ConstantParser.Parse((CsConstantDeclaration)memberDeclaration, builder);

						} else if (memberDeclaration is CsDelegate) {
							DelegateParser.Parse((CsDelegate)memberDeclaration, builder);

						} else if (memberDeclaration is CsEvent) {
							EventParser.Parse((CsEvent)memberDeclaration, builder);

						} else if (memberDeclaration is CsProperty) {
							PropertyParser.Parse((CsProperty)memberDeclaration, builder);

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

					builder.Replace(IMPORT_MARKER, replace);

					builder.AppendLineAndUnindent("}");
					builder.AppendLineAndUnindent("}");

					File.WriteAllText(packDir + "\\" + className + ".as", builder.ToString());
					builder.Length = 0;
				}

				if (theClass == null) {
					throw new Exception("Unknow type");
				}			
			}
		}

		private static void setExtendsImplements(object pIn, ref bool pHasImplement, StringBuilder pStringBuilder) {
			if (pIn is CsEntityClass) {
				pStringBuilder.Append(" extends ");

			} else if (pIn is CsEntityInterface) {
				if (pHasImplement) {
					pStringBuilder.Append(", ");

				} else {
					pStringBuilder.Append(" implements ");
					pHasImplement = true;
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
					string name = As3Helpers.Convert(ParserHelper.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal) || name.StartsWith("System", StringComparison.Ordinal))
						continue;

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				if (directive is CsUsingAliasDirective) {
					string name = As3Helpers.Convert(ParserHelper.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal))
						continue;

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				throw new Exception("Unhandled using type");
			}
		}

		public void PreParse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing) {
			if (pNamespace == null) {
				return;
			}

			foreach (CsNode cn in pNamespace.member_declarations) {
				CsClass theClass = cn as CsClass;
				if (theClass != null) {
					TheClass.Add(theClass);

				} else {
					throw new Exception("Unknown type");
				}
			}
		}
	}
}