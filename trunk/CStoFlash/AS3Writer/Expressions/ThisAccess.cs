namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public class ThisAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//CsThisAccess ex = (CsThisAccess)pExpression;
			return new Expression("this", pStatement.entity_typeref);
		}
	}
}
