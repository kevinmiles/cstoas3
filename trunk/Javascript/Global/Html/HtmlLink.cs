namespace Javascript.Global {
	using System;

	///<summary>
	///Represents a LINK html node
	///</summary>
	public class HtmlLink : HtmlElement {
		protected HtmlLink() {
		}
		///<summary>
		///Sets or retrieves the destination URL or anchor point.
		///</summary>
		public string href {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the relationship between the object and the destination of the link. e.g. 'stylesheet'
		///</summary>
		public string rel {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the MIME type of the object. e.g. 'text/css'
		///</summary>
		public string type {
			get;
			set;
		}
		///<summary>
		///Fires when an error occurs during object loading.
		///</summary>
		/// <remarks>IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
		/// Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.</remarks>
		public Action<HtmlDomEventArgs> onerror;
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
	}
}
