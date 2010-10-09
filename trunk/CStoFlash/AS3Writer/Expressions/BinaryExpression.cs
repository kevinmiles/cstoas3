namespace CStoFlash.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class BinaryExpression :IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsBinaryExpression li = (CsBinaryExpression)pStatement;

			Expression left = FactoryExpressionCreator.Parse(li.lhs);
			Expression right = FactoryExpressionCreator.Parse(li.rhs);

			return new Expression(left.Value + " " + Helpers.GetTokenType(li.oper) + " " + right.Value, pStatement.entity_typeref);
		}
	}
}
