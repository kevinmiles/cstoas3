namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;

			string asType = ParserHelper.GetType(ex.entity_typeref);

			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value + " " + ParserHelper.GetTokenType(ex.oper) + " " + asType,
				asType
			);
		}
	}
}
