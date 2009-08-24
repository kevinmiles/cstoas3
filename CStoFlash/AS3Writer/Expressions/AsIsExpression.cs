namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;

			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value 
				+ " "
				+ ParserHelper.GetTokenType(ex.oper) + " " + ParserHelper.GetType(ex.entity_typeref),
				ex.entity_typeref
			);
		}
	}
}
