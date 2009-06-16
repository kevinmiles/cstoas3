namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;

	using Utils;

	public class TypeofExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsTypeofExpression ex = (CsTypeofExpression)pStatement;
			//"typeof" "(" type ")"
			throw new NotImplementedException();
		}
	}
}
