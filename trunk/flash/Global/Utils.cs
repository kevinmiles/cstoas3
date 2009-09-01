namespace flash.Global {
	public static class Utils {
		/// <summary>
		/// Decodes an encoded URI into a string. Returns a string in which all characters previously encoded by the encodeURI function are restored to their unencoded representation.
		/// </summary>
		/// <param name="uri">A string encoded with the <see cref="encodeURI"/> function.</param>
		/// <returns>A string in which all characters previously escaped by the <see cref="encodeURI"/> function are restored to their unescaped representation.</returns>
		[As3Name("decodeURI")]
		[As3Namespace("flash.utils.decodeURI")]
		public static string decodeURI(string uri) {
			return null;
		}

		/// <summary>
		/// Decodes an encoded URI component into a string. Returns a string in which all characters previously escaped by the encodeURIComponent function are restored to their uncoded representation.
		/// </summary>
		/// <param name="uri">A string encoded with the encodeURIComponent function.</param>
		/// <returns>A string in which all characters previously escaped by the encodeURIComponent function are restored to their unescaped representation.</returns>
		[As3Name("decodeURIComponent")]
		[As3Namespace("flash.utils.decodeURIComponent")]
		public static string decodeURIComponent(string uri) {
			return null;
		}

		/// <summary>
		/// Encodes a string into a valid URI (Uniform Resource Identifier). Converts a complete URI into a string in which all characters are encoded as UTF-8 escape sequences unless a character belongs to a small group of basic characters. 
		/// </summary>
		/// <param name="uri">A string representing a complete URI.</param>
		/// <returns>A string with certain characters encoded as UTF-8 escape sequences.</returns>
		[As3Name("encodeURI")]
		[As3Namespace("flash.utils.encodeURI")]
		public static string encodeURI(string uri) {
			return null;
		}

		/// <summary>
		/// Encodes a string into a valid URI component. Converts a substring of a URI into a string in which all characters are encoded as UTF-8 escape sequences unless a character belongs to a very small group of basic characters. 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		[As3Name("encodeURIComponent")]
		[As3Namespace("flash.utils.encodeURIComponent")]
		public static string encodeURIComponent(string uri) {
			return null;
		}

		/// <summary>
		/// Converts the parameter to a string and encodes it in a URL-encoded format, where most non-alphanumeric characters are replaced with % hexadecimal sequences. When used in a URL-encoded string, the percentage symbol ( % ) is used to introduce escape characters, and is not equivalent to the modulo operator ( % ).
		/// </summary>
		/// <param name="uri">The expression to convert into a string and encode in a URL-encoded format.</param>
		/// <returns>A URL-encoded string.</returns>
		[As3Name("escape")]
		[As3Namespace("flash.utils.escape")]
		public static string escape(string uri) {
			return null;
		}

		/// <summary>
		/// Returns <c>true</c> if the value is a finite number, or <c>false</c> if the value is Infinity or -Infinity . The presence of Infinity or -Infinity indicates a mathematical error condition such as division by 0. 
		/// </summary>
		/// <param name="number">A number to evaluate as finite or infinite</param>
		/// <returns>Returns <c>true</c> if it is a finite number or <c>false</c> if it is infinity or negative infinity  </returns>
		[As3Name("isFinite")]
		[As3Namespace("flash.utils.isFinite")]
		public static bool isFinite(Number number) {
			return false;
		}

		/// <summary>
		/// Returns <c>true</c> if the value is NaN (not a number). The isNaN() function is useful for checking whether a mathematical expression evaluates successfully to a number. The most common use of isNaN() is to check the value returned from the parseInt() and parseFloat() functions. The NaN value is a special member of the Number data type that represents a value that is "not a number." 
		/// </summary>
		/// <param name="number">A numeric value or mathematical expression to evaluate.</param>
		/// <returns>Returns <c>true</c> if the value is NaN (not a number) and <c>false</c> otherwise. </returns>
		[As3Name("isNaN")]
		[As3Namespace("flash.utils.isNaN")]
		public static bool isNaN(Number number) {
			return false;
		}

		/// <summary>
		/// Determines whether the specified string is a valid name for an XML element or attribute.
		/// </summary>
		/// <param name="str">A string to evaluate.</param>
		/// <returns>Returns <c>true</c> if the <paramref name="str"/> argument is a valid XML name; <c>false</c> otherwise. </returns>
		[As3Name("isXMLName")]
		[As3Namespace("flash.utils.isXMLName")]
		public static bool isXMLName(string str) {
			return false;
		}

		/// <summary>
		/// Converts a string to a floating-point number. The function reads, or parses , and returns the numbers in a string until it reaches a character that is not a part of the initial number. If the string does not begin with a number that can be parsed, parseFloat() returns NaN . White space preceding valid integers is ignored, as are trailing non-numeric characters.
		/// </summary>
		/// <param name="str">The string to read and convert to a floating-point number. </param>
		/// <returns>A number or NaN (not a number).</returns>
		[As3Name("parseFloat")]
		[As3Namespace("flash.utils.parseFloat")]
		public static Number parseFloat(string str) {
			return 0;
		}

		/// <summary>
		/// Converts a string to an integer. If the specified string in the parameters cannot be converted to a number, the function returns NaN . Strings beginning with 0x are interpreted as hexadecimal numbers. Unlike in previous versions of ActionScript, integers beginning with 0 are not interpreted as octal numbers. You must specify a radix of 8 for octal numbers. White space and zeroes preceding valid integers are ignored, as are trailing non-numeric characters.
		/// </summary>
		/// <param name="str">A string to convert to an integer.</param>
		/// <param name="radix">An integer representing the radix (base) of the number to parse. Legal values are from 2 to 36.</param>
		/// <returns>A number or NaN (not a number).</returns>
		[As3Name("parseInt")]
		[As3Namespace("flash.utils.parseInt")]
		public static Number parseInt(string str, uint radix) {
			return 0;
		}

		[As3Name("parseInt")]
		[As3Namespace("flash.utils.parseInt")]
		public static Number parseInt(string str) {
			return 0;
		}

		/// <summary>
		/// Evaluates the parameter stir as a string, decodes the string from URL-encoded format (converting all hexadecimal sequences to ASCII characters), and returns the string. 
		/// </summary>
		/// <param name="str">A string with hexadecimal sequences to escape.</param>
		/// <returns>A string decoded from a URL-encoded parameter.</returns>
		[As3Name("unescape")]
		[As3Namespace("flash.utils.unescape")]
		public static string unescape(string str) {
			return "";
		}
	}
}
