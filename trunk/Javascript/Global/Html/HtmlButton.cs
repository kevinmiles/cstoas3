namespace Javascript.Global {
	public partial class HtmlButton : HtmlElement {
		///<summary>
		///Sets the access key for the object.
		///</summary>
		public new string accessKey {
			get;
			set;
		}
		/// <summary>
		/// Gets the classification and default behavior of the button.
		/// Possible values:
		///	button	Default. Creates a Command button.
		/// reset	Creates a Reset button. If the button is in a form, it resets the fields in the form to their initial values.
		/// submit	Creates a Submit button. If the button is in a form, it submits the form.
		/// </summary>
		public string type {
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
		///Sets or retrieves a field of a given data source, as specified by the dataSrc property, to bind to the specified object.
		///</summary>
		public string dataFld {
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
		///Retrieves a reference to the form that the object is embedded in.
		///</summary>
		public string form {
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
		///Sets or retrieves the default or selected value of the control.
		///</summary>
		public string value {
			get;
			set;
		}
	}
}
