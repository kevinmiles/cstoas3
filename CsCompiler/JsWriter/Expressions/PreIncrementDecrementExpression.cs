namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class PreIncrementDecrementExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsPreIncrementDecrementExpression ex = (CsPreIncrementDecrementExpression)pStatement;

			Expression exp = FactoryExpressionCreator.Parse(ex.unary_expression);

			return new Expression(
				JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + exp.Value,
				pStatement.entity_typeref
			);
		}
	}
}
