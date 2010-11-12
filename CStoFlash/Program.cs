namespace CStoFlash {
	using System;
	using System.Collections.Generic;
	using CsCompiler.AS3Writer;
	using CsCompiler.Tools;

	/// <summary>
	/// TODO: test that it actually generates good AS3 :)
	/// TODO: VS templates
	/// TODO: JS version
	/// </summary>

	public static class Program {
		public static void Main(string[] pArguments) {
			object test = new { x = 4, pepe = "marcelo", otro = new {} };

			ConverterFactory.AddParser(new As3NamespaceParser(), "as3");

			ArgumentsCollection commandLine = new ArgumentsCollection(pArguments);
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

			bool debug = !string.IsNullOrEmpty(commandLine["debug"]);
			string output = commandLine["output"];

			commandLine.Remove("output");
			commandLine.Remove("debug");
			commandLine.Remove("source");
			commandLine.Remove(@"lang");

			List<string> errors = Project.Parse(sourceFiles, lang, output, debug, commandLine, Project.Root);
			foreach (string error in errors) {
				Console.WriteLine(error);	
			}
		}
	}
}
