namespace CStoFlash.AS3Writer {
	using System.Text;
	using CsParser;

	public static class VariableParser {
		public static void Parse(TheVariable pVariable, As3Builder pBuilder) {
			foreach (Variable declarator in pVariable.Variables) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{0}var {1}:{2}",
					As3Helpers.ConvertModifiers(pVariable.Modifiers),
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
