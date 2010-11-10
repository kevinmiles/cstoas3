namespace flash.Global {
	[As3Name("trace", "")]
	[As3Name("getTimer", "flash.utils.getTimer")]
	[As3Name(@"unescape", @"flash.utils.unescape")]
	[As3Name("decodeURI", "flash.utils.decodeURI")]
	[As3Name("decodeURIComponent", "flash.utils.decodeURIComponent")]
	[As3Name("encodeURI", "flash.utils.encodeURI")]
	[As3Name("encodeURIComponent", "flash.utils.encodeURIComponent")]
	[As3Name("escape", "flash.utils.escape")]
	public static class Utils {
		/// <summary>
		/// Decodes an encoded URI into a string. Returns a string in which all characters previously encoded by the encodeURI function are restored to their unencoded representation.
		/// </summary>
		/// <param name="uri">A string encoded with the <see cref="encodeURI"/> function.</param>
		/// <returns>A string in which all characters previously escaped by the <see cref="encodeURI"/> function are restored to their unescaped representation.</returns>
		
		public static string decodeURI(string uri) {
			return null;
		}

		/// <summary>
		/// Decodes an encoded URI component into a string. Returns a string in which all characters previously escaped by the encodeURIComponent function are restored to their uncoded representation.
		/// </summary>
		/// <param name="uri">A string encoded with the encodeURIComponent function.</param>
		/// <returns>A string in which all characters previously escaped by the encodeURIComponent function are restored to their unescaped representation.</returns>
		public static string decodeURIComponent(string uri) {
			return null;
		}

		/// <summary>
		/// Encodes a string into a valid URI (Uniform Resource Identifier). Converts a complete URI into a string in which all characters are encoded as UTF-8 escape sequences unless a character belongs to a small group of basic characters. 
		/// </summary>
		/// <param name="uri">A string representing a complete URI.</param>
		/// <returns>A string with certain characters encoded as UTF-8 escape sequences.</returns>
		public static string encodeURI(string uri) {
			return null;
		}

		/// <summary>
		/// Encodes a string into a valid URI component. Converts a substring of a URI into a string in which all characters are encoded as UTF-8 escape sequences unless a character belongs to a very small group of basic characters. 
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		public static string encodeURIComponent(string uri) {
			return null;
		}

		/// <summary>
		/// Converts the parameter to a string and encodes it in a URL-encoded format, where most non-alphanumeric characters are replaced with % hexadecimal sequences. When used in a URL-encoded string, the percentage symbol ( % ) is used to introduce escape characters, and is not equivalent to the modulo operator ( % ).
		/// </summary>
		/// <param name="uri">The expression to convert into a string and encode in a URL-encoded format.</param>
		/// <returns>A URL-encoded string.</returns>
		public static string escape(string uri) {
			return null;
		}

		

		/// <summary>
		/// Evaluates the parameter stir as a string, decodes the string from URL-encoded format (converting all hexadecimal sequences to ASCII characters), and returns the string. 
		/// </summary>
		/// <param name="str">A string with hexadecimal sequences to escape.</param>
		/// <returns>A string decoded from a URL-encoded parameter.</returns>
		public static string unescape(string str) {
			return "";
		}

		/// <summary>
		/// Returns the number of milliseconds that have elapsed since the movie started playing.
		/// </summary>
		/// <returns>The number of milliseconds that have elapsed since the movie started playing.</returns>
		public static int getTimer() {
			return 0;
		}

		/// <summary>
		/// Returns the number of milliseconds that have elapsed since the movie started playing.
		/// </summary>
		/// <returns>The number of milliseconds that have elapsed since the movie started playing.</returns>
		public static void trace(object args) {

		}
	}
}
