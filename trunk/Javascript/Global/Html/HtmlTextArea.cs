namespace Javascript.Global {
	using System;

	public class HtmlTextArea : HtmlElement {
		///<summary>
		///Sets or retrieves the number of horizontal rows contained in the object.
		///</summary>
		public int rows {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the width of the object.
		///</summary>
		public int cols {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves how to handle wordwrapping in the object.
		/// Possible values:
		///	soft	Default. Text is displayed with wordwrapping and submitted without carriage returns and line feeds.
		/// hard	Text is displayed with wordwrapping and submitted with soft returns and line feeds.
		/// off		Wordwrapping is disabled. The lines appear exactly as the user types them.
		/// </summary>
		public string wrap {
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
		///Sets or retrieves a comma-separated list of content types.
		///</summary>
		public string accept {
			get;
			set;
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
		///Sets or retrieves the state of the check box or radio button.
		///</summary>
		public bool @checked {
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
		///Sets or retrieves the initial contents of the object.
		///</summary>
		public string defaultValue {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the state of the check box or radio button.
		///</summary>
		public string defaultChecked {
			get;
			set;
		}
		///<summary>
		///Retrieves a reference to the form that the object is embedded in.
		///</summary>
		public string form {
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
		///Sets or retrieves the number of times a sound or video clip will loop when activated.
		///</summary>
		public string loop {
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
		///Sets or retrieves the vertical margin for the object.
		///</summary>
		public string vspace {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the URL, often with a bookmark extension (#name), to use as a client-side image map.
		///</summary>
		public string useMap {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the value indicated whether the content of the object is read-only.
		///</summary>
		public string readOnly {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the size of the control.
		///</summary>
		public string size {
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
		///Sets or retrieves when a video clip file should begin playing.
		///</summary>
		public string start {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the calculated width of the object.
		///</summary>
		public string width {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the value indicating whether the control is selected.
		/// Possible values:
		///	false	Default. Control is not selected.
		/// true	Control is selected.
		/// null	Control is not initialized.
		/// </summary>
		public bool status {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the name of the object.
		///</summary>
		public string name {
			get;
			set;
		}
		///<summary>
		///Retrieves the file name of the input object after the text is set by user input.
		///</summary>
		public string value {
			get;
			set;
		}
		///<summary>
		///Retrieves or initially sets the type of input control represented by the object.
		///</summary>
		public string type {
			get;
			set;
		}
		///<summary>
		///Highlights the input area of a form element.
		///</summary>
		public void select() {
		}
		///<summary>
		///Creates a TextRange object for the element.
		///Use a text range to examine and modify the text within an object.
		///</summary>
		///<returns>Returns a TextRange object if successful, or null otherwise.</returns>
		public HtmlTextRange createTextRange() {
			return null;
		}
		///<summary>
		///Sets or retrieves the maximum number of characters that the user can enter in a text control.
		///</summary>
		public int maxLength {
			get;
			set;
		}
		///<summary>
		///Fires when the contents of the object or selection have changed.
		///</summary>
		/// <remarks>IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.</remarks>
		public Action<HtmlDomEventArgs> onchange;
		///<summary>
		///Fires when the current selection changes.
		///</summary>
		public Action<HtmlDomEventArgs> onselect;
	}
}
