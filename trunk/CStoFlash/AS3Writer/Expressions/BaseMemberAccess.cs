namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;

	using Utils;

	public class BaseMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			// "base" "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}
	}
}
