namespace CStoFlash {
	using System;
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
	using CsCompiler.AS3Writer;
	using CsCompiler.JsWriter;
	using CsCompiler.Tools;

	/// <summary>
	/// TODO: test that it actually generates good AS3 :)
	/// TODO: VS templates
	/// TODO: JS version
	/// </summary>

	public static class Program {
		/*
		private const string TEST = @"
D:\Work-Efx\Flash\FlashCoreCs\FlashCoreCs\as3code\extremefx\Main.as(38): col: 9 Warning: Duplicate variable definition.

                                var ii:int = 123;
                                    ^
";

		static readonly Regex _errorMessage = new Regex(@"(.*?)\((\d+)\)\:\W+col\:\W+(\d+)\W+(\w+):\W+(.*)", RegexOptions.Compiled | RegexOptions.CultureInvariant);
		*/
		public static void Main(string[] pArguments) {
			/*
			string[] lines = TEST.Split(new[] { '\r', '\n' });
			List<Error> el = new List<Error>();
			foreach (string line in lines) {
				if (string.IsNullOrEmpty(line)) continue;

				Error e = new Error();

				Match m = _errorMessage.Match(line);
				if (m.Success) {//parse error message
					//capture 1: row
					//capture 2: col
					//capture 3: type (Warning/Error)
					//capture 4: Message

					e.File = m.Groups[1].Value;

					int i;
					int.TryParse(m.Groups[2].Value, out i);
					e.Line = i;

					int.TryParse(m.Groups[3].Value, out i);
					e.Column = i;

					switch (m.Groups[4].Value.ToLowerInvariant()) {
						case "warning":
							e.ErrorType = ErrorType.Warning;
							break;

						case "error":
							e.ErrorType = ErrorType.Error;
							break;

						default:
							e.ErrorType = ErrorType.Message;
							break;
					}

					e.Message = m.Groups[5].Value;
					el.Add(e);

				} else {
					if (line.Trim().Equals("^", StringComparison.Ordinal)) {
						el[el.Count - 2].AdditionalInfo = el[el.Count - 1].Message;
						el.RemoveAt(el.Count-1);
						continue;
					}

					e.ErrorType = ErrorType.Message;
					e.Message = line.Trim();
					el.Add(e);
				}
			}
			*/


			ConverterFactory.AddParser(new As3NamespaceParser(), "as3");
			ConverterFactory.AddParser(new JsNamespaceParser(), "js");

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

			ICollection<Error> errors = Project.Parse(sourceFiles, lang, output, debug, commandLine, Project.Root);
			foreach (Error error in errors) {
				Console.WriteLine(error.Message);	
			}
		}
	}
}
