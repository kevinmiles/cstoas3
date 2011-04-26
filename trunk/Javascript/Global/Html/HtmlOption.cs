namespace Javascript.Global {
	///<summary>
	///Denotes one choice in a SELECT element.
	///</summary>
	public class HtmlOption : HtmlElement {
		///<summary>
		///Sets or retrieves the value which is returned to the server when the form control is submitted.
		///</summary>
		public string value {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the text string specified by the option tag.
		///</summary>
		public string text {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the rendering format for the data supplied to the object.
		/// Possible values:
		///	text						Default. Data is rendered as text.
		/// html						Data is rendered as HTML.
		/// localized-text	Microsoft Internet Explorer 5.01 and later versions. Data is rendered using the locale settings of the client machine.
		/// </summary>
		public string dataFormatAs {
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
		///Sets or retrieves the status of an option.
		///</summary>
		public bool defaultSelected {
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
		///Sets or retrieves the ordinal position of an option in a list box.
		///</summary>
		public string label {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves whether the option in the list box is the default item.
		///</summary>
		public bool selected {
			get;
			set;
		}
	}
}
