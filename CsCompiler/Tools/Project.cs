namespace CsCompiler.Tools {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using VsProjectParser;

	public static class Project {
		private static CsParser _parser;
		public static Dictionary<string, string> GetArguments(string pSettings) {
			Dictionary<string, string> args = new Dictionary<string, string>();
			if (!string.IsNullOrEmpty(pSettings)) {
				pSettings = pSettings.Replace("\r\n", "\n").Replace("\r", "\n");
				string[] lines = pSettings.Split('\n');

				foreach (string line in lines) {
					if (string.IsNullOrEmpty(line))
						continue;

					int colon = line.IndexOf(":");
					if (colon == -1)
						continue;

					args.Add(line.Substring(0, colon).Trim(), line.Substring(colon + 1).Trim());
				}	
			}

			return args;
		}

		public static string[] GetSourceFiles(string pFileOrDirectory) {
			bool isFile = File.Exists(pFileOrDirectory);

			if (isFile && pFileOrDirectory.EndsWith(@".csproj", StringComparison.OrdinalIgnoreCase)) {
				//it's a project file
				VsProject p = VsProject.Load(pFileOrDirectory);
				string rootPath = Path.GetDirectoryName(pFileOrDirectory);

				return (from item in p.Items
						where item.ItemType == VsItemType.CompileItem && !item.Item.EndsWith("AssemblyInfo.cs", StringComparison.OrdinalIgnoreCase)
						select (rootPath + "\\" + item.Item)).ToArray();
			}

			if (Directory.Exists(pFileOrDirectory)) {
				//it's a directory on disk
				return Directory.GetFiles(pFileOrDirectory, "*.cs", SearchOption.AllDirectories);
			}

			return isFile ? new[] {pFileOrDirectory} : null;
		}

		public static List<string> Parse(string[] pSourceFiles, string pTargetLanguage, string pOutputDirectory, bool pDebug, Dictionary<string, string> pArguments, string pRoot) {
			INamespaceParser parser = ConverterFactory.GetConverter(pTargetLanguage);
			Root = pRoot;
			_parser = new CsParser(pOutputDirectory, parser);

			return _parser.Parse(pSourceFiles, pDebug, pArguments);
		}

		public static string Root {
			get; private set; }
	}
}
