namespace Javascript.Global {
	using System;

	///<summary>
	///Specifies that the contained controls take part in a form.
	///</summary>
	public class HtmlForm : HtmlElement {
		///<summary>
		///Sets or retrieves a list of character encodings for input data that must be accepted by the server processing the form.
		///</summary>
		public string acceptCharset {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the number of objects in a collection.
		///</summary>
		public int length {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the URL to which the form content is sent for processing.
		///</summary>
		public string action {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves how to send the form data to the server.
		///Receives one of the following values:
		///<list type="table">
		///<item><term>GET</term><description>Append the arguments to the action URL and open it as if it were an anchor.</description></item>
		///<item><term>POST</term><description>Send the data through an HTTP post transaction.</description></item>
		///</list>
		///</summary>
		public string method {
			get;
			set;
		}
		///<summary>
		///Submits the form.
		///</summary>
		public void submit() {
		}
		///<summary>
		///Fires when the user resets a form.
		///</summary>
		public Action<HtmlDomEventArgs> onreset;

		///<summary>
		///Fires when a FORM is about to be submitted.
		///</summary>
		public Action<HtmlDomEventArgs> onsubmit;
	}
}
