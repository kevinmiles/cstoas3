package CStoFlash.Utils {
	public class Arguments extends Dictionary {
		public function Arguments(Args:IEnumerable) {		
			var splitter:Regex = new Regex("^-{1,2}|^/|=|:", RegexOptions.IgnoreCase | RegexOptions.Compiled);			
			var remover:Regex = new Regex("^['\"]?(.*?)['\"]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);			
			var parameter:String = null;			
			var parts:Array;			
			
			var ie1:IEnumerator = Args.getEnumerator();			
			while (ie1.moveNext()){			
				var Txt:String = ie1.current as String;			
				parts = splitter.Split(Txt, 3);				
			}			
			
			if (parameter == null){			
				return;			
			}			
			
			if (!ContainsKey(parameter)){			
				Add(parameter, "true");				
			
			}			
			
		
		}		
		
	}
}