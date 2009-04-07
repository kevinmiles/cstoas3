package CStoFlash {
	final class CsToAS3 {
		function Main(args:Array):void {		
			var CommandLine:Arguments = new Arguments(args);			
			var errors:List = new List();			
			if (CommandLine["source"] == null){			
				Console.WriteLine("No source directory specified!.");				
				return;			
			}			
			
			var files:Array = Directory.GetFiles(CommandLine["source"], "*.cs", SearchOption.AllDirectories);			
			var sw:Stopwatch = new Stopwatch();			
			sw.Reset();			
			
			var ie2:IEnumerator = files.getEnumerator();			
			while (ie2.moveNext()){			
				var fileName:String = ie2.current as String;			
				sw.Start();				
				ParseFile(fileName, errors);				
				sw.Stop();				
			}			
			
			Console.WriteLine("Time parsing : " + sw.Elapsed + ", for " + files.Length + " file(s).");			
		
		}		
		
		private function ParseFile(fileName:String, errors:List):void {		
			var fs:FileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);			
			var sr:StreamReader = new StreamReader(fs, true);			
			var l:Lexer = new Lexer(sr);			
			var toks:TokenCollection = l.Lex();			
			var p:Parser = new Parser(fileName);			
			var cu:CompilationUnitNode = p.Parse(toks, l.StringLiterals);			
			errors.AddRange(p.Errors);			
		
		}		
		
	}
}