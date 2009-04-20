namespace CStoFlash.AS3Writer {
	using System.IO;
	using System.Text;

	using DDW;

	using Utils;

	public class As3NamespaceParser : INamespaceParser {
		public void Parse(NamespaceNode pNn, string pOutputFolder) {
			if (pNn == null) {
				return;
			}

			if (pNn.Structs.Count + pNn.Classes.Count == 0) {
				return;
			}

			string packDir = pOutputFolder + pNn.Name.QualifiedIdentifier.Replace('.', '\\');
			Directory.CreateDirectory(packDir);

			foreach (NamespaceNode nn2 in pNn.Namespaces) {
				Parse(nn2, pOutputFolder);
			}

			foreach (ClassNode cn in pNn.Classes) {
				AS3Builder builder = new AS3Builder("\t");

				builder.Append("package ");

				builder.Append(pNn.Name.QualifiedIdentifier);
				builder.AppendLineAndIndent(" {");

				foreach (UsingDirectiveNode directive in pNn.UsingDirectives) {
					//builder.AddImport(directive.Target);
				}

				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{1}class {0}", cn.Name.Identifier, Helpers.GetModifiers(cn.Modifiers));

				if (cn.BaseClasses.Count != 0) {
					sb.Append(" extends ");
					foreach (TypeNode type in cn.BaseClasses) {
						sb.Append(Helpers.ConvertType(type));
					}
				}

				if (cn.Interfaces.Count != 0) {
					sb.Append(" implements ");
					foreach (InterfaceNode iNode in cn.Interfaces) {
						sb.Append(iNode.Name.Identifier);
					}
				}

				sb.Append(" {");
				builder.Append(sb.ToString());
				builder.AppendLineAndIndent();

				ScopeBlock scope = new ScopeBlock();

				foreach (ConstantNode constant in cn.Constants) {
					ConstantParser.Parse(pNn, cn, constant, builder, scope);
				}

				foreach (FieldNode field in cn.Fields) {
					FieldParser.Parse(pNn, cn, field, builder, scope);
				}

				foreach (PropertyNode property in cn.Properties) {
					PropertyParser.Parse(pNn, cn, property, builder, scope);
				}

				foreach (IndexerNode indexer in cn.Indexers) {
					IndexerParser.Parse(pNn, cn, indexer, builder, scope);
				}

				foreach (ConstructorNode c in cn.Constructors) {
					MethodParser.ParseConstructor(pNn, cn, c, builder, scope);
				}

				foreach (MethodNode node in cn.Methods) {
					MethodParser.Parse(pNn, cn, node, builder, scope);
				}

				builder.AppendLineAndUnindent("}");
				builder.AppendLineAndUnindent("}");

				File.WriteAllText(packDir + "\\" + cn.Name.Identifier + ".as", builder.ToString());
			}

			foreach (StructNode sn in pNn.Structs) {
			}
		}
	}
}