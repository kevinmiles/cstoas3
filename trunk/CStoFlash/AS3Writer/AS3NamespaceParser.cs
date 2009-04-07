namespace CStoFlash.AS3Writer {
	using System.IO;
	using System.Text;

	using DDW;

	using Utils;

	public class AS3NamespaceParser : INamespaceParser {
		#region INamespaceParser Members

		public void Parse(NamespaceNode nn, string outputFolder) {
			if (nn == null) {
				return;
			}

			if (nn.Structs.Count + nn.Classes.Count == 0) {
				return;
			}

			string packDir = outputFolder + nn.Name.QualifiedIdentifier.Replace('.', '\\');
			Directory.CreateDirectory(packDir);

			foreach (NamespaceNode nn2 in nn.Namespaces) {
				Parse(nn2, outputFolder);
			}

			foreach (ClassNode cn in nn.Classes) {
				AS3Builder builder = new AS3Builder("\t");


				foreach (UsingDirectiveNode directive in nn.UsingDirectives) {
					builder.Append(directive.Target);
				}

				builder.Append("package ");

				builder.Append(nn.Name.QualifiedIdentifier);
				builder.AppendLineAndIndent(" {");

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

				foreach (ConstantNode constant in cn.Constants) {

				}

				foreach (FieldNode field in cn.Fields) {

				}

				foreach (ConstructorNode c in cn.Constructors) {
					MethodParser.ParseMethod(c, builder);
				}

				foreach (PropertyNode property in cn.Properties) {

				}

				foreach (IndexerNode indexer in cn.Indexers) {
					//get set
				}

				foreach (MethodNode node in cn.Methods) {
					MethodParser.ParseMethod(node, builder);
				}

				builder.AppendLineAndUnindent("}");
				builder.AppendLineAndUnindent("}");

				File.WriteAllText(packDir + "\\" + cn.Name.Identifier + ".as", builder.ToString());
			}

			foreach (StructNode sn in nn.Structs) {
			}
		}

		#endregion
	}
}