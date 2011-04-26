namespace Javascript.Global {
	public class HtmlDomImplementation {
		///<summary>
		///Creates a DOM document.
		///</summary>
		///<param name="namespaceURI">namespace URI of the document to be created (use null if none)</param>
		///<param name="qualifiedNameStr">qualified name (optional prefix and colon plus the local root element name) of the document to be created</param>
		///<param name="documentType">the DocumentType to be created.</param>
		public HtmlDocument createDocument(string namespaceURI, string qualifiedNameStr, object documentType) {
			return null;
		}
		///<summary>
		///Creates an HTMLDocument object with the minimal tree made of the following elements: HTML, HEAD, TITLE, and BODY.
		///</summary>
		///<remarks>Introduced in DOM Level 2</remarks>
		///<returns>A new HTMLDocument object.</returns>
		public HtmlDocument createHTMLDocument() {
			return null;
		}
		///<summary>
		///Returns a DocumentType object which can either be used with DOMImplementation.createDocument upon document creation or they can be put into the document via Node.insertBefore() or Node.replaceChild()
		///</summary>
		///<param name="qualifiedNameStr"></param>
		///<param name="publicId"></param>
		///<param name="systemId"></param>
		///<returns></returns>
		public object createDocumentType(string qualifiedNameStr, string publicId, string systemId) {
			return null;
		}

		public object getFeature(string feature, string version) {
			return null;
		}

		public bool hasFeature(string feature, string version) {
			return true;
		}
	}
}
