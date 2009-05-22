using System;
using System.Collections.Generic;
using System.IO;
using CStoFlash.Utils;


namespace CStoFlash {
	using AS3Writer;

	sealed class CsToAS3 {
		static CsParser _parser;

		static void Main(string[] pArgs) {
			Arguments commandLine = new Arguments(pArgs);

			if(commandLine["source"] == null) {
				Console.WriteLine("No source directory specified!.");
				return;
			}

			if (commandLine["output"] == null) {
				Console.WriteLine("No output directory specified!.");
				return;
			}

			As3NamespaceParser parser = new As3NamespaceParser();

			_parser = new CsParser(commandLine["output"], parser);

			List<string> errors = _parser.Parse(Directory.GetFiles(commandLine["source"], "*.cs", SearchOption.AllDirectories));

			foreach (string error in errors) {
				Console.WriteLine(error);
			}

		}
	}
}
