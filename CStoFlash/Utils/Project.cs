namespace CStoFlash.Utils {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using VsProjectParser;

	public static class Project {
		public static Action<string> WriteMessage;
		private static CsParser _parser;

		public static string[] GetSourceFiles(string pFileOrDirectory) {
			bool isFile = File.Exists(pFileOrDirectory);

			if (isFile && pFileOrDirectory.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase)) {
				//it's a project file
				VsProject p = VsProject.Load(pFileOrDirectory);
				return (from item in p.Items where item.ItemType == VsItemType.CompileItem select item.Item).ToArray();
			}

			if (Directory.Exists(pFileOrDirectory)) {
				//it's a directory on disk
				return Directory.GetFiles(pFileOrDirectory, "*.cs", SearchOption.AllDirectories);
			}

			return isFile ? new[] {pFileOrDirectory} : null;
		}


		public static void Parse(string[] pSourceFiles, string pTargetLanguage, string pOutputDirectory) {
			INamespaceParser parser = ConverterFactory.GetConverter(pTargetLanguage);

			_parser = new CsParser(pOutputDirectory, parser);
			List<string> errors = _parser.Parse(pSourceFiles);
			foreach (string error in errors) {
				writeMessage(error);
			}
		}

		private static void writeMessage(string pMessage) {
			if (WriteMessage != null) {
				WriteMessage(pMessage);
			}
		}
	}
}
