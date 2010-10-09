namespace CStoFlash.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;

			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value 
				+ " "
				+ Helpers.GetTokenType(ex.oper) + " " + Helpers.GetType(ex.entity_typeref),
				ex.entity_typeref
			);
		}
	}
}
