namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class OperatorUnaryExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsOperatorUnaryExpression ex = (CsOperatorUnaryExpression)pStatement;

			return new Expression(
				ParserHelper.GetTokenType(ex.oper) + FactoryExpressionCreator.Parse(ex.unary_expression).Value,
				pStatement.entity_typeref
			);
		}
	}
}
