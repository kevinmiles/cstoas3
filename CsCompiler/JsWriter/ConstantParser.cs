namespace CsCompiler.JsWriter {
	using System.Text;
	using CsParser;
	using Tools;

	public static class ConstantParser {
		public static void Parse(TheConstant pConstant, CodeBuilder pBuilder) {
			string modifiers = JsHelpers.ConvertModifiers(pConstant.Modifiers);

			foreach (Constant declarator in pConstant.Constants) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat(@"{0}const {1}:{2} = {3};",
					modifiers,
					declarator.Name,
					JsHelpers.Convert(declarator.ReturnType),
					declarator.Initializer.Value
				);

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLine();
			}
		}
	}
}
