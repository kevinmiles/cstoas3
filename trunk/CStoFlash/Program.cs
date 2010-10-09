namespace CStoFlash {
	using System;
	using AS3Writer;
	using Tools;

	/// <summary>
	/// @TODO:
	/// Custom event handlers (not AS3)
	/// probar que compile :)
	/// </summary>

	public static class Program {
		public static void Main(string[] pArgs) {
			ConverterFactory.AddParser(new As3NamespaceParser(), "as3");

			Arguments commandLine = new Arguments(pArgs);
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
			//try {
				Project.Parse(sourceFiles, lang, commandLine["output"]);	

			//} catch (Exception ex) {
			//    Console.WriteLine(ex.ToString());
			//}
		}
	}
}
