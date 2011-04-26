namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class QualifiedAliasMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//identifier "::" identifier (type-argument-list)? "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}
	}
}
