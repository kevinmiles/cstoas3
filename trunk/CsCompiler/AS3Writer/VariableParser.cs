namespace CsCompiler.AS3Writer {
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Tools;

	public static class VariableParser {
		private static readonly Dictionary<string, string> _notValidVariableMod =
			new Dictionary<string, string> {
				{ @"readonly", "" }
			};

		public static void Parse(TheVariable pVariable, CodeBuilder pBuilder) {
			foreach (Variable declarator in pVariable.Variables) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{0}var {1}:{2}",
					As3Helpers.ConvertModifiers(pVariable.Modifiers, _notValidVariableMod),
					declarator.Name,
					As3Helpers.Convert(declarator.ReturnType)
				);

				if (declarator.Initializer == null) {
					sb.Append(";");

				} else {
					sb.AppendFormat(" = {0};", declarator.Initializer.Value);
				}

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLine();
			}
		}
	}
}
