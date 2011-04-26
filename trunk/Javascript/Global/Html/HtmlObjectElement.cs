namespace Javascript.Global {
	using System;

	///<summary>
	///Inserts an object into the HTML page.
	///</summary>
	public class HtmlObjectElement : HtmlElement {
		///<summary>
		///Fires when an error occurs during object loading.
		///</summary>
		/// <remarks>IE and Firefox have trouble with JavaScript errors in the traditional event registration model. 
		/// Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.</remarks>
		public Action<HtmlDomEventArgs> onerror;
	}
}
