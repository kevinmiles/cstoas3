namespace Javascript.Global {
	using System;

	///<summary>
	///Denotes a list box or drop-down list.
	///</summary>
	public class HtmlSelect : HtmlElement {
		///<summary>
		///Fires when the contents of the object or selection have changed.
		///</summary>
		/// <remarks>IE, Opera, and Konqueror have a serious bug in their handling of this event when the user uses the keyboard to change a select.</remarks>
		public Action<HtmlDomEventArgs> onchange;
		public HtmlNodeCollection<HtmlOption> options {
			get {
				return default(HtmlNodeCollection<HtmlOption>);
			}
		}
		///<summary>
		///Sets or retrieves the Boolean value indicating whether multiple items can be selected from a list.
		///</summary>
		public bool multiple {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the index of the selected option in a select object.
		///</summary>
		public int selectedIndex {
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
		///<summary>
		///Sets or retrieves the number of objects in a collection.
		///</summary>
		public int length {
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
		///Sets or retrieves the number of rows in the list box.
		///</summary>
		public string size {
			get;
			set;
		}
		///<summary>
		///Retrieves the type of select control based on the value of the MULTIPLE attribute.
		///</summary>
		public string type {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the value which is returned to the server when the form control is submitted.
		///</summary>
		public string value {
			get;
			set;
		}
		///<summary>
		///Adds an option element to the options collection of a select object.
		///</summary>
		///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		///<param name="existingOption">An existing HTMLOptionElement within the collection used as a reference point for inserting the new element; the new element being inserted before the referenced element in the collection.  If this parameter is null, the new element is appended to the end of the collection.</param>
		public void add(HtmlOption newOption, HtmlOption existingOption) {
		}
		///<summary>
		///Adds an option element to the options collection of a select object.
		///</summary>
		///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		public void add(HtmlOption newOption) {
		}
		///<summary>
		///Adds an option element to the options collection of a select object.
		///</summary>
		///<param name="newOption">An HTMLOptionElement to add to the options collection.</param>
		///<param name="index">Integer that specifies the index position in the collection where the element is placed. If no value is given, the method places the element at the end of the collection.</param>
		public void add(HtmlOption newOption, int index) {
		}
		///<summary>
		///Removes an element from the collection.
		///</summary>
		///<param name="iIndex">Integer that specifies the zero-based index of the element to remove from the collection.</param>
		public void remove(int iIndex) {
		}
	}
}
