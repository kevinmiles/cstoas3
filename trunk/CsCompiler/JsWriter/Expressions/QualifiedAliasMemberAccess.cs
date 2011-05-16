namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class QualifiedAliasMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//identifier "::" identifier (type-argument-list)? "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}
	}
}
