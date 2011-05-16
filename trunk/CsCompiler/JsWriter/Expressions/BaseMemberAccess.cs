namespace CsCompiler.JsWriter.Expressions {
	using Metaspec;
	using Tools;

	public sealed class BaseMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsBaseMemberAccess baseMemberAccess = (CsBaseMemberAccess)pStatement;
			// "base" "." identifier (type-argument-list)?
			return new Expression("super." + baseMemberAccess.identifier.identifier, pStatement.entity_typeref);
		}
	}
}
