namespace flash.Global {
	using System;

	public sealed class String {
		/// <param name="match">The matching portion of the string.</param>
		/// <param name="args">Any captured parenthetical group matches are provided as the next arguments. The number of arguments passed this way will vary depending on the number of parenthetical matches. You can determine the number of parenthetical matches by checking arguments.length - 3 within the function code. Then, the index position in the string where the match begins. And last, The complete string.</param>
		/// <returns></returns>
		public delegate string StringReplaceDelegate(string match, params object[] args);

		/// <summary>
		/// Creates a new String object initialized to the specified string.
		/// </summary>
		public String(string val) {
			return;
		}

		/// <summary>
		/// [read-only] An integer specifying the number of characters in the specified String object.
		/// </summary>
		public int length {
			get;
			private set;
		}

		/// <summary>
		/// Returns the character in the position specified by the index parameter.
		/// </summary>
		public string charAt(double index) {
			return default(string);
		}

		/// <summary>
		/// Returns the character in the position specified by the index parameter.
		/// </summary>
		public string charAt() {
			return default(string);
		}

		/// <summary>
		/// Returns the numeric Unicode character code of the character at the specified index.
		/// </summary>
		public double charCodeAt(double index) {
			return default(double);
		}

		/// <summary>
		/// Returns the numeric Unicode character code of the character at the specified index.
		/// </summary>
		public double charCodeAt() {
			return default(double);
		}

		/// <summary>
		/// Appends the supplied arguments to the end of the String object, converting them to strings if necessary, and returns the resulting string.
		/// </summary>
		public string concat(params object[] args) {
			return default(string);
		}

		/// <summary>
		/// Appends the supplied arguments to the end of the String object, converting them to strings if necessary, and returns the resulting string.
		/// </summary>
		public string concat() {
			return default(string);
		}

		/// <summary>
		/// [static] Returns a string comprising the characters represented by the Unicode character codes in the parameters.
		/// </summary>
		public static string fromCharCode(params uint[] args) {
			return default(string);
		}

		/// <summary>
		/// [static] Returns a string comprising the characters represented by the Unicode character codes in the parameters.
		/// </summary>
		public static string fromCharCode() {
			return default(string);
		}

		/// <summary>
		/// Searches the string and returns the position of the first occurrence of val found at or after startIndex within the calling string.
		/// </summary>
		public int indexOf(string val, double startIndex) {
			return default(int);
		}

		/// <summary>
		/// Searches the string and returns the position of the first occurrence of val found at or after startIndex within the calling string.
		/// </summary>
		public int indexOf(string val) {
			return default(int);
		}

		/// <summary>
		/// Searches the string from right to left and returns the index of the last occurrence of val found before startIndex.
		/// </summary>
		public int lastIndexOf(string val, double startIndex) {
			return default(int);
		}

		/// <summary>
		/// Searches the string from right to left and returns the index of the last occurrence of val found before startIndex.
		/// </summary>
		public int lastIndexOf(string val) {
			return default(int);
		}

		/// <summary>
		/// Compares the sort order of two or more strings and returns the result of the comparison as an integer.
		/// </summary>
		public int localeCompare(string other, object values) {
			return default(int);
		}

		/// <summary>
		/// Compares the sort order of two or more strings and returns the result of the comparison as an integer.
		/// </summary>
		public int localeCompare(string other) {
			return default(int);
		}

		/// <summary>
		/// Matches the specifed pattern against the string.
		/// </summary>
		public string[] match(string pattern) {
			return new string[1];
		}

		public string[] match(RegExp pattern) {
			return new string[1];
		}

		/// <summary>
		/// Matches the specifed pattern against the string and returns a new string in which the first match of pattern is replaced with the content specified by repl.
		/// </summary>
		public string replace(string pattern, string repl) {
			return default(string);
		}

		public string replace(RegExp pattern, string repl) {
			return default(string);
		}

		public string replace(string pattern, StringReplaceDelegate repl) {
			return default(string);
		}

		/// <summary>
		/// Searches for the specifed pattern and returns the index of the first matching substring.
		/// </summary>
		public int search(string pattern) {
			return default(int);
		}

		public int search(RegExp pattern) {
			return default(int);
		}

		/// <summary>
		/// Returns a string that includes the startIndex character and all characters up to, but not including, the endIndex character.
		/// </summary>
		public string slice(double startIndex, double endIndex) {
			return default(string);
		}

		/// <summary>
		/// Returns a string that includes the startIndex character and all characters up to, but not including, the endIndex character.
		/// </summary>
		public string slice(double startIndex) {
			return default(string);
		}

		/// <summary>
		/// Returns a string that includes the startIndex character and all characters up to, but not including, the endIndex character.
		/// </summary>
		public string slice() {
			return default(string);
		}

		/// <summary>
		/// Splits a String object into an array of substrings by dividing it wherever the specified delimiter parameter occurs.
		/// </summary>
		public string[] split(string delimiter, double limit) {
			return default(string[]);
		}

		public string[] split(RegExp delimiter, double limit) {
			return default(string[]);
		}

		/// <summary>
		/// Splits a String object into an array of substrings by dividing it wherever the specified delimiter parameter occurs.
		/// </summary>
		public string[] split(string delimiter) {
			return default(string[]);
		}

		public string[] split(RegExp delimiter) {
			return default(string[]);
		}

		/// <summary>
		/// Returns a substring consisting of the characters that start at the specified startIndex and with a length specified by len.
		/// </summary>
		public string substr(double startIndex, double len) {
			return default(string);
		}

		/// <summary>
		/// Returns a substring consisting of the characters that start at the specified startIndex and with a length specified by len.
		/// </summary>
		public string substr(double startIndex) {
			return default(string);
		}

		/// <summary>
		/// Returns a substring consisting of the characters that start at the specified startIndex and with a length specified by len.
		/// </summary>
		public string substr() {
			return default(string);
		}

		/// <summary>
		/// Returns a string consisting of the character specified by startIndex and all characters up to endIndex - 1.
		/// </summary>
		public string substring(double startIndex, double endIndex) {
			return default(string);
		}

		/// <summary>
		/// Returns a string consisting of the character specified by startIndex and all characters up to endIndex - 1.
		/// </summary>
		public string substring(double startIndex) {
			return default(string);
		}

		/// <summary>
		/// Returns a string consisting of the character specified by startIndex and all characters up to endIndex - 1.
		/// </summary>
		public string substring() {
			return default(string);
		}

		/// <summary>
		/// Returns a copy of this string, with all uppercase characters converted to lowercase.
		/// </summary>
		public string toLocaleLowerCase() {
			return default(string);
		}

		/// <summary>
		/// Returns a copy of this string, with all lowercase characters converted to uppercase.
		/// </summary>
		public string toLocaleUpperCase() {
			return default(string);
		}

		/// <summary>
		/// Returns a copy of this string, with all uppercase characters converted to lowercase.
		/// </summary>
		public string toLowerCase() {
			return default(string);
		}

		/// <summary>
		/// Returns a copy of this string, with all lowercase characters converted to uppercase.
		/// </summary>
		public string toUpperCase() {
			return default(string);
		}

		/// <summary>
		/// Returns the primitive value of a String instance.
		/// </summary>
		public new string valueOf() {
			return default(string);
		}
	}
}