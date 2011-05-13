namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class BinaryExpression :IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsBinaryExpression li = (CsBinaryExpression)pStatement;

			Expression left = pCreator.Parse(li.lhs);
			Expression right = pCreator.Parse(li.rhs);

			return new Expression(left.Value + " " + JsHelpers.ConvertTokens(Helpers.GetTokenType(li.oper)) + " " + right.Value, pStatement.entity_typeref);
		}
	}
}
