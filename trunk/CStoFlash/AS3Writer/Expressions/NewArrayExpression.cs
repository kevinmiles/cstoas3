﻿namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;

	using Utils;

	public class NewArrayExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//"new" non-array-type "[" expression-list "]" ( rank-specifiers )? ( array-initializer )?
			//"new" non-array-type? rank-specifiers array-initializer
			CsNewArrayExpression ex = (CsNewArrayExpression) pStatement;

			string initializer;
			foreach (CsNode node in ex.initializer.initializers) {
				
			}

		}
	}
}