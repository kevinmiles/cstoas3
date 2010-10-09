namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;
	using Tools;

	public class LambdaExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsLambdaExpression ex = (CsLambdaExpression)pStatement;

			throw new NotImplementedException();
		}
	}
}
