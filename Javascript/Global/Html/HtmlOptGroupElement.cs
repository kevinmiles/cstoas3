namespace Javascript.Global {
	///<summary>
	///The optgroup element represents a group of option elements with a common label.
	///</summary>
	public abstract class HtmlOptGroupElement : HtmlElement {
		public new bool disabled {
			get;
			set;
		}
		public string label {
			get;
			set;
		}
	}
}
