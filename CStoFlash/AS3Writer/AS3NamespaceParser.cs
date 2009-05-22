namespace CStoFlash.AS3Writer {
	using System;
	using System.IO;
	using System.Text;

	using Metaspec;

	using Utils;
	using System.Collections.Generic;

	public class As3NamespaceParser : INamespaceParser {
		

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

				CsClass theClass = cn as CsClass;

				if (theClass != null) {//it's a class....
					StringBuilder sb = new StringBuilder();
					string className = theClass.identifier.identifier;
					
					sb.AppendFormat("{1}class {0}", className, As3Helpers.GetModifiers(theClass.modifiers));

					if (theClass.type_base != null && theClass.type_base.base_list.Count != 0) {
						sb.Append(" extends ");
						foreach (CsTypeRef typeRef in theClass.type_base.base_list) {
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
							IndexerParser.Parse((CsIndexer)memberDeclaration, builder);

						} else {
							throw new NotSupportedException();
						}
					}


					//theClass.member_declarations
					//theClass.ctor_method??static constructor?

					builder.AppendLineAndUnindent("}");
					builder.AppendLineAndUnindent("}");
					File.WriteAllText(packDir + "\\" + className + ".as", builder.ToString());
				}

				if (theClass == null) {
					throw new Exception("Unknow type");
				}

/*
				if (cn.Interfaces.Count != 0) {
					sb.Append(" implements ");
					foreach (InterfaceNode iNode in cn.Interfaces) {
						sb.Append(iNode.Name.Identifier);
					}
				}

				sb.Append(" {");
				builder.Append(sb.ToString());
				builder.AppendLineAndIndent();


*/


				
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

			foreach (CsUsingNamespaceDirective directive in pNn) {
				pStrb.AppendFormat("import {0};", As3Helpers.Convert(ParserHelper.GetType(directive)));
				pStrb.AppendLine();
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
					throw new Exception("Unknow type");
				}
			}
		}
	}
}