namespace Javascript.Global {
	using System;

	///<summary>
	///Embeds an image or a video clip in the document.
	///</summary>
	public class HtmlImage : HtmlElement {
		public void main() {
		}
		///<summary>
		///Sets or retrieves how the object is aligned with adjacent text.
		///</summary>
		public string align {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a text alternative to the graphic.
		///</summary>
		public string alt {
			get;
			set;
		}
		///<summary>
		///Sets the properties to draw around the object.
		///</summary>
		public string border {
			get;
			set;
		}
		///<summary>
		///Sets the height of the object.
		///</summary>
		public string height {
			get;
			set;
		}
		///<summary>
		///Sets the horizontal margin for the object.
		///</summary>
		public int hspace {
			get;
			set;
		}
		///<summary>
		///Sets a URL to be loaded by the object.
		///</summary>
		public string src {
			get;
			set;
		}
		///<summary>
		///Sets the URL, often with a bookmark extension (#name), to use as a client-side image map.
		///</summary>
		public string usemap {
			get;
			set;
		}
		///<summary>
		///Sets the vertical margin for the object.
		///</summary>
		public int vspace {
			get;
			set;
		}
		///<summary>
		///Sets the width of the object.
		///</summary>
		public string width {
			get;
			set;
		}
		///<summary>
		///Retrieves whether the object is fully loaded.
		///</summary>
		public string complete {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was created.
		///</summary>
		public Date fileCreatedDate {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was last modified.
		///</summary>
		public Date fileModifiedDate {
			get;
			set;
		}
		///<summary>
		///Retrieves the file size.
		///</summary>
		public int fileSize {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was last updated.
		///</summary>
		public Date fileUpdatedDate {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a destination URL or an anchor point.
		///</summary>
		public string href {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the image is a server-side image map.
		///</summary>
		public string isMap {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a Uniform Resource Identifier (URI) to a long description of the object.
		///</summary>
		public string longDesc {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the number of times a sound or video clip will loop when activated.
		///</summary>
		public string loop {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a lower resolution image to display.
		///</summary>
		public string lowsrc {
			get;
			set;
		}
		///<summary>
		///Retrieves the file name specified in the href or src property of the object.
		///</summary>
		public string nameProp {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the protocol portion of a URL.
		///</summary>
		public string protocol {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves when a video clip file should begin playing.
		///</summary>
		public string start {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the URL of the virtual reality modeling language (VRML) world to be displayed in the window.
		///</summary>
		public string vrml {
			get;
			set;
		}
		///<summary>
		///Fires when the user aborts the download of an image.
		///</summary>
		public Action<HtmlDomEventArgs> onabort;
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
