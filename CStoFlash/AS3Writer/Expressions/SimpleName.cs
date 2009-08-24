namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class SimpleName : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsSimpleName ex = (CsSimpleName)pStatement;

			return new Expression(
				ParserHelper.GetRealName(ex, ex.identifier.identifier),
				ex.entity_typeref);
		}
	}
}
