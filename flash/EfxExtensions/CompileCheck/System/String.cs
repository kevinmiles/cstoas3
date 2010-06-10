namespace System {

	public sealed class String {
		public static implicit operator String(flash.Global.String pStr) {
			return new String();
		}

		public static implicit operator flash.Global.String(String pStr) {
			return new flash.Global.String("");
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
		public static string Concat(Object arg0) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(Object[] args) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(string[] values) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(Object arg0, Object arg1) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(string str0, string str1) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(Object arg0, Object arg1, Object arg2) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(string str0, string str1, string str2) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(Object arg0, Object arg1, Object arg2, Object arg3) {
			return "";
		}

		/// <summary>
		/// Just for compatibility with C# compiler. DO NOT USE
		/// </summary>
		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public static string Concat(string str0, string str1, string str2, string str3) {
			return "";
		}
	}
}