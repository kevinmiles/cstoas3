namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class AnonymousMethodExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//"delegate" (explicit-anonymous-function-signature)? block
			throw new NotImplementedException();
		}
	}
}
