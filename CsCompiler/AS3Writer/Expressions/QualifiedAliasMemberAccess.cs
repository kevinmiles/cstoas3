namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class QualifiedAliasMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//identifier "::" identifier (type-argument-list)? "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}
	}
}
