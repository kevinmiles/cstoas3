namespace CStoFlash {
	using System;
	using AS3Writer;
	using Tools;

	/// <summary>
	/// TODO: test that it actually generates good AS3 :)
	/// TODO: VS templates
	/// TODO: JS version
	/// </summary>

	public static class Program {
		public static ArgumentsCollection Arguments { get; private set; }

		public static void Main(string[] pArguments) {
			ConverterFactory.AddParser(new As3NamespaceParser(), "as3");

			ArgumentsCollection commandLine = Arguments = new ArgumentsCollection(pArguments);
			string lang = "as3";

			if (!string.IsNullOrEmpty(commandLine[@"lang"])) {
				lang = commandLine[@"lang"];
				if (!ConverterFactory.HasConverter(lang)) {
					Console.WriteLine("The specified language does not has a parser associated.");
					return;
				}
			}

			if (commandLine["source"] == null) {
				Console.WriteLine("No source was specified.");
				return;
			}

			string[] sourceFiles = Project.GetSourceFiles(commandLine["source"]);
			if (sourceFiles == null || sourceFiles.Length == 0) {
				Console.WriteLine("Source files were not found at the specified location.");
				return;
			}

			if (commandLine["output"] == null) {
				Console.WriteLine("No output directory was specified.");
				return;
			}

			Project.WriteMessage = Console.WriteLine;
			try {
				bool debug = !string.IsNullOrEmpty(commandLine["debug"]);
				string output = commandLine["output"];

				commandLine.Remove("output");
				commandLine.Remove("debug");
				commandLine.Remove("source");
				commandLine.Remove(@"lang");

				Project.Parse(sourceFiles, lang, output, debug);

			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
