namespace Javascript.Global {
	using System;

	///<summary>
	///Specifies an individual frame within a frameSet element.
	///</summary>
	public class HtmlFrameElement : HtmlElement {
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
		public string frameBorder {
			get;
			set;
		}
		public string name {
			get;
			set;
		}
		public bool noResize {
			get;
			set;
		}
		public string scrolling {
			get;
			set;
		}
		public string src {
			get;
			set;
		}
		public HtmlDocument contentDocument {
			get;
			set;
		}
	}
}
