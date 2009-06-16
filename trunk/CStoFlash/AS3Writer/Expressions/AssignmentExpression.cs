namespace CStoFlash.AS3Writer.Expressions {
	using System;

	using Metaspec;

	using Utils;

	public class AssignmentExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAssignmentExpression ex = (CsAssignmentExpression)pStatement;

			Expression left = FactoryExpressionCreator.Parse(ex.lhs);
			Expression right = FactoryExpressionCreator.Parse(ex.rhs);
			string type = ParserHelper.GetType(pStatement.entity_typeref);

			if ((ex.lhs is CsElementAccess) && left.InternalType) {
				switch (ex.oper) {
					case CsTokenType.tkASSIGN:
						return new Expression(string.Format(left.Value, right.Value), type);

					case CsTokenType.tkPLUS_EQ:
					case CsTokenType.tkMINUS_EQ:
					case CsTokenType.tkDIV_EQ:
					case CsTokenType.tkMUL_EQ:
						string getter = ElementAccessHelper.parseElementAccess(ex.lhs, true, false).Value;
						return new Expression(string.Format(left.Value, getter + ParserHelper.GetTokenType(convertToken(ex.oper)) + right.Value), type);
				}
			}

			return new Expression(left.Value + ParserHelper.GetTokenType(ex.oper) + right.Value, type);
		}

		private static CsTokenType convertToken(CsTokenType pInToken) {
			switch (pInToken) {
				case CsTokenType.tkPLUS_EQ:
					return CsTokenType.tkPLUS;

				case CsTokenType.tkMINUS_EQ:
					return CsTokenType.tkMINUS;

				case CsTokenType.tkDIV_EQ:
					return CsTokenType.tkDIV;

				case CsTokenType.tkMUL_EQ:
					return CsTokenType.tkSTAR;

				case CsTokenType.tkMOD_EQ:
					return CsTokenType.tkMOD;

				default:
					throw new Exception();
			}
		}
	}
}
