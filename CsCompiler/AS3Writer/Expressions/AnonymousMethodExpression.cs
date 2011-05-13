namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class AnonymousMethodExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//"delegate" (explicit-anonymous-function-signature)? block
			throw new NotImplementedException();
		}
	}
}
