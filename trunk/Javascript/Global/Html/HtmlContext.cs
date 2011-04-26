namespace Javascript.Global {
	[Name("alert", "")]
	[Name("confirm", "")]
	[Name("escape", "")]
	[Name("decodeURIComponent", "")]
	[Name("encodeURIComponent", "")]
	[Name("encodeURI", "")]
	[Name("decodeURI", "")]
	[Name("unescape", "")]
	[Name("window", "")]
	[Name("document", "")]
	public static class HtmlContext {
		///<summary>
		///Displays a dialog box containing an application-defined message.
		///</summary>
		///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
		///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
		public static void alert(object message) {
		}
		/// <summary>
		/// Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the confirmation dialog box. If no value is provided, the dialog box does not contain a message.</param>
		/// <returns>Boolean. Returns one of the following possible values:
		///	<list type="table">
		///	<item>
		///		<term>true</term>
		///		<description>The user clicked the OK button.</description>
		///	</item>
		///	<item>
		///		<term>false</term>
		///		<description>The user clicked Cancel button.</description>
		/// </item>
		/// </list>
		/// </returns>
		public static bool confirm(string message) {
			return true;
		}
		///<summary>
		///Encodes String objects so they can be read on all computers.
		///</summary>
		///<param name="s">String object or literal to be encoded.</param>
		///<returns>A string value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
		public static string escape(string s) {
			return null;
		}
		///<summary>
		///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI).
		///</summary>
		///<param name="encodedURIString">A value representing an encoded URI component.</param>
		///<returns>The required encodedURIString argument is a value representing an encoded
		///URI component.A URIComponent is part of a complete URI. If the encodedURIString is
		///not valid, a URIError occurs.</returns>
		public static string decodeURIComponent(string encodedURIString) {
			return null;
		}
		///<summary>
		///Encodes a text string as a valid component of a Uniform Resource Identifier (URI).
		///</summary>
		///<param name="encodedURIString">A value representing an encoded URI component.</param>
		///<returns>A an encoded URI. If you pass the result to decodeURIComponent,
		///the original string is returned. Because the encodeURIComponent method encodes all
		///characters, be careful if the string represents a path such
		///as /folder1/folder2/default.html. The slash characters will be encoded and will
		///not be valid if sent as a request to a web server. Use the encodeURI method if the
		///string contains more than a single URI component.</returns>
		public static string encodeURIComponent(string encodedURIString) {
			return null;
		}
		///<summary>
		///Encodes a text string as a valid Uniform Resource Identifier (URI)
		///</summary>
		///<param name="URIString">A value representing an encoded URI.</param>
		///<returns>n encoded URI. If you pass the result to decodeURI, the original string is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
		public static string encodeURI(string URIString) {
			return null;
		}
		///<summary>
		///Returns the unencoded version of an encoded Uniform Resource Identifier (URI).
		///</summary>
		///<param name="URIString"></param>
		///<returns></returns>
		public static string decodeURI(string URIString) {
			return null;
		}
		///<summary>
		///Decodes String objects encoded with the escape method.
		///</summary>
		///<param name="charString">String object or literal to be decoded.</param>
		///<returns>A string value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
		public static string unescape(string charString) {
			return null;
		}
		///<summary>
		///Retrieves the HTML window
		///</summary>
		public static HtmlWindow window {
			get;
			set;
		}
		///<summary>
		///Retrieves the HTML document
		///</summary>
		public static HtmlDocument document {
			get;
			set;
		}
	}
}
