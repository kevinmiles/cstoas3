namespace Javascript.Global {
	using System;

	public class HtmlBody : HtmlElement {
		protected HtmlBody() {
		}
		///<summary>
		///Creates a TextRange object for the element
		///</summary>
		///<returns></returns>
		public HtmlTextRange createTextRange() {
			return null;
		}
		///<summary>
		///Fires on the object immediately after its associated document prints or previews for printing.
		///</summary>
		public Action<HtmlDomEventArgs> onafterprint;
		///<summary>
		///Fires on the object before its associated document prints or previews for printing.
		///</summary>
		public Action<HtmlDomEventArgs> onbeforeprint;
		///<summary>
		///Fires prior to a page being unloaded.
		///</summary>
		public Action<HtmlDomEventArgs> onbeforeunload;
		///<summary>
		///Raised when there are changes to the portion of a URL that follows the number sign (#).
		///</summary>
		public new Action<HtmlDomEventArgs> onhashchange;
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
		///<summary>
		///Raised when Internet Explorer is working offline.
		///</summary>
		public Action<HtmlDomEventArgs> onoffline;
		///<summary>
		///Raised when Internet Explorer is working online.
		///</summary>
		public Action<HtmlDomEventArgs> ononline;
		///<summary>
		///Fires when the current selection changes.
		///</summary>
		public Action<HtmlDomEventArgs> onselect;
		///<summary>
		///Fires immediately before the object is unloaded.
		///</summary>
		public Action<HtmlDomEventArgs> onunload;
	}
}
