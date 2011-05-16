namespace CsCompiler.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public sealed class ParenthesizedExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//"(" expression ")"
			CsParenthesizedExpression ex = (CsParenthesizedExpression)pStatement;
			return new Expression("(" + pCreator.Parse(ex.expression).Value + ")", pStatement.entity_typeref);
		}
	}
}
