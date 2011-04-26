namespace Javascript.Global {
	[Name("undefined", "")]
	[Name("typeof", "")]
	[Name("eval", "")]
	public sealed class Context {

		public static JsArguments arguments;

		///<summary>
		/// indicates that a variable has not been assigned a value.
		///</summary>
		public static object undefined {
			get;
			set;
		}

		public static string @typeof(object obj) {
			return default(string);
		}

		/// <summary>
		/// Evaluates JScript code and executes it.
		/// </summary>
		/// <param name="code">A string value that contains valid JScript code. This string is parsed by the JScript parser and executed.</param>
		/// <returns></returns>
		public static object eval(string code) {
			return default(object);
		}

		///<summary>
		/// Returns a Boolean value that indicates whether a value is the reserved value NaN (not a number).
		///</summary>
		///<param name="numValue">A value to be tested against NaN.</param>
		///<returns>True if the value converted to the Number type is the NaN, otherwise false.</returns>
		public static bool isNaN(object numValue) {
			return default(bool);
		}

		///<summary>
		///Returns a Boolean value that indicates if a supplied number is finite.
		///</summary>
		///<param name="number">A numeric value.</param>
		///<returns>True if number is any value other than NaN, negative infinity,
		///or positive infinity. In those three cases, it returns false.</returns>
		public static bool isFinite(double number) {
			return default(bool);
		}


	}
}
