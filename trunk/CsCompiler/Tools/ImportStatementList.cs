namespace CsCompiler.Tools {
	using System.Collections.Generic;

	public static class ImportStatementList {
		public static void Init() {
			List = new List<string>();
		}

		public static List<string> List {
			get;
			private set;
		}

		public static void AddImport(string pImport) {
			if (string.IsNullOrEmpty(pImport)) return;
			if (List.Contains(pImport)) return;
			List.Add(pImport);
		}
	}
}
