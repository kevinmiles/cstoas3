﻿namespace CsCompiler.AS3Writer.Expressions {
	using Metaspec;
	using Tools;

	public class ConditionalExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsConditionalExpression ex = (CsConditionalExpression)pStatement;

			return new Expression(
				pCreator.Parse(ex.condition).Value + " ? " +
				pCreator.Parse(ex.true_expression).Value + " : " +
				pCreator.Parse(ex.false_expression).Value,

				pStatement.entity_typeref
			);
		}
	}
}
