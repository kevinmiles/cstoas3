namespace CStoFlash.AS3Writer {
	using System.Text;
	using CsParser;

	public static class ConstantParser {
		public static void Parse(TheConstant pConstant, As3Builder pBuilder) {
			string modifiers = As3Helpers.ConvertModifiers(pConstant.Modifiers);

			foreach (Constant declarator in pConstant.Constants) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat(@"{0}const {1}:{2} = {3};",
					modifiers,
					declarator.RealName,
					As3Helpers.Convert(declarator.ReturnType),
					declarator.Initializer.Value
				);

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLine();
			}
		}
	}
}
