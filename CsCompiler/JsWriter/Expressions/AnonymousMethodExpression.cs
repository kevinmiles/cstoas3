﻿namespace CsCompiler.JsWriter.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public sealed class AnonymousMethodExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//"delegate" (explicit-anonymous-function-signature)? block
			throw new NotImplementedException();
		}
	}
}
