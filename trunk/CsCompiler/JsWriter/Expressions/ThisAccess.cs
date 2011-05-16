namespace CsCompiler.JsWriter.Expressions {
	using Metaspec;
	using Tools;

	public sealed class ThisAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//CsThisAccess ex = (CsThisAccess)pExpression;
			return new Expression("this", pStatement.entity_typeref);
		}
	}
}
