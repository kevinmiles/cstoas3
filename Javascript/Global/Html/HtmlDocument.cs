namespace Javascript.Global {
	using System;

	///<summary>
	///Represents an HTML document
	///</summary>
	public class HtmlDocument {
		///<summary>
		///Gets a collection of objects based on the value of the NAME or ID attribute.
		///</summary>
		///<param name="sNameValue"></param>
		///<returns></returns>
		/// <remarks>IE5-7 ignores the &lt;p&gt; and custom tags with name='test', but counts the &lt;div&gt; with id='test'
		/// IE8 and Konqueror ignore the custom tag.
		/// Opera counts the &lt;div&gt; with id='test'</remarks>
		public HtmlElementCollection getElementsByName(string sNameValue) {
			return null;
		}
		///<summary>
		///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		public void attachEvent(string eventName, Action<HtmlDomEventArgs> handler) {
		}
		///<summary>
		///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		public void detachEvent(string eventName, Action<HtmlDomEventArgs> handler) {
		}
		///<summary>
		///Retrieves a value that indicates the current state of the object.
		///uninitializedObject is not initialized with data.
		///loadingObject is loading its data.
		///loadedObject has finished loading its data.
		///interactiveUser can interact with the object even though it is not fully loaded.
		///completeObject is completely initialized.
		///</summary>
		public string readyState {
			get;
			private set;
		}
		///<summary>
		///Retrieves a collection of HTML Elements and TextNode objects that are descendants of the specified object.
		///</summary>
		public HtmlElementCollection all {
			get;
			set;
		}
		///<summary>
		///Gets the object that has the focus when the parent document has focus.
		///</summary>
		public HtmlElement activeElement {
			get;
			set;
		}
		///<summary>
		///Gets or sets the HtmlWindow object that contains this HtmlDocument
		///</summary>
		public HtmlWindow parentWindow {
			get;
			set;
		}
		///<summary>
		///Returns the root node for this HtmlDocument
		///</summary>
		public HtmlDocumentElement documentElement {
			get;
			set;
		}
		public void appendChild(HtmlElement child) {
		}
		///<summary>
		///Creates a new TextNode
		///</summary>
		///<param name="text"></param>
		///<returns></returns>
		public HtmlTextNode createTextNode(string text) {
			return null;
		}
		///<summary>
		///Creates a new HtmlElement
		///</summary>
		///<param name="name"></param>
		///<returns></returns>
		public HtmlElement createElement(string name) {
			return null;
		}
		///<summary>
		///Creates a new HtmlElement
		///</summary>
		///<param name="name"></param>
		///<returns></returns>
		public T createElement<T>(string name) {
			return default(T);
		}

		public T createElement<T>() {
			return default(T);
		}
		///<summary>
		///Retrieves a collection of objects based on the specified element name.
		///</summary>
		///<param name="sTagName">String that specifies the name of an element.</param>
		/// <remarks>The * argument, which ought to select all elements in the document, doesn't work in IE 5.5.
		/// Custom tags are not returned in Konqueror.</remarks>
		public HtmlElementCollection getElementsByTagName(string sTagName) {
			return null;
		}
		///<summary>
		///Creates a new Stylesheet node. IE Only.
		///</summary>
		public HtmlStyleElement createStyleSheet() {
			return null;
		}
		///<summary>
		///Creates a new Stylesheet node. IE Only.
		///</summary>
		public HtmlStyleElement createStyleSheet(string url) {
			return null;
		}
		///<summary>
		///Creates a new Stylesheet node
		///</summary>
		public HtmlStyleElement createStyleSheet(int index) {
			return null;
		}
		///<summary>
		///Creates a new Stylesheet node.
		///</summary>
		public HtmlStyleElement createStyleSheet(string url, int index) {
			return null;
		}
		///<summary>
		///Gets the HtmlSelection object of this HtmlDocument
		///</summary>
		public HtmlSelection selection {
			get;
			private set;
		}
		///<summary>
		///Gets the HtmlBody root element of this HtmlDocument
		///</summary>
		public HtmlBody body {
			get;
			set;
		}
		///<summary>
		///Gets the title of this HtmlDocument
		///</summary>
		public string title {
			get;
			set;
		}
		public void open() {
		}
		public void close() {
		}
		public void write(string p) {
		}
		///<summary>
		///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
		///</summary>
		///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>
		public HtmlElement getElementById(string sIDValue) {
			return null;
		}
		///<summary>
		///Returns a reference to the first object with the specified value of the ID or NAME attribute (in IE)
		///</summary>
		///<param name="sIDValue">A String that specifies the ID value. Case-insensitive.</param>
		public T getElementById<T>(string sIDValue) {
			return default(T);
		}
		///<summary>
		///Creates a new document.
		///</summary>
		///<returns>Returns the newly created document.</returns>
		public HtmlDocumentFragment createDocumentFragment() {
			return null;
		}
		///<summary>
		///Generates an event object to pass event context information when you use the fireEvent method.
		///</summary>
		///<returns>Returns an event object.</returns>
		public HtmlDomEventArgs createEventObject() {
			return null;
		}
		///<summary>
		///Generates an event object to pass event context information when you use the fireEvent method.
		///</summary>
		///<param name="existingEvent">A object that specifies an existing event object on which to base the new object. </param>
		///<returns>Returns an event object.</returns>
		public HtmlDomEventArgs createEventObject(HtmlDomEventArgs existingEvent) {
			return null;
		}
		///<summary>
		///Sets or gets the string value of a cookie.
		///</summary>
		public string cookie {
			get;
			set;
		}
		///<summary>
		///Gets a value that indicates whether standards-compliant mode is switched on for the object.
		///</summary>
		///<remarks>
		///Possible Values
		///BackCompat - Standards-compliant mode is not switched on.
		///CSS1Compat Standards-compliant mode is switched on.
		///IE 5.5 doesn't support this property, but it doesn't need to. It's permanently locked in Quirks Mode.
		///</remarks>
		public string compatMode {
			get;
			set;
		}
		///<summary>
		///Returns a reference to the default AbstractView for the document, or null if none available
		///</summary>
		public HtmlDocument defaultView {
			get;
			set;
		}
		///<summary>
		///Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document. IE only.
		///</summary>
		public HtmlNodeCollection<HtmlStyleElement> styleSheets {
			get;
			set;
		}

		public HtmlElementCollection getElementsByClassName(string sClassName) {
			return null;
		}

		public HtmlElementCollection querySelectorAll(string selector) {
			return null;
		}
		///<summary>
		///Returns the element for the specified x coordinate and the specified y coordinate.
		///</summary>
		///<param name="iX">A Integer that specifies the X-offset, in pixels.</param>
		///<param name="iY">A Integer that specifies the Y-offset, in pixels.</param>
		///<returns>Returns an element object.</returns>
		/// <remarks>IE and Firefox need clientX/Y, while Opera, Chrome and Safari need pageX/Y. Opera 9 reports a text node whenever possible, while this method should report the containing element node.</remarks>
		public HtmlElement elementFromPoint(int iX, int iY) {
			return null;
		}

		/// <summary>
		/// Html Version 5 only.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public new object this[string name] {
			get {
				return null;
			}
			set {
			}
		}

		///<summary>
		///Creates a new comment node, and returns it.
		///</summary>
		///<param name="data">a string containing the data to be added to the Comment.</param>
		public HtmlNode createComment(string data) {
			return null;
		}
	}
}
