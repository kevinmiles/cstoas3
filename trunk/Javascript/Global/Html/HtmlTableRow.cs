namespace Javascript.Global {
	///<summary>
	///Specifies a row in a table.
	///</summary>
	public class HtmlTableRow : HtmlElement {
		protected HtmlTableRow() {
		}
		public HtmlNodeCollection<HtmlTableCell> cells {
			get;
			set;
		}
		///<summary>
		///Creates a new cell in the table row (tr), and adds the cell to the cells collection.
		///</summary>
		///<param name="index">Integer that specifies where to insert the cell in the tr. The default value is -1, which appends the new cell to the end of the cells collection.</param>
		///<returns>Returns the td element object if successful, or null otherwise.</returns>
		public HtmlTableCell insertCell(int index) {
			return null;
		}
		/////<summary>
		/////Creates a new cell in the table row (tr), and adds the cell to the cells collection.
		/////</summary>
		/////<returns>Returns the td element object if successful, or null otherwise.</returns>
		//[SupportedBrowsers(BrowserTypes.IE5_5 | BrowserTypes.IE6 | BrowserTypes.IE7 | BrowserTypes.IE8AsIE7 | BrowserTypes.IE8 | BrowserTypes.IE9 | BrowserTypes.Saf3Win | BrowserTypes.Saf3_1Win | BrowserTypes.Saf4Win | BrowserTypes.Chrome2 | BrowserTypes.Chrome3 | BrowserTypes.Chrome4 | BrowserTypes.Chrome5 | BrowserTypes.Opera9 | BrowserTypes.Opera10 | BrowserTypes.Konqueror3_57)]
		//public HtmlTableCell insertCell() { return null; }
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
		///<summary>
		///Removes the specified cell (td) from the table row, as well as from the cells collection.
		///</summary>
		///<param name="iIndex">Integer that specifies the zero-based position of the cell to remove from the table row. If no value is provided, the last cell in the cells collection is deleted.</param>
		public void deleteCell(int iIndex) {
		}
		///<summary>
		///Removes the last cell (td) from the table row, as well as from the cells collection.
		///</summary>
		public void deleteCell() {
		}
		///<summary>
		///Retrieves the position of the object in the rows collection for the table.
		///</summary>
		/// <remarks>Opera keeps to the source code order (where the &lt;tfoot&gt; precedes the &lt;tbody&gt;.)</remarks>
		public int rowIndex {
			get;
			set;
		}
		///<summary>
		///Retrieves the position of the object in the tBody, tHead, tFoot, or rows collection.
		///</summary>
		public int sectionRowIndex {
			get;
			set;
		}
	}
}
