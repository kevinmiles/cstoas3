namespace CStoFlash.AS3Writer {
	using System.Text;

	using Metaspec;

	using Utils;

	public static class ConstantParser {
		public static void Parse(CsConstantDeclaration pCsVariableDeclaration, AS3Builder pBuilder) {
			string modifiers = As3Helpers.GetModifiers(pCsVariableDeclaration.modifiers);

			foreach (CsConstantDeclarator declarator in pCsVariableDeclaration.declarators) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{0}const {1}:{2} = {3};",
					modifiers,
					declarator.identifier.identifier,
					As3Helpers.Convert(ParserHelper.GetType(declarator.entity.type)),
					FactoryExpressionCreator.Parse(declarator.expression).Value
				);

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLine();
			}
		}
	}
}
