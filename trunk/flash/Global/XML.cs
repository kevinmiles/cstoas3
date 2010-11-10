namespace flash.Global {
	using System;

	/// <summary>
	/// The XML class contains methods and properties for working with XML objects. The XML class (along with the XMLList, Namespace, and QName classes) implements the powerful XML-handling standards defined in ECMAScript for XML (E4X) specification (ECMA-357 edition 2).
	/// </summary>
	[As3Name("Namespace","namespace","")]
	[As3Name("isXMLName", "flash.utils.isXMLName")]
	public sealed class XML {
		/// <summary>
		/// Determines whether the specified string is a valid name for an XML element or attribute.
		/// </summary>
		/// <param name="str">A string to evaluate.</param>
		/// <returns>Returns <c>true</c> if the <paramref name="str"/> argument is a valid XML name; <c>false</c> otherwise. </returns>
		public static bool isXMLName(string str) {
			return false;
		}

		/// <summary>
		/// [static] Determines whether XML comments are ignored when XML objects parse the source XML data.
		/// </summary>
		public bool ignoreComments {
			get;
			set;
		}

		/// <summary>
		/// [static] Determines whether XML processing instructions are ignored when XML objects parse the source XML data.
		/// </summary>
		public bool ignoreProcessingInstructions {
			get;
			set;
		}

		/// <summary>
		/// [static] Determines whether white space characters at the beginning and end of text nodes are ignored during parsing.
		/// </summary>
		public bool ignoreWhitespace {
			get;
			set;
		}

		/// <summary>
		/// [static] Determines the amount of indentation applied by the toString() and toXMLString() methods when the XML.prettyPrinting property is set to true.
		/// </summary>
		public int prettyIndent {
			get;
			set;
		}

		/// <summary>
		/// [static] Determines whether the toString() and toXMLString() methods normalize white space characters between some tags.
		/// </summary>
		public bool prettyPrinting {
			get;
			set;
		}

		/// <summary>
		/// Adds a namespace to the set of in-scope namespaces for the XML object.
		/// </summary>
		public XML addNamespace(Namespace ns) {
			return default(XML);
		}

		public XML addNamespace(QName ns) {
			return default(XML);
		}

		public XML addNamespace(string ns) {
			return default(XML);
		}

		/// <summary>
		/// Appends the given child to the end of the XML object's properties.
		/// </summary>
		public XML appendChild(XML child) {
			return default(XML);
		}

		public XML appendChild(XMLList child) {
			return default(XML);
		}

		/// <summary>
		/// Returns the XML value of the attribute that has the name matching the attributeName parameter.
		/// </summary>
		public XMLList attribute(string attributeName) {
			return default(XMLList);
		}

		public XMLList attribute(QName attributeName) {
			return default(XMLList);
		}

		/// <summary>
		/// Returns a list of attribute values for the given XML object.
		/// </summary>
		public XMLList attributes() {
			return default(XMLList);
		}

		/// <summary>
		/// Lists the children of an XML object.
		/// </summary>
		public XMLList child(string propertyName) {
			return default(XMLList);
		}

		public XMLList child(int propertyIndex) {
			return default(XMLList);
		}

		/// <summary>
		/// Identifies the zero-indexed position of this XML object within the context of its parent.
		/// </summary>
		public int childIndex() {
			return default(int);
		}

		/// <summary>
		/// Lists the children of the XML object in the sequence in which they appear.
		/// </summary>
		public XMLList children() {
			return default(XMLList);
		}

		/// <summary>
		/// Lists the properties of the XML object that contain XML comments.
		/// </summary>
		public XMLList comments() {
			return default(XMLList);
		}

		/// <summary>
		/// Compares the XML object against the given value parameter.
		/// </summary>
		public bool contains(XML value) {
			return default(bool);
		}

		/// <summary>
		/// Returns a copy of the given XML object.
		/// </summary>
		public XML copy() {
			return default(XML);
		}

		/// <summary>
		/// [static] Returns an object with the following properties set to the default values: ignoreComments, ignoreProcessingInstructions, ignoreWhitespace, prettyIndent, and prettyPrinting.
		/// </summary>
		public static XMLSettings defaultSettings() {
			return null;
		}

		/// <summary>
		/// Returns all descendants (children, grandchildren, great-grandchildren, and so on) of the XML object that have the given name parameter.
		/// </summary>
		public XMLList descendants(string name) {
			return default(XMLList);
		}

		public XMLList descendants(QName name) {
			return default(XMLList);
		}

		/// <summary>
		/// Returns all descendants (children, grandchildren, great-grandchildren, and so on) of the XML object that have the given name parameter.
		/// </summary>
		public XMLList descendants() {
			return default(XMLList);
		}

		/// <summary>
		/// Lists the elements of an XML object.
		/// </summary>
		public XMLList elements(string name) {
			return default(XMLList);
		}

		public XMLList elements(QName name) {
			return default(XMLList);
		}

		/// <summary>
		/// Lists the elements of an XML object.
		/// </summary>
		public XMLList elements() {
			return default(XMLList);
		}

		/// <summary>
		/// Checks to see whether the XML object contains complex content.
		/// </summary>
		public bool hasComplexContent() {
			return default(bool);
		}

		/// <summary>
		/// Checks to see whether the object has the property specified by the p parameter.
		/// </summary>
		new public bool hasOwnProperty(string p) {
			return default(bool);
		}

		/// <summary>
		/// Checks to see whether the XML object contains simple content.
		/// </summary>
		public bool hasSimpleContent() {
			return default(bool);
		}

		/// <summary>
		/// Lists the namespaces for the XML object, based on the object's parent.
		/// </summary>
		public Array inScopeNamespaces() {
			return default(Array);
		}

		/// <summary>
		/// Inserts the given child2 parameter after the child1 parameter in this XML object and returns the resulting object.
		/// </summary>
		public object insertChildAfter(object child1, object child2) {
			return default(object);
		}

		/// <summary>
		/// Inserts the given child2 parameter before the child1 parameter in this XML object and returns the resulting object.
		/// </summary>
		public object insertChildBefore(object child1, object child2) {
			return default(object);
		}

		/// <summary>
		/// For XML objects, this method always returns the integer 1.
		/// </summary>
		public int length() {
			return default(int);
		}

		/// <summary>
		/// Gives the local name portion of the qualified name of the XML object.
		/// </summary>
		public string localName() {
			return "";
		}

		/// <summary>
		/// Gives the qualified name for the XML object.
		/// </summary>
		public QName name() {
			return null;
		}

		/// <summary>
		/// If no parameter is provided, gives the namespace associated with the qualified name of this XML object.
		/// </summary>
		
		public Namespace Namespace(string prefix) {
			return null;
		}

		/// <summary>
		/// If no parameter is provided, gives the namespace associated with the qualified name of this XML object.
		/// </summary>
		public Namespace Namespace() {
			return null;
		}

		/// <summary>
		/// Lists namespace declarations associated with the XML object in the context of its parent.
		/// </summary>
		public Namespace[] namespaceDeclarations() {
			return null;
		}

		/// <summary>
		/// Specifies the type of node: text, comment, processing-instruction, attribute, or element.
		/// </summary>
		public string nodeKind() {
			return default(string);
		}

		/// <summary>
		/// For the XML object and all descendant XML objects, merges adjacent text nodes and eliminates empty text nodes.
		/// </summary>
		public XML normalize() {
			return default(XML);
		}

		/// <summary>
		/// Returns the parent of the XML object.
		/// </summary>
		public XML parent() {
			return null;
		}

		/// <summary>
		/// Inserts a copy of the provided child object into the XML element before any existing XML properties for that element.
		/// </summary>
		public XML prependChild(object value) {
			return default(XML);
		}

		/// <summary>
		/// If a name parameter is provided, lists all the children of the XML object that contain processing instructions with that name.
		/// </summary>
		public XMLList processingInstructions(string name) {
			return default(XMLList);
		}

		/// <summary>
		/// If a name parameter is provided, lists all the children of the XML object that contain processing instructions with that name.
		/// </summary>
		public XMLList processingInstructions() {
			return default(XMLList);
		}

		/// <summary>
		/// Checks whether the property p is in the set of properties that can be iterated in a for..in statement applied to the XML object.
		/// </summary>
		new public bool propertyIsEnumerable(string p) {
			return default(bool);
		}

		/// <summary>
		/// Removes the given namespace for this object and all descendants.
		/// </summary>
		public XML removeNamespace(Namespace ns) {
			return default(XML);
		}

		/// <summary>
		/// Replaces the properties specified by the propertyName parameter with the given value parameter.
		/// </summary>
		public XML replace(object propertyName, XML value) {
			return default(XML);
		}

		/// <summary>
		/// Replaces the child properties of the XML object with the specified set of XML properties, provided in the value parameter.
		/// </summary>
		public XML setChildren(object value) {
			return default(XML);
		}

		/// <summary>
		/// Changes the local name of the XML object to the given name parameter.
		/// </summary>
		public void setLocalName(string name) {
			return;
		}

		/// <summary>
		/// Sets the name of the XML object to the given qualified name or attribute name.
		/// </summary>
		public void setName(string name) {
			return;
		}

		/// <summary>
		/// Sets the namespace associated with the XML object.
		/// </summary>
		public void setNamespace(Namespace ns) {
			return;
		}

		/// <summary>
		/// [static] Sets values for the following XML properties: ignoreComments, ignoreProcessingInstructions, ignoreWhitespace, prettyIndent, and prettyPrinting.
		/// </summary>
		public static void setSettings(XMLSettings settings) {
			return;
		}

		/// <summary>
		/// [static] Retrieves the following properties: ignoreComments, ignoreProcessingInstructions, ignoreWhitespace, prettyIndent, and prettyPrinting.
		/// </summary>
		public static XMLSettings settings() {
			return null;
		}

		/// <summary>
		/// Returns an XMLList object of all XML properties of the XML object that represent XML text nodes.
		/// </summary>
		public XMLList text() {
			return default(XMLList);
		}

		/// <summary>
		/// Returns a string representation of the XML object.
		/// </summary>
		public string toXMLString() {
			return default(string);
		}

		/// <summary>
		/// Returns the XML object.
		/// </summary>
		new public XML valueOf() {
			return default(XML);
		}

		/// <summary>
		/// Creates a new XML object.
		/// </summary>
		public XML(object value) {return;}
	}

	[As3AsObject]
	public sealed class XMLSettings {
		public bool ignoreComments;
		public bool ignoreProcessingInstructions;
		public bool ignoreWhitespace;
		public bool prettyIndent;
		public bool prettyPrinting;
	}
}