﻿namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class Literal : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsLiteral li = (CsLiteral)pStatement;
			
			switch (li.type) {
				case CsTokenType.tkTRUE:
					return new Expression("true", pStatement.entity_typeref);

				case CsTokenType.tkFALSE:
					return new Expression("false", pStatement.entity_typeref);

				case CsTokenType.tkNULL:
					return new Expression("null", pStatement.entity_typeref);

				default:
					switch (li.literal_type) {
						case CsLiteralType.literal_int:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_uint:
						case CsLiteralType.literal_uint_U:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_long:
						case CsLiteralType.literal_long_L:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_decimal_M:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_ulong:
						case CsLiteralType.literal_ulong_L:
						case CsLiteralType.literal_ulong_UL:
							return new Expression(li.literal, pStatement.entity_typeref);


						case CsLiteralType.literal_double_D:
						case CsLiteralType.literal_double:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_number:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_float_F:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_char:
							return new Expression("'" + li.literal + "'", pStatement.entity_typeref);

						case CsLiteralType.literal_verbatim_string:
							string l = li.literal.Substring(2, li.literal.Length - 3);
							return new Expression(ParserHelper.EscapeString(l), pStatement.entity_typeref);

						default:
							return new Expression(ParserHelper.EscapeString(li.literal), pStatement.entity_typeref);
					}
			}
		}
	}
}
