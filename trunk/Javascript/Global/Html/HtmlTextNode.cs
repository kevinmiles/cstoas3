namespace Javascript.Global {
	///<summary>
	///Represents a string of text as a node in the document hierarchy.
	///</summary>
	public class HtmlTextNode : HtmlNode {
		///<summary>
		///Retrieves a reference to the first child in the childNodes collection of the object
		///</summary>
		public string firstChild {
			get;
			set;
		}
		///<summary>
		///Retrieves a reference to the last child in the childNodes collection of an object.
		///</summary>
		public string lastChild {
			get;
			set;
		}
		///<summary>
		///Gets the number of characters in a TextNode object.
		///</summary>
		public int length {
			get;
			set;
		}
		///<summary>
		///Divides a text node at the specified index.
		///</summary>
		///<param name="index">A Integer that specifies the index of the string that indicates where the separation occurs. If a value is not provided, a new text node with no value is created.</param>
		///<returns>This function returns the node containing the text after the offset.
		///The text before the offset remains in the original text node.</returns>
		/// <remarks>IE handles the first splitText() fine, but after you’ve normalized the text IE doesn’t split it any more.</remarks>
		public HtmlTextNode splitText(int index) {
			return null;
		}
		///<summary>
		///Divides a text node at the specified index.
		///</summary>
		///<returns>This function returns the node containing the text after the offset.
		///The text before the offset remains in the original text node.</returns>
		public HtmlTextNode splitText() {
			return null;
		}
		///<summary>
		///Sets or gets the value of a TextNode object.
		///</summary>
		public string data {
			get;
			set;
		}
		protected HtmlTextNode() {
		}
		///<summary>
		///Adds a new character string to the end of the object.
		///</summary>
		///<param name="sString"></param>
		/// <remarks>IE8 appends the text, but doesn’t show it until you click the element.</remarks>
		public void appendData(string sString) {
		}
		///<summary>
		///Removes a specified range of characters from the object.
		///</summary>
		///<param name="nOffset">Integer that specifies the offset from which to start.</param>
		///<param name="nCount">Integer that specifies the number of characters to remove.</param>
		public void deleteData(int nOffset, int nCount) {
		}
		///<summary>
		///Inserts a new character string in the object at a specified offset.
		///</summary>
		///<param name="nOffset">Integer that specifies the offset from which to start.</param>
		///<param name="sString">String that specifies the new character string.</param>
		public void insertData(int nOffset, string sString) {
		}
		///<summary>
		///Replaces a specified range of characters in the object with a new character string.
		///</summary>
		///<param name="nOffset">Integer that specifies the offset from which to start.</param>
		///<param name="nCount">Integer that specifies the number of characters to replace.</param>
		///<param name="sString">String that specifies the new character string.</param>
		///<remarks>
		///f the sum of the nOffset and nCount parameters exceeds the number of characters in the object, then all the characters to the end of the data are replaced.
		///</remarks>
		public void replaceData(int nOffset, int nCount, string sString) {
		}
		///<summary>
		///Extracts a range of characters from the object.
		///</summary>
		///<param name="nOffset">Integer that specifies the offset from which to start.</param>
		///<param name="nCount">Integer that specifies the number of characters to extract.</param>
		public void substringData(int nOffset, int nCount) {
		}
		///<summary>
		///This read-only property is useful if you want to get the entire text at a certain point and don’t want to be bothered by borders between text nodes.
		///</summary>
		public string wholeText {
			get;
			set;
		}
	}
}
