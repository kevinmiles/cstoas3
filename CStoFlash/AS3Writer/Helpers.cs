using System.Text;


namespace CStoFlash.AS3Writer {
	using System;

	using DDW;

	internal static class Helpers {
		internal static string GetModifiers(Modifier modifier) {
			StringBuilder sb = new StringBuilder();

			if ((modifier & Modifier.Sealed) != 0) {
				sb.Append("final ");
			}

			if ((modifier & Modifier.Public) != 0) {
				sb.Append("public ");
			}

			if ((modifier & Modifier.Internal) != 0) {
				sb.Append("internal ");
			}

			if ((modifier & Modifier.Private) != 0) {
				sb.Append("private ");
			}

			if ((modifier & Modifier.Protected) != 0) {
				sb.Append("protected ");
			}

			return sb.ToString();
		}

		public static string ConvertType(IType type) {
			if (type is TypeNode) {
				TypeNode tn = type as TypeNode;
				return convert(tn.GenericIndependentIdentifier);
			}

			if (type is PredefinedTypeNode) {
				PredefinedTypeNode tn = type as PredefinedTypeNode;
				return convert(tn.GenericIndependentIdentifier);
			}

			return convert(type.ToString());
		}

		public static string ConvertTokenId(TokenID id) {
			switch (id) {
				case TokenID.As:
					return "as";

				case TokenID.BAnd:
					return "&";

				case TokenID.BOr:
					return "|";

				case TokenID.Not:
					return "!";

				case TokenID.Quote:
					return "\"";

				case TokenID.Hash:
					return "#";

				case TokenID.SQuote:
					return "'";

				case TokenID.Star:
					return "*";

				case TokenID.Plus:
					return "+";

				case TokenID.Comma:
					return ",";

				case TokenID.Minus:
					return "-";

				case TokenID.Dot:
					return ".";

				case TokenID.Slash:
					return "/";

				case TokenID.PlusPlus:
					return "++";

				case TokenID.MinusMinus:
					return "--";

				case TokenID.And:
					return "&&";

				case TokenID.Or:
					return "||";

				case TokenID.MinusGreater:
					return "->";

				case TokenID.Equal:
					return "=";

				case TokenID.EqualEqual:
					return "==";

				case TokenID.NotEqual:
					return "!=";

				case TokenID.Less:
					return "<";

				case TokenID.LessEqual:
					return "<=";

				case TokenID.Greater:
					return ">";

				case TokenID.GreaterEqual:
					return ">=";

				case TokenID.PlusEqual:
					return "+=";

				case TokenID.MinusEqual:
					return "-=";

				case TokenID.StarEqual:
					return "+=";

				case TokenID.SlashEqual:
					return "/=";

				case TokenID.PercentEqual:
					return "%=";

				case TokenID.BAndEqual:
					return "&=";

				case TokenID.BOrEqual:
					return "|=";

				case TokenID.BXorEqual:
					return "^=";

				case TokenID.ShiftLeft:
					return "<<";

				case TokenID.ShiftLeftEqual:
					return "<<=";

				case TokenID.ShiftRight:
					return ">>";

				case TokenID.ShiftRightEqual:
					return ">>=";

				default:
					return id.ToString();
			}
		}

		private static string convert(string type) {
			if (type.IndexOf('<') != -1) {
				type = type.Substring(0, type.IndexOf('<'));
			}

			if (type.Equals("string[]", StringComparison.OrdinalIgnoreCase) ||
					type.Equals("int[]", StringComparison.OrdinalIgnoreCase))
				return "Array";

			if (type.Equals("long", StringComparison.OrdinalIgnoreCase) ||
				type.Equals("float", StringComparison.OrdinalIgnoreCase))
				return "Number";
			
			if (type.Equals("int", StringComparison.OrdinalIgnoreCase) ||
				type.Equals("int32", StringComparison.OrdinalIgnoreCase))
				return "int";

			if (type.Equals("uint", StringComparison.OrdinalIgnoreCase) ||
				type.Equals("uint32", StringComparison.OrdinalIgnoreCase))
				return "uint";

			if (type.Equals("string", StringComparison.OrdinalIgnoreCase))
				return "String";

			if (type.Equals("bool", StringComparison.OrdinalIgnoreCase))
				return "Boolean";

			return type;
		}
	}
}