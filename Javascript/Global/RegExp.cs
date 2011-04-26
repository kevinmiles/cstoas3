namespace Javascript.Global {
	public class RegExp {
		/// <summary>
		/// Lets you construct a regular expression from two strings.
		/// </summary>
		/// <param name="re">The pattern of the regular expression (also known as the constructor string ). This is the main part of the regular expression (the part that goes within the "/" characters). </param>
		/// <param name="flags">The modifiers of the regular expression (g, i, s, m, x)</param>
		public RegExp(string re, string flags) {
			return;
		}

		/// <summary>
		/// Lets you construct a regular expression from two strings.
		/// </summary>
		/// <param name="re">The pattern of the regular expression (/pattern/[flags]).</param>
		/// <remarks>regex must be expressed as a verbatim string (@"/pattern/gi")</remarks>
		public RegExp(string re) {
			return;
		}

		/// <summary>
		/// Performs a search for the regular expression on the given string <paramref name="str"/>.
		/// </summary>
		/// <param name="str">The string to search.</param>
		/// <returns>If there is no match, null ; otherwise, a <see cref="RegExpMatch"/></returns>
		public RegExpMatch exec(string str) {
			return null;
		}

		/// <summary>
		/// Tests for the match of the regular expression in the given string <paramref name="str"/> . 
		/// </summary>
		/// <param name="str">The string to test.</param>
		/// <returns>If there is a match, true ; otherwise, false.</returns>
		public bool test(string str) {
			return false;
		}
	}

	///<summary>
	///</summary>
	[AsObjectAttribute]
	public sealed class RegExpMatch {
		///<summary>
		///Returns the JsString against which a regular expression search was performed. Read-only.
		///</summary>
		public readonly string input;
		///<summary>
		///Returns the character position where the first successful match begins in a searched JsString. Read-only.
		///</summary>
		public readonly int index;
		///<summary>
		///Returns the character position where the next match begins in a searched JsString.
		///</summary>
		public readonly int lastIndex;
		///<summary>
		///Returns the last matched characters from any regular expression search. Read-only.
		///</summary>
		public readonly string lastMatch;
		///<summary>
		///Returns the last parenthesized submatch from any regular expression search, if any. Read-only.
		///</summary>
		public readonly string lastParen;
		///<summary>
		///Returns the characters from the beginning of a searched JsString up to the position before the beginning of the last match. Read-only.
		///</summary>
		public readonly string leftContext;
		///<summary>
		///Returns the characters from the position following the last match to the end of the searched JsString. Read-only.
		///</summary>
		public readonly string rightContext;

		/// <summary>
		/// element 0 contains the complete matching substring, and other elements of the array (1 through n ) contain substrings that match parenthetical groups in the regular expression
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public string this[int i] {
			get {
				return "";
			}
		}
	}
}