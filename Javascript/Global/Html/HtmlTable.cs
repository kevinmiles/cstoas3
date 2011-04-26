namespace Javascript.Global {
	///<summary>
	///Specifies that the contained content is organized into a table with rows and columns.
	///</summary>
	public class HtmlTable : HtmlElement {
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
		///<summary>
		///Sets or retrieves a description and/or structure of the object.
		///</summary>
		public string summary {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves which dividing lines (inner borders) are displayed.
		///Possible Values:
		///all			Borders are displayed on all rows and columns.
		///cols		Borders are displayed between all table columns.
		///groups	Horizontal borders are displayed between all tHead, tBody, and tFoot objects; vertical borders are displayed between all colGroup objects.
		///none		All interior table borders are removed.
		///rows		Horizontal borders are displayed between all table rows.
		///</summary>
		public string rules {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the height of the object.
		///Possible Values:
		///height			Integer that specifies the height of the object, in pixels.
		///percentage	Integer, followed by a percent sign (%). The value is a percentage of the height of the parent object.
		///</summary>
		public string height {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the way the border frame around the table is displayed.
		///</summary>
		///<remarks>Possible values: void, above, below, hsides, vsides, lhs, rhs, box, border</remarks>
		public string frame {
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
		/// <summary>
		///	Sets or retrieves the number of columns in the table.
		/// </summary>
		public int cols {
			get;
			set;
		}
		/// <summary>
		///	Sets or retrieves the amount of space between cells in a table.
		///	Possible Values:
		///	spacing			Integer that specifies the amount of space between cells, in pixels.
		///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
		/// </summary>
		public string cellSpacing {
			get;
			set;
		}
		/// <summary>
		///	Sets or retrieves the amount of space between the border of the cell and the content of the cell.
		///	Possible Values:
		///	Integer			that specifies the amount of space between the border and the content, in pixels.
		///	percentage	Integer, followed by a %. The value is a percentage of the available amount of space between the border and the content.
		/// </summary>
		/// <remarks>Safari 3.0 and Konqueror don't react to the setting of cellPadding, but there's a subtle difference between doing the cellPadding test and then the cellSpacing one, and doing the cellSpacing one immediately. The results might be interpreted as the cellPadding only taking effect after the cellSpacing has been set, but I'm not sure if this interpretation is correct.</remarks>
		public string cellPadding {
			get;
			set;
		}
		/// <summary>
		///	Retrieves the caption object of a table.
		/// </summary>
		public string caption {
			get;
			set;
		}
		/// <summary>
		///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		/// </summary>
		public string borderColorLight {
			get;
			set;
		}
		/// <summary>
		///	Sets or retrieves the color for one of the two colors used to draw the 3-D border of the object.
		/// </summary>
		public string borderColorDark {
			get;
			set;
		}
		/// <summary>
		///	Deprecated. Sets or retrieves the background color behind the object.
		/// </summary>
		public string bgColor {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates the table alignment.
		///Possible Values:
		///left		Aligns to the left edge of the available space.
		///center	Aligns to the center of the available space, which is not necessarily the same as the browser window.
		///right		Aligns to the right edge of the available space.
		///</summary>
		public string align {
			get;
			set;
		}
		public string border {
			get;
			set;
		}

		public HtmlNodeCollection<HtmlTableCell> cells {
			get;
			set;
		}

		public HtmlNodeCollection<HtmlTableBody> tBodies {
			get;
			set;
		}

		public HtmlNodeCollection<HtmlTableHead> tHeads {
			get;
			set;
		}
		///<summary>
		///Creates a new row (tr) in the table, and adds the row to the rows collection.
		///</summary>
		///<param name="iIndex">Integer that specifies where to insert the row in the rows collection. The default value is -1, which appends the new row to the end of the rows collection.</param>
		///<returns>Returns the tr element object if successful, or null otherwise.</returns>
		public HtmlTableRow insertRow(int iIndex) {
			return null;
		}
		public HtmlNodeCollection<HtmlTableRow> rows {
			get;
			set;
		}
		///<summary>
		///Creates an empty caption element in the table.
		///</summary>
		///<returns>Returns a caption object.</returns>
		public HtmlCaption createCaption() {
			return null;
		}
		///<summary>
		///Creates an empty tFoot element in the table.
		///</summary>
		///<returns>Returns the tFoot element object if successful, or null otherwise.</returns>
		///<remarks>If a tFoot already exists for the table, the createTFoot method returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
		public HtmlTableFoot createTFoot() {
			return null;
		}
		///<summary>
		///Creates an empty tHead element in the table.
		///</summary>
		///<returns>Returns the tHead element object if successful, or null otherwise.</returns>
		///<remarks>If a tHead already exists, createTHead returns the existing element. Otherwise, it returns a pointer to the element created.</remarks>
		public HtmlTableFoot createTHead() {
			return null;
		}
		///<summary>
		///Deletes the caption element and its contents from the table.
		///</summary>
		public void deleteCaption() {
		}
		///<summary>
		///Removes the specified row (tr) from the element and from the rows collection.
		///</summary>
		///<param name="iRowIndex">Integer that specifies the zero-based position in the rows collection of the row to remove.</param>
		public void deleteRow(int iRowIndex) {
		}
		///<summary>
		///Removes the last row (tr) from the element and from the rows collection.
		///</summary>
		public void deleteRow() {
		}
		///<summary>
		///Deletes the tFoot element and its contents from the table.
		///</summary>
		///<remarks>If only one tFoot element exists in the source, the deleteTFoot method deletes the table footer. If multiple tFoot elements have been defined, the next tFoot element in the source order is promoted as the table footer.</remarks>
		public void deleteTFoot() {
		}
		///<summary>
		///Deletes the tHead element and its contents from the table.
		///</summary>
		///<remarks>If only one tHead element exists in the source, the deleteTHead method deletes the table header. If multiple tHead elements have been defined, the next tHead element in the source order is promoted as the table header.</remarks>
		public void deleteTHead() {
		}
		///<summary>
		///Moves a table row to a new position. IE only.
		///</summary>
		///<param name="iSource">Integer that specifies the index in the rows collection of the table row that is moved.</param>
		///<param name="iTarget">Integer that specifies where the row is moved within the rows collection.</param>
		///<returns>Object. Returns a reference to the table row that is moved.</returns>
		public HtmlTableRow moveRow(int iSource, int iTarget) {
			return null;
		}
		///<summary>
		///Retrieves the tFoot object of the table.
		///</summary>
		public HtmlTableFoot tFoot {
			get;
			set;
		}
		///<summary>
		///Retrieves the tHead object of the table.
		///</summary>
		public HtmlTableHead tHead {
			get;
			set;
		}
	}
}
