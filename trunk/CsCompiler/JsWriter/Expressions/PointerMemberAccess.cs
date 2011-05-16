namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class PointerMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			// expression "->" identifier (type-argument-list?)
			throw new NotImplementedException();
		}
	}
}
