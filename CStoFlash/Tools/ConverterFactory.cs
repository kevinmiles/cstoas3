namespace CStoFlash.Tools {
	using System.Collections.Generic;

	public static class ConverterFactory {
		private static readonly Dictionary<string, INamespaceParser> _parsers =
			new Dictionary<string, INamespaceParser>();

		public static void AddParser(INamespaceParser pCsAstVisitor, string pName) {
			_parsers[pName.ToLowerInvariant()] = pCsAstVisitor;
		}

		public static bool HasConverter(string pName) {
			return _parsers.ContainsKey(pName.ToLowerInvariant());
		}

		public static INamespaceParser GetConverter(string pName) {
			return _parsers[pName];
		}
	}
}
