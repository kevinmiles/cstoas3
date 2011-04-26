namespace Javascript.Global {
	///<summary>
	///Represents an @page rule within a styleSheet.
	///</summary>
	public class HtmlStyleSheetPage {
		///<summary>
		///Retrieves a string that identifies the pseudo class of the page or pages an @page rule applies to.
		///</summary>
		public string pseudoClass {
			get;
			set;
		}
		///<summary>
		///Retrieves a string that identifies which page or pages an @page rule applies to.
		///</summary>
		public string selector {
			get;
			set;
		}
	}
}
