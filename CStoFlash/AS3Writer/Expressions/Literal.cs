namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class Literal : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsLiteral li = (CsLiteral)pStatement;

			switch (li.type) {
				case CsTokenType.tkTRUE:
					return new Expression("true", "bool");

				case CsTokenType.tkFALSE:
					return new Expression("false", "bool");

				case CsTokenType.tkNULL:
					return new Expression("null", "null");

				default:
					switch (li.literal_type) {
						case CsLiteralType.literal_int:
							return new Expression(li.literal, "int");

						case CsLiteralType.literal_uint:
						case CsLiteralType.literal_uint_U:
							return new Expression(li.literal, "uint");

						case CsLiteralType.literal_long:
						case CsLiteralType.literal_long_L:
							return new Expression(li.literal, "long");

						case CsLiteralType.literal_decimal_M:
							return new Expression(li.literal, "decimal");

						case CsLiteralType.literal_ulong:
						case CsLiteralType.literal_ulong_L:
						case CsLiteralType.literal_ulong_UL:
							return new Expression(li.literal, "long");


						case CsLiteralType.literal_double_D:
						case CsLiteralType.literal_double:
							return new Expression(li.literal, "double");

						case CsLiteralType.literal_number:
							return new Expression(li.literal, "number");

						case CsLiteralType.literal_float_F:
							return new Expression(li.literal, "float");

						case CsLiteralType.literal_char:
							return new Expression("'" + li.literal + "'", "char");

						case CsLiteralType.literal_verbatim_string:
							string l = li.literal.Substring(2, li.literal.Length - 3);
							return new Expression(ParserHelper.EscapeString(l), "string");

						default:
							return new Expression(ParserHelper.EscapeString(li.literal), "string");
					}
			}
		}
	}
}
