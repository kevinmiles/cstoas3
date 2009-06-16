namespace CStoFlash.AS3Writer {
	using System.Text;

	using Metaspec;

	using Utils;

	public static class VariableParser {

		public static void Parse(CsVariableDeclaration pCsVariableDeclaration, AS3Builder pBuilder) {
			string modifiers = As3Helpers.GetModifiers(pCsVariableDeclaration.modifiers);

			foreach (CsVariableDeclarator declarator in pCsVariableDeclaration.declarators) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{0}var {1}:{2}",
					modifiers,
					declarator.identifier.identifier,
					As3Helpers.Convert(ParserHelper.GetType(declarator.entity.type))
				);

				if (declarator.initializer == null) {
					sb.Append(";");

				} else {
					Expression ex = FactoryExpressionCreator.Parse(declarator.initializer as CsExpression);
					sb.AppendFormat(" = {0};", ex.Value);
				}

				pBuilder.Append(sb.ToString());
				pBuilder.AppendLine();
			}
		}
	}
}
