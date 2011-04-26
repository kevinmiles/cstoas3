namespace Javascript.Global {
	///<summary>
	///Specifies a container that renders HTML.
	///</summary>
	public class HtmlDiv : HtmlElement {
		protected HtmlDiv() {
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
		///Sets or retrieves whether the browser automatically performs wordwrap.
		///</summary>
		public bool noWrap {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the alignment of the object relative to the display or table.
		/// Possible Values:
		/// center	Aligns to the center.
		/// justify	Aligns to the left and right edge.
		///	left		Default. Aligns to the left edge.
		///	right		Aligns to the right edge.
		/// </summary>
		public string align {
			get;
			set;
		}
	}
}
