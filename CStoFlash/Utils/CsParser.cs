namespace CStoFlash.Utils {
	using System.Collections.Generic;
	using System.IO;

	using DDW;
	using DDW.Collections;

	public sealed class CsParser {
		private readonly string _output;
		private readonly INamespaceParser _parser;

		public CsParser(string pOutDir, INamespaceParser pParser) {
			_parser = pParser;
			_output = pOutDir.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
		}

		public List<Parser.Error> Parse(string[] files) {
			List<Parser.Error> errors = new List<Parser.Error>();
			foreach (string fileName in files) {
				parseFile(fileName, errors);
			}

			return errors;
		}

		private void parseFile(string fileName, List<Parser.Error> errors) {
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, true);
			Lexer l = new Lexer(sr);
			TokenCollection toks = l.Lex();

			Parser p = new Parser(fileName);
			CompilationUnitNode cu = p.Parse(toks, l.StringLiterals);

			foreach (NamespaceNode ns in cu.Namespaces) {
				_parser.Parse(ns, _output);
			}
		
			errors.AddRange(p.Errors);
		}
	}
}