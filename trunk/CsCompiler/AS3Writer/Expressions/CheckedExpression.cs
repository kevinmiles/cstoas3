namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class CheckedExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//"checked" "(" expression ")"
			throw new NotImplementedException();
		}
	}
}
