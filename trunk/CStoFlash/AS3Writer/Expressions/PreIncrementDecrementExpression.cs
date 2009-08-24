namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class PreIncrementDecrementExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsPreIncrementDecrementExpression ex = (CsPreIncrementDecrementExpression)pStatement;

			Expression exp = FactoryExpressionCreator.Parse(ex.unary_expression);

			return new Expression(
				ParserHelper.GetTokenType(ex.oper) + exp.Value,
				pStatement.entity_typeref
			);
		}
	}
}
