using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CStoFlash.Utils;
using DDW;
using DDW.Collections;

namespace CStoFlash {
	sealed class CsToAS3 {
		static void Main(string[] args) {
			Arguments CommandLine = new Arguments(args);

			List<Parser.Error> errors = new List<Parser.Error>();

			if(CommandLine["source"] == null) {
				Console.WriteLine("No source directory specified!.");
				return;
			}

			string[] files = Directory.GetFiles(CommandLine["source"], "*.cs", SearchOption.AllDirectories);
			Stopwatch sw = new Stopwatch();
			sw.Reset();

			foreach (string fileName in files) {
				sw.Start();
				ParseFile(fileName, errors);
				sw.Stop();
			}

			Console.WriteLine("Time parsing : " + sw.Elapsed + ", for " + files.Length + " file(s).");
		}

		private static void ParseFile(string fileName, List<Parser.Error> errors) {
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, true);
			Lexer l = new Lexer(sr);
			TokenCollection toks = l.Lex();

			Parser p = new Parser(fileName);
			CompilationUnitNode cu = p.Parse(toks, l.StringLiterals);

			errors.AddRange(p.Errors);
		}
	}
}
