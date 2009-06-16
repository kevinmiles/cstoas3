namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;

	using Utils;

	public class LambdaExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsLambdaExpression ex = (CsLambdaExpression)pStatement;

			throw new NotImplementedException();
		}
	}
}
