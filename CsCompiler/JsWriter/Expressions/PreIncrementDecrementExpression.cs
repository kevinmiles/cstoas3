﻿namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class PreIncrementDecrementExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsPreIncrementDecrementExpression ex = (CsPreIncrementDecrementExpression)pStatement;

			Expression exp = pCreator.Parse(ex.unary_expression);

			return new Expression(
				JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + exp.Value,
				pStatement.entity_typeref
			);
		}
	}
}
