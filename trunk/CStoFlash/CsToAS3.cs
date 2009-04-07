using System;
using System.Collections.Generic;
using System.IO;
using CStoFlash.Utils;
using DDW;

namespace CStoFlash {
	using AS3Writer;

	sealed class CsToAS3 {
		static CsParser _parser;

		static void Main(string[] args) {
			Arguments commandLine = new Arguments(args);

			if(commandLine["source"] == null) {
				Console.WriteLine("No source directory specified!.");
				return;
			}

			if (commandLine["output"] == null) {
				Console.WriteLine("No output directory specified!.");
				return;
			}

			AS3NamespaceParser parser = new AS3NamespaceParser();

			_parser = new CsParser(commandLine["output"], parser);

			List<Parser.Error> errors = _parser.Parse(Directory.GetFiles(commandLine["source"], "*.cs", SearchOption.AllDirectories));

			foreach (Parser.Error error in errors) {
				Console.WriteLine(error);
			}
		}
	}
}
