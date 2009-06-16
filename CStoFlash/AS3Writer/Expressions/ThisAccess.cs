namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class ThisAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//CsThisAccess ex = (CsThisAccess)pExpression;
			return new Expression("this", ParserHelper.GetType(pStatement.entity_typeref));
		}
	}
}
