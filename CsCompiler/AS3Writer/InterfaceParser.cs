using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsCompiler.AS3Writer {
	using CsParser;
	using Metaspec;
	using Tools;

	static class InterfaceParser {
		private static readonly Dictionary<string, string> _notValidClassMod =
			new Dictionary<string, string> {
				{"private", null},
				{"abstract", null}
			};

		public static void Parse(CsInterface pCsInterface, CodeBuilder pBuilder, FactoryExpressionCreator pCreator) {
			StringBuilder sb = new StringBuilder();
			TheClass myClass = TheClassFactory.Get(pCsInterface, pCreator);

			sb.AppendFormat("{1}interface {0}",
							myClass.Name,
							As3Helpers.ConvertModifiers(myClass.Modifiers, _notValidClassMod));

			if (myClass.Implements.Count != 0) {
				sb.Append(" extends ");
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

			if (pCsInterface.member_declarations != null) {
				foreach (CsNode memberDeclaration in pCsInterface.member_declarations) {
					//if (memberDeclaration is CsConstructor) {
					//    MethodParser.Parse(myClass.GetConstructor((CsConstructor)memberDeclaration), pBuilder);
					//} else 
				if (memberDeclaration is CsMethod) {
						MethodParser.Parse(myClass.GetMethod((CsMethod)memberDeclaration), pBuilder, pCreator);

					} else if (memberDeclaration is CsIndexer) {
						IndexerParser.Parse(myClass.GetIndexer((CsIndexer)memberDeclaration), pBuilder, pCreator);

					} else if (memberDeclaration is CsVariableDeclaration) {
						VariableParser.Parse(myClass.GetVariable((CsVariableDeclaration)memberDeclaration), pBuilder);
					} else 
					//if (memberDeclaration is CsConstantDeclaration) {
					//    ConstantParser.Parse(myClass.GetConstant((CsConstantDeclaration)memberDeclaration), pBuilder);
					//} else 
					//if (memberDeclaration is CsDelegate) {
					//    DelegateParser.Parse(myClass.GetDelegate((CsDelegate)memberDeclaration), pBuilder);
					//} else 
					//if (memberDeclaration is CsEvent) {
					//    EventParser.Parse(myClass.GetEvent(((CsEvent)memberDeclaration).declarators.First.Value.identifier.identifier),
					//                      pBuilder);
					//} else 
					if (memberDeclaration is CsProperty) {
						PropertyParser.Parse(myClass.GetProperty((CsProperty)memberDeclaration), pBuilder, pCreator);
					//} else if (memberDeclaration is CsInterface) {
					//    Parse((CsInterface)memberDeclaration, privateClasses);
					} else {
						throw new NotSupportedException();
					}
				}
			}

			pBuilder.AppendLineAndUnindent("}");
			pBuilder.AppendLineAndUnindent("}");
			pBuilder.AppendLine();
			string imports = ClassParser.getImports();
			pBuilder.Replace(ClassParser.IMPORT_MARKER, imports);
		}
	}
}
