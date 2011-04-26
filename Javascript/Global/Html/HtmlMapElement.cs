namespace Javascript.Global {
	///<summary>
	///The map element, in conjunction with any area element descendants, defines an image map . The element represents its children.
	///</summary>
	public abstract class HtmlMapElement : HtmlElement {
		public string name {
			get;
			set;
		}
		public HtmlElementCollection areas {
			get;
			set;
		}
		public HtmlElementCollection images {
			get;
			set;
		}
	}
}
