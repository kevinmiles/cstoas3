namespace Javascript.Global {
	using System;

	///<summary>
	///Specifies a script for the page that is interpreted by a script engine.
	///</summary>
	public class HtmlScriptElement : HtmlElement {
		///<summary>
		///Fires when an error occurs during object loading.
		///</summary>
		///<remarks>IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
		/// Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.</remarks>
		public Action<HtmlDomEventArgs> onerror;
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
	}
}
