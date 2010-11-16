namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

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

						case CsLiteralType.literal_uint_U:
							return new Expression(li.literal.Substring(0, li.literal.Length-1), pStatement.entity_typeref);

						case CsLiteralType.literal_uint:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_long:
							return new Expression(li.literal, pStatement.entity_typeref);

						case CsLiteralType.literal_long_L:
							return new Expression(li.literal.Substring(0, li.literal.Length - 1), pStatement.entity_typeref);

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
							return new Expression(Helpers.EscapeString(l), pStatement.entity_typeref);

						default:
							return new Expression(Helpers.EscapeString(li.literal), pStatement.entity_typeref);
					}
			}
		}
	}
}
