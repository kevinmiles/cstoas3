namespace Javascript.Global {
	///<summary>
	///The meta element represents various kinds of metadata that cannot be expressed using the title , base , link , style , and script elements.The marquee element is a presentational element that animates content. CSS transitions and animations are a more appropriate mechanism.
	///</summary>
	public abstract class HtmlMetaElement : HtmlElement {
		public string name {
			get;
			set;
		}
		public string httpEquiv {
			get;
			set;
		}
		public string content {
			get;
			set;
		}
		public string scheme {
			get;
			set;
		}
	}
}
