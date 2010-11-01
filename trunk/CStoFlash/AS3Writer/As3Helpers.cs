namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;
	using CsParser;
	using Tools;

	public static class As3Helpers {
		private static readonly Dictionary<string,string> _flashModifiers = new Dictionary<string, string> {
			{"sealed","final"},
			{"extern",""},
			{"partial",""},
			{"unsafe",""},
			{"virtual",""},
			{"volatile",""},
			{"abstract",""}
		};

		public static string ConvertModifiers(List<string> pModifiers, Dictionary<string , string> pReplaceable = null) {
			List<string> mods = new List<string>();
			foreach (string modifier in pModifiers) {
				string o;
				string mod = modifier;
				if (_flashModifiers.TryGetValue(modifier, out o)) {
					if (string.IsNullOrEmpty(o)) continue;
					mod = o;
				}

				if (pReplaceable != null) {
					if (pReplaceable.TryGetValue(mod, out o))
						mod = o;
				}

				mods.Add(mod);
			}

			string ret = mods.Join(" ");
			return string.IsNullOrEmpty(ret) ? string.Empty : ret + " ";
		}

		public static string GetCallingArguments(List<Expression> pArguments) {
			List<string> values = new List<string>();
			foreach (Expression expression in pArguments) {
				values.Add(expression.Value);
			}

			return values.Join(", ");
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
				//return "Array";
			}

			if (pType.Equals("long", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("float", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("double", StringComparison.OrdinalIgnoreCase))
				return "Number";
			
			if (pType.Equals("int", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("int32", StringComparison.OrdinalIgnoreCase))
				return "int";

			if (pType.Equals(@"uint", StringComparison.OrdinalIgnoreCase) ||
				pType.Equals("uint32", StringComparison.OrdinalIgnoreCase))
				return @"uint";

			if (pType.Equals("string", StringComparison.OrdinalIgnoreCase))
				return "String";

			if (pType.Equals("Exception", StringComparison.OrdinalIgnoreCase))
				return "Error";

			if (pType.Equals("object", StringComparison.OrdinalIgnoreCase))
				return "Object";

			if (pType.Equals(@"bool", StringComparison.OrdinalIgnoreCase))
				return "Boolean";

			return pType;
		}

		public static object GetParameters(List<TheMethodArgument> pArguments) {
			List<string> args = new List<string>();
			foreach (TheMethodArgument methodArgument in pArguments) {
				args.Add(string.Format("{0}:{1}{2}",
					methodArgument.Name, 
					Convert(methodArgument.Type),
					methodArgument.DefaultValue == null ? string.Empty : " = "+methodArgument.DefaultValue.Value
				));
			}

			return args.Join(", ");
		}
	}
}