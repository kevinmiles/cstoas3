namespace CsCompiler.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public class BaseMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			// "base" "." identifier (type-argument-list)?
			return new Expression("super.", pStatement.entity_typeref);
		}
	}
}
