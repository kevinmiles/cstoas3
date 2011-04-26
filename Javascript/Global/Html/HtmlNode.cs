namespace Javascript.Global {
	using System;

	[AsIntegerAttribute]
	public enum HtmlNodeType {
		Element = 1,
		Attribute = 2,
		Text = 3,
		CData = 4,
		EntityReference = 5,
		Entity = 6,
		ProcessingInstruction = 7,
		Comment = 8,
		HtmlDocument = 9,
		DocType = 10,
		DocumentFragment = 11,
		Notation = 12
	}

	[AsIntegerAttribute, Flags]
	public enum DocumentPosition {
		Disconnected = 1,
		Precedes = 2,
		Follows = 4,
		Contains = 8,
		IsContainedBy = 16
	}

	public abstract class HtmlNode {
		/// <summary>
		/// 	Returns the node type
		/// </summary>
		public HtmlNodeType nodeType;

		///<summary>
		///	Retrieves a reference to the previous child of the parent for the object.
		///</summary>
		public HtmlNode previousSibling {
			get;
			set;
		}

		///<summary>
		///	Retrieves a reference to the next child of the parent for the object.
		///</summary>
		public HtmlNode nextSibling {
			get;
			set;
		}

		///<summary>
		///	Retrieves the name of a particular type of node.
		///</summary>
		public string nodeName {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the value of a node.
		///</summary>
		public string nodeValue {
			get;
			set;
		}

		///<summary>
		///	Retrieves the parent object in the document hierarchy.
		///</summary>
		public HtmlElement parentNode {
			get;
			set;
		}

		///<summary>
		///	Retrieves the document object associated with the node.
		///</summary>
		public HtmlDocument ownerDocument {
			get;
			set;
		}

		///<summary>
		///	Replaces an existing child element with a new child element.
		///</summary>
		///<param name = "newNode"></param>
		///<param name = "existingChild"></param>
		///<returns>Returns a reference to the object that is replaced.</returns>
		public HtmlNode replaceChild(HtmlNode newNode, HtmlNode existingChild) {
			return null;
		}

		///<summary>
		///	Compares the position of the current node against another node in any other document.
		///</summary>
		///<param name = "otherNode ">the node that's being compared against.</param>
		public DocumentPosition compareDocumentPosition(HtmlNode otherNode) {
			return DocumentPosition.Precedes;
		}

		///<summary>
		///	Returns a value that indicates whether the object has children.
		///</summary>
		///<returns>Returns true if the object contains HTML Elements or TextNode objects, or false if the object does not contain HTML Elements or TextNodes.</returns>
		public bool hasChildNodes() {
			return true;
		}
	}
}