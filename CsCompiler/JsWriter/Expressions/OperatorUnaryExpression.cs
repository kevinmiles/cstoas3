namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class OperatorUnaryExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsOperatorUnaryExpression ex = (CsOperatorUnaryExpression)pStatement;

			return new Expression(
				JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + FactoryExpressionCreator.Parse(ex.unary_expression).Value,
				pStatement.entity_typeref
			);
		}
	}
}
