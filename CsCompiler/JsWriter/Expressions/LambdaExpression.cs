namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class LambdaExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsLambdaExpression ex = (CsLambdaExpression)pStatement;

			throw new NotImplementedException();
		}
	}
}
