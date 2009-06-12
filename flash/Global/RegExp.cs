namespace flash.Global {
	public class RegExp {
		/// <summary>
		/// Specifies whether the dot character (.) in a regular expression pattern matches new-line characters.
		/// </summary>
		public readonly bool dotall;

		/// <summary>
		/// Specifies whether to use extended mode for the regular expression.
		/// </summary>
		public readonly bool extended;

		/// <summary>
		/// Specifies whether to use global matching for the regular expression.
		/// </summary>
		public readonly bool global;

		/// <summary>
		/// Specifies whether the regular expression ignores case sensitivity.
		/// </summary>
		public readonly bool ignoreCase;

		/// <summary>
		/// Specifies whether the m (multiline) flag is set.
		/// </summary>
		public readonly bool multiline;
		
		/// <summary>
		/// Specifies the index position in the string at which to start the next search.
		/// </summary>
		public readonly float lastIndex;

		/// <summary>
		/// Specifies the pattern portion of the regular expression.
		/// </summary>
		public readonly string source;


		/// <summary>
		/// Lets you construct a regular expression from two strings.
		/// </summary>
		/// <param name="re">The pattern of the regular expression (also known as the constructor string ). This is the main part of the regular expression (the part that goes within the "/" characters). </param>
		/// <param name="flags">The modifiers of the regular expression (g, i, s, m, x)</param>
		public RegExp(string re, string flags) {}

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

	[As3AsObject]
	public sealed class RegExpMatch {
		/// <summary>
		/// The character position of the matched substring within the string
		/// </summary>
		public int index;

		/// <summary>
		/// The string
		/// </summary>
		public string input;

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