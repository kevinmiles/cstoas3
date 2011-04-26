namespace Javascript.Global {
	///<summary>
	///Represents text in an HTML element.
	///</summary>
	public class HtmlTextRange {
		///<summary>
		///Searches for text in the document and positions the start and end points of the range to encompass the search string.
		///</summary>
		///<param name="text">String that specifies the text to find.</param>
		///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		public bool findText(string text) {
			return false;
		}
		///<summary>
		///Searches for text in the document and positions the start and end points of the range to encompass the search string.
		///</summary>
		///<param name="text">String that specifies the text to find.</param>
		///<param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
		///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		public bool findText(string text, int searchScope) {
			return false;
		}
		///<summary>
		///Searches for text in the document and positions the start and end points of the range to encompass the search string.
		///</summary>
		///<param name="text">String that specifies the text to find.</param>
		///<param name="searchScope">Integer that specifies the number of characters to search from the starting point of the range. A positive integer indicates a forward search; a negative integer indicates a backward search. </param>
		///<param name="flags">Integer that specifies one or more of the following flags to indicate the type of search: 0 Default. Match partial words.
		///1 Match backwards.
		///2 Match whole words only.
		///4 Match case.
		///131072 Match bytes.
		///536870912 Match diacritical marks.
		///1073741824 Match Kashida character.
		///2147483648 Match AlefHamza character.
		///</param>
		///<returns>Boolean that returns one of the following values: true The search text was found. false The search text was not found. </returns>
		public bool findText(string text, int searchScope, int flags) {
			return false;
		}
		///<summary>
		///Retrieves the parent element for the given text range.
		///</summary>
		///<returns>Returns the parent element object if successful, or null otherwise.</returns>
		public HtmlElement parentElement() {
			return null;
		}
		///<summary>
		///Retrieves the distance between the left edge of the rectangle that bounds the TextRange object and the left side of the object that contains the TextRange.
		///</summary>
		public int boundingLeft {
			get;
			private set;
		}
		///<summary>
		///Retrieves the width of the rectangle that bounds the TextRange object.
		///</summary>
		public int boundingWidth {
			get;
			private set;
		}
		///<summary>
		///Retrieves the distance between the top edge of the rectangle that bounds the TextRange object and the top side of the object that contains the TextRange.
		///</summary>
		public int boundingTop {
			get;
			private set;
		}
		///<summary>
		///Retrieves the height of the rectangle that bounds the TextRange object.
		///</summary>
		public int boundingHeight {
			get;
			private set;
		}
		///<summary>
		///Retrieves the calculated top position of the object relative to the layout or coordinate parent, as specified by the offsetParent property.
		///</summary>
		public int offsetTop {
			get;
			private set;
		}
		///<summary>
		///Retrieves the calculated left position of the object relative to the layout or coordinate parent, as specified by the offsetParent property.
		///</summary>
		public int offsetLeft {
			get;
			private set;
		}
		///<summary>
		///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window.
		///</summary>
		public int scrollTop {
			get;
			private set;
		}
		///<summary>
		///Makes the selection equal to the current object.
		///</summary>
		public void select() {
		}
		///<summary>
		///Moves the text range so that the start and end positions of the range encompass the text in the given element.
		///</summary>
		///<param name="p"></param>
		public void moveToElementText(HtmlElement p) {
		}
		/// <summary>
		/// Causes the object to scroll into view, aligning it either at the top or bottom of the window.
		/// </summary>
		/// <param name="bAlignToTop">Boolean that specifies one of the following values:
		///														true - Default. Scrolls the object so that top of the object is visible at the top of the window.
		///														false - Scrolls the object so that the bottom of the object is visible at the bottom of the window</param>
		public void scrollIntoView(bool bAlignToTop) {
		}
		///<summary>
		///Sets or retrieves the text contained within the range.
		///</summary>
		public string text {
			get;
			set;
		}
		///<summary>
		///Retrieves the HTML source as a valid HTML fragment.
		///</summary>
		public string htmlText {
			get;
			private set;
		}
		///<summary>
		///Collapses the given text range and moves the empty range by the given number of units
		///</summary>
		///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit.</param>
		///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		public int move(string sUnit, int iCount) {
			return 0;
		}
		///<summary>
		///Returns a duplicate of the TextRange.
		///</summary>
		///<returns>Returns a TextRange object.</returns>
		public HtmlTextRange duplicate() {
			return null;
		}
		///<summary>
		///Sets the endpoint of one range based on the endpoint of another range.
		///</summary>
		///<param name="sType">Required. String that specifies the endpoint to transfer using one of the following values: startToEnd, startToStart, endToStart, endToEnd</param>
		///<param name="oTextRange">Required. TextRange object from which the source endpoint is to be taken.</param>
		public void setEndPoint(string sType, HtmlTextRange oTextRange) {
		}
		///<summary>
		///Pastes HTML text into the given text range, replacing any previous text and HTML elements in the range.
		///</summary>
		///<param name="sHTMLText">Required. String that specifies the HTML text to paste. The string can contain text and any combination of the HTML tags described in HTML Elements.</param>
		public void pasteHTML(string sHTMLText) {
		}
		///<summary>
		///Moves the start and end positions of the text range to the given point.
		///</summary>
		///<param name="x">Required. Integer that specifies the horizontal offset relative to the upper-left corner of the window, in pixels.</param>
		///<param name="y">Required. Integer that specifies the vertical offset relative to the upper-left corner of the window, in pixels.</param>
		public void moveToPoint(int x, int y) {
		}
		///<summary>
		///Returns a value indicating whether the specified range is equal to the current range.
		///</summary>
		///<param name="oCompareRange">Required. TextRange object to compare with the current TextRange object. </param>
		///<returns>Boolean that returns true if oCompareRange is equal to the parent object, otherwise false.</returns>
		public bool isEqual(HtmlTextRange oCompareRange) {
			return false;
		}
		///<summary>
		///Changes the start position of the range.
		///</summary>
		///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
		///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		///<returns></returns>
		public int moveEnd(string sUnit, int iCount) {
			return 0;
		}
		///<summary>
		///Changes the end position of the range.
		///</summary>
		///<param name="sUnit">Required. String that specifies the units to move, using one of the following values: character, word, sentence, textedit</param>
		///<param name="iCount">Optional. Integer that specifies the number of units to move. This can be positive or negative. The default is 1.</param>
		///<returns></returns>
		public int moveStart(string sUnit, int iCount) {
			return 0;
		}
		/// <summary>
		/// Moves the insertion point to the beginning or end of the current range.
		/// </summary>
		/// <param name="bStart">Optional. Boolean that specifies one of the following values:
		/// <list type="table">
		/// <item>
		///		<term>true</term>
		///		<description>Default. Moves the insertion point to the beginning of the text range.</description>
		/// </item>
		/// <item>
		///		<term>false</term>
		///		<description>Moves the insertion point to the end of the text range.</description>
		/// </item>
		/// </list>
		/// </param>
		public void collapse(bool bStart) {
		}
		///<summary>
		///Moves the insertion point to the beginning or end of the current range.
		///</summary>
		public void collapse() {
		}
		///<summary>
		///Returns a value indicating whether one range is contained within another.
		///</summary>
		///<param name="range2">TextRange object that might be contained</param>
		///<returns>Boolean that returns one of the following possible values.
		///true oRange is contained within or is equal to the TextRange object on which the method is called.
		///false oRange is not contained within the TextRange object on which the method is called.
		///</returns>
		public bool inRange(HtmlTextRange range2) {
			return false;
		}
		///<summary>
		///Compares an end point of a TextRange object with an end point of another range.
		///</summary>
		///<param name="type">String that specifies one of the following values:
		///StartToEnd Compare the start of the TextRange object with the end of the oRange parameter.
		///StartToStart Compare the start of the TextRange object with the start of the oRange parameter.
		///EndToStart Compare the end of the TextRange object with the start of the oRange parameter.
		///EndToEnd Compare the end of the TextRange object with the end of the oRange parameter
		///</param>
		///<param name="range">TextRange object that specifies the range to compare with the object</param>
		///<returns>Returns one of the following possible values:
		///-1 The end point of the object is further to the left than the end point of oRange.
		///0 The end point of the object is at the same location as the end point of oRange.
		///1 The end point of the object is further to the right than the end point of oRange.</returns>
		public int compareEndPoints(string type, HtmlTextRange range) {
			return 0;
		}
		///<summary>
		///Retrieves a bookmark (opaque string) that can be used with moveToBookmark to return to the same range.
		///</summary>
		///<returns>String. Returns the bookmark if successfully retrieved, or null otherwise. </returns>
		public string getBookmark() {
			return null;
		}
		///<summary>
		///Moves to a bookmark.
		///</summary>
		///<param name="bookmark">String that specifies the bookmark to move to. </param>
		///<returns>Boolean that returns one of the following possible values:
		///true Successfully moved to the bookmark.
		///false Move to the bookmark failed. </returns>
		public bool moveToBookmark(string bookmark) {
			return false;
		}
	}
}
