namespace System {
	using ComponentModel;
	using Javascript.Global;

	public sealed class String {
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
		/// Returns the numeric Unicode character code of the character at the specified index.
		/// </summary>
		public double charCodeAt(double index) {
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
		/// Splits a String object into an array of substrings by dividing it wherever the specified delimiter parameter occurs.
		/// </summary>
		public string[] split(string delimiter) {
			return default(string[]);
		}

		/// <summary>
		/// Splits a String object into an array of substrings by dividing it wherever the specified delimiter parameter occurs.
		/// </summary>
		public string[] split(char delimiter) {
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

		public static bool operator ==(string string1, string string2) {
			return true;
		}

		public static bool operator !=(string string1, string string2) {
			return false;
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(Object arg0) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(Object[] args) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(string[] values) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(Object arg0, Object arg1) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(string str0, string str1) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(Object arg0, Object arg1, Object arg2) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(string str0, string str1, string str2) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(Object arg0, Object arg1, Object arg2, Object arg3) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Concat(string str0, string str1, string str2, string str3) {
			return "";
		}
	}
}