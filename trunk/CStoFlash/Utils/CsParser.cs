namespace CStoFlash.Utils {
	using System.Collections.Generic;
	using System.IO;

	using AS3Writer;

	using DDW;
	using DDW.Collections;

	internal sealed class CsParser {
		private readonly string _output;
		
		//private readonly AS3Visitor _visitor;

		public CsParser(string pOutDir) {
			_output = pOutDir.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
			//_visitor = new AS3Visitor(_output);
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
				NamespaceParser.AddNamespace(ns, _output);
			}
		
			//cu.AcceptVisitor(_visitor, null);

			errors.AddRange(p.Errors);
		}
	}
}