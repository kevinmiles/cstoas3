namespace Javascript.Global {
	///<summary>
	///Draws a horizontal rule.
	///</summary>
	public class HtmlHorizontalRule : HtmlElement {
		protected HtmlHorizontalRule() {
		}
		public string align {
			get;
			set;
		}
		public string color {
			get;
			set;
		}
		public bool noShade {
			get;
			set;
		}
		public string size {
			get;
			set;
		}
	}
}
