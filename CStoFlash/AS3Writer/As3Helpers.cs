using System.Text;


namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;

	using Metaspec;

	using Utils;

	public static class As3Helpers {
		private static readonly char[] _paramTrim = new[] { ',', ' ' };

		public static string GetParams(CsArgumentList pList) {
			if (pList == null || pList.list == null)
				return string.Empty;

			StringBuilder prms = new StringBuilder();
			foreach (CsArgument param in pList.list) {
				Expression ex = FactoryExpressionCreator.Parse(param.expression);
				prms.Append(ex.Value);
				prms.Append(", ");
			}

			return prms.ToString().TrimEnd(_paramTrim);
		}
		
		public static string GetParams(IEnumerable<CsFormalParameter> pLinkedList) {
			if (pLinkedList == null)
				return string.Empty;

			StringBuilder prms = new StringBuilder();
			foreach (CsFormalParameter param in pLinkedList) {
				prms.AppendFormat("{0}:{1}, ",
					param.identifier.identifier,
					Convert(ParserHelper.GetType(param.type))
				);
			}

			return prms.ToString().TrimEnd(_paramTrim);
		}

		public static string GetParams(CsEntityFormalParameter[] pLinkedList) {
			StringBuilder prms = new StringBuilder();
			foreach (CsEntityFormalParameter param in pLinkedList) {
				prms.AppendFormat("{0}:{1}, ",
					param.param == null ? param.name : param.param.identifier.identifier,
					Convert(ParserHelper.GetType(param.type))
					//Convert(ParserHelper.GetType(param.param.type))
				);
			}

			return prms.ToString().TrimEnd(_paramTrim);
		}


		public static string GetModifiers(CsModifiers pModifier) {
			StringBuilder sb = new StringBuilder();

			if ((pModifier.flags & (uint)CsModifierEnum.mNEW) != 0)
				sb.Append("new ");

			if ((pModifier.flags & (uint)CsModifierEnum.mSEALED) != 0)
				sb.Append("final ");

			if ((pModifier.flags & (uint)CsModifierEnum.mPUBLIC) != 0)
				sb.Append("public ");

			if ((pModifier.flags & (uint)CsModifierEnum.mINTERNAL) != 0)
				sb.Append("internal ");

			if ((pModifier.flags & (uint)CsModifierEnum.mPROTECTED) != 0)
				sb.Append("protected ");

			if ((pModifier.flags & (uint)CsModifierEnum.mPRIVATE) != 0)
				sb.Append("private ");

			if ((pModifier.flags & (uint)CsModifierEnum.mOVERRIDE) != 0)
				sb.Append("override ");

			if ((pModifier.flags & (uint)CsModifierEnum.mSTATIC) != 0)
				sb.Append("static ");

			return sb.ToString();
		}
	
		public static string Convert(string pType) {
			int l = pType.IndexOf('<');
			int r = pType.IndexOf('>');

			if (pType.StartsWith("Vector<", StringComparison.Ordinal)) {
				pType = pType.Substring(7, pType.Length - 8);
				return "Vector.<" + Convert(pType) + ">";
			}

			if ((l != -1 && r != -1 && l < r)) {//remove generics
				pType = pType.Substring(0, l);
			}

			int brackets = pType.IndexOf("[]", StringComparison.Ordinal);
			
			if (brackets != -1 && brackets == pType.Length - 2) {
				pType = pType.Substring(0, pType.Length - 2);
				return "Vector.<"+Convert(pType)+">";
			}

			if (pType.Equals("long", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("float", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("double", StringComparison.OrdinalIgnoreCase))
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