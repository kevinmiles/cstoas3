namespace Javascript.Global {
	using System;

	///<summary>
	///Creates inline floating frames.
	///</summary>
	public class HtmlIFrame : HtmlElement {
		protected HtmlIFrame() {
		}

		public string readyState {
			get;
			private set;
		}
		/// <summary>
		/// Sets or retrieves whether to display a border for the frame.
		/// Possible values:
		///	1		Default. Inset border is drawn.
		/// 0		No border is drawn.
		/// no		No border is drawn.
		/// yes		Inset border is drawn.
		/// </summary>
		public string frameBorder {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a URL to be loaded by the object.
		///</summary>
		public string src {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the object can be transparent.
		///</summary>
		public bool allowTransparency {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the space between the frames, including the 3-D border.
		///</summary>
		public string border {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the top and bottom margin heights before displaying the text in a frame.
		///</summary>
		public int marginHeight {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the left and right margin widths before displaying the text in a frame.
		///</summary>
		public int marginWidth {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the height of the object.
		///</summary>
		public string height {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the width of the object.
		///</summary>
		public string width {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the vertical margin for the object.
		///</summary>
		public int vspace {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the frame can be scrolled.
		///</summary>
		public string scrolling {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates the table alignment.
		///</summary>
		public string align {
			get;
			set;
		}
		///<summary>
		///Retrieves the window object of the specified frame or iframe.
		///</summary>
		public HtmlWindow contentWindow {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the amount of additional space between the frames.
		///</summary>
		public string frameSpacing {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the horizontal margin for the object.
		///</summary>
		public string hspace {
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
		///Sets or retrieves the frame name.
		///</summary>
		public string name {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the user can resize the frame.
		///</summary>
		public bool noResize {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		///</summary>
		public string dataFld {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the source of the data for data binding.
		///</summary>
		public string dataSrc {
			get;
			set;
		}
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
	}
}
