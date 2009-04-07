using System.Text;


namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;
	using DDW;
	using Utils;

	internal static class MethodParser {
		private static readonly char[] _paramTrim = new[] { ',', ' ' };

		internal static void ParseMethod(MethodNode node, CodeBuilder sb) {
			sb.AppendFormat("{0}function {1}({2}):{3} {{", 
				Helpers.GetModifiers(node.Modifiers), 
				node.Names[0].GenericIndependentIdentifier,
				getParams(node.Params),
			    Helpers.ConvertType(node.Type)
			);

			sb.AppendLine();
			BlockParser.ParseStatementBlock(node.StatementBlock, sb);
			sb.AppendLine();
			sb.AppendLine("}");
			sb.AppendLine();
		}

		internal static void ParseMethod(ConstructorNode node, CodeBuilder sb) {
			sb.AppendFormat("{0}function {1}({2}) {{",
				Helpers.GetModifiers(node.Modifiers),
				node.Names[0].GenericIndependentIdentifier,
				getParams(node.Params)
			);

			sb.AppendLine();
			BlockParser.ParseStatementBlock(node.StatementBlock, sb);
			sb.AppendLine();
			sb.AppendLine("}");
			sb.AppendLine();
		}

		private static string getParams(IEnumerable<ParamDeclNode> parm) {
			StringBuilder prms = new StringBuilder();
			foreach (ParamDeclNode param in parm) {
				prms.AppendFormat("{0}:{1}, ", param.Name, Helpers.ConvertType(param.Type));
			}

			return prms.ToString().TrimEnd(_paramTrim);
		}
	}
}