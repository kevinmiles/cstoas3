namespace Javascript.Global {
	using System;

	///<summary>
	///Allows documents of any type to be embedded.
	///</summary>
	public class HtmlEmbedElement : HtmlElement {
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
	}
}
