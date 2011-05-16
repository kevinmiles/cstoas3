namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class ArgListExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//__arglist ( "(" expresion-list ")" )?
			throw new NotImplementedException();
		}
	}
}
