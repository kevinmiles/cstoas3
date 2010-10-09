namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public class ConditionalExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsConditionalExpression ex = (CsConditionalExpression)pStatement;

			return new Expression(
				FactoryExpressionCreator.Parse(ex.condition).Value + " ? " +
				FactoryExpressionCreator.Parse(ex.true_expression).Value + " : " +
				FactoryExpressionCreator.Parse(ex.false_expression).Value,

				pStatement.entity_typeref
			);
		}
	}
}
