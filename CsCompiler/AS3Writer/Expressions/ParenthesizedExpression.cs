namespace CsCompiler.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public class ParenthesizedExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//"(" expression ")"
			CsParenthesizedExpression ex = (CsParenthesizedExpression)pStatement;
			return new Expression("(" + FactoryExpressionCreator.Parse(ex.expression).Value + ")", pStatement.entity_typeref);
		}
	}
}
