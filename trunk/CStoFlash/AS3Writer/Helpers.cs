using System.Text;


namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;

	using DDW;

	public static class Helpers {
		private static readonly char[] _paramTrim = new[] { ',', ' ' };

		public static string GetParams(IEnumerable<ParamDeclNode> pParamDeclNodes) {
			StringBuilder prms = new StringBuilder();
			foreach (ParamDeclNode param in pParamDeclNodes) {
				prms.AppendFormat("{0}:{1}, ", param.Name, ConvertType(param.Type));
			}

			return prms.ToString().TrimEnd(_paramTrim);
		}


		public static string GetModifiers(Modifier pModifier) {
			StringBuilder sb = new StringBuilder();

			if ((pModifier & Modifier.New) != 0) {
				sb.Append("new ");
			}

			if ((pModifier & Modifier.Sealed) != 0) {
				sb.Append("final ");
			}

			if ((pModifier & Modifier.Public) != 0) {
				sb.Append("public ");
			}

			if ((pModifier & Modifier.Internal) != 0) {
				sb.Append("internal ");
			}

			if ((pModifier & Modifier.Private) != 0) {
				sb.Append("private ");
			}

			if ((pModifier & Modifier.Protected) != 0) {
				sb.Append("protected ");
			}

			return sb.ToString();
		}

		public static string ConvertType(IType pType) {
			if (pType is TypeNode) {
				TypeNode tn = pType as TypeNode;
				return convert(tn.GenericIndependentIdentifier);
			}

			if (pType is PredefinedTypeNode) {
				PredefinedTypeNode tn = pType as PredefinedTypeNode;
				return convert(tn.GenericIndependentIdentifier);
			}

			return convert(pType.ToString());
		}

		public static string ConvertTokenId(TokenID pId) {
			switch (pId) {
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
					return pId.ToString();
			}
		}

		private static string convert(string pType) {
			if (pType.IndexOf('<') != -1) {
				pType = pType.Substring(0, pType.IndexOf('<'));
			}

			if (pType.Equals("string[]", StringComparison.OrdinalIgnoreCase) ||
					pType.Equals("int[]", StringComparison.OrdinalIgnoreCase))
				return "Array";

			if (pType.Equals("long", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("float", StringComparison.OrdinalIgnoreCase))
				return "Number";
			
			if (pType.Equals("int", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("int32", StringComparison.OrdinalIgnoreCase))
				return "int";

			if (pType.Equals("uint", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("uint32", StringComparison.OrdinalIgnoreCase))
				return "uint";

			if (pType.Equals("string", StringComparison.OrdinalIgnoreCase))
				return "String";

			if (pType.Equals("bool", StringComparison.OrdinalIgnoreCase))
				return "Boolean";

			return pType;
		}
	}
}