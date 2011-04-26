namespace Javascript.Global {
	///<summary>
	///The label represents a caption in a user interface. The caption can be associated with a specific form control , known as the labelelement's labeled control , either using for attribute, or by putting the form control inside the label element itself.
	///</summary>
	public abstract partial class HtmlLabelElement : HtmlElement {
		public HtmlForm form {
			get;
			set;
		}
		public string htmlFor {
			get;
			set;
		}
		public HtmlElement control {
			get;
			set;
		}
	}
}
