namespace Javascript.Global {
	///<summary>
	///Specifies a cell in a table.
	///</summary>
	public class HtmlTableCell : HtmlElement {
		protected HtmlTableCell() {
		}
		///<summary>
		///Sets or retrieves abbreviated text for the object.
		///</summary>
		public string abbr {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a comma-delimited list of conceptual categories associated with the object.
		///</summary>
		public string axis {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		///</summary>
		public string borderColorDark {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		///</summary>
		public string borderColorLight {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that you can use to implement your own ch functionality for the object.
		///</summary>
		public string ch {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that you can use to implement your own chOff functionality for the object.
		///</summary>
		public string chOff {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the number columns in the table that the object should span.
		///</summary>
		public int colSpan {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a list of header cells that provide information for the object.
		///</summary>
		public string headers {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves how many rows in a table the cell should span.
		///</summary>
		public int rowSpan {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the group of cells in a table to which the object's information applies.
		///Possible Values:
		///row				The current cell provides header information for its row.
		///col				The current cell provides header information for its column.
		///rowgroup	The header cell provides header information for its row.
		///colgroup	The header cell provides header information for its column.
		///</summary>
		public string scope {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the width of the object.
		///Possible Values:
		///Integer			that specifies the width of the object in pixels.
		///percentage	String that specifies an integer value followed by a %. The value is a percentage of the width of the parent object.
		///</summary>
		public string width {
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
		public string align;
		///<summary>
		///Sets whether the browser automatically performs wordwrap.
		///</summary>
		public bool noWrap {
			get;
			set;
		}
		///<summary>
		///Retrieves the position of the object in the cells collection of a row.
		///</summary>
		public int cellIndex {
			get;
			set;
		}
		///<summary>
		///Deprecated. Sets or retrieves the background color behind the object.
		///</summary>
		public string bgColor {
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
		///String that specifies or receives one of the following values.
		///</summary>
		///<remarks>
		///<list type="table">
		///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
		///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
		///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
		///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
		///</list>
		///</remarks>
		public string vAlign {
			get;
			set;
		}
	}
}
