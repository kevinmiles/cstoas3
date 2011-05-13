namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class OperatorUnaryExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsOperatorUnaryExpression ex = (CsOperatorUnaryExpression)pStatement;

			return new Expression(
				JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + pCreator.Parse(ex.unary_expression).Value,
				pStatement.entity_typeref
			);
		}
	}
}
