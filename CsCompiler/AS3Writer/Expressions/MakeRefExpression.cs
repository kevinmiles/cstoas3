namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class MakeRefExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			// __makeref "(" expresion ")"
			throw new NotImplementedException();
		}
	}
}
