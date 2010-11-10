namespace System {
	using flash;
	using flash.Global;

	[As3Name("parse", "parseFloat", "flash.utils.parseFloat")]
	[As3Name("isFinite", "flash.utils.isFinite")]
	[As3Name("isNaN", "flash.utils.isNaN")]
	public struct Double {
		/// <summary>
		/// Converts a string to a floating-point number. The function reads, or parses , and returns the numbers in a string until it reaches a character that is not a part of the initial number. If the string does not begin with a number that can be parsed, parseFloat() returns NaN . White space preceding valid integers is ignored, as are trailing non-numeric characters.
		/// </summary>
		/// <param name="str">The string to read and convert to a floating-point number. </param>
		/// <returns>A number or NaN (not a number).</returns>
		public static Double parse(string str) {
			return new Double();
		}

		/// <summary>
		/// Returns <c>true</c> if the value is a finite number, or <c>false</c> if the value is Infinity or -Infinity . The presence of Infinity or -Infinity indicates a mathematical error condition such as division by 0. 
		/// </summary>
		/// <param name="number">A number to evaluate as finite or infinite</param>
		/// <returns>Returns <c>true</c> if it is a finite number or <c>false</c> if it is infinity or negative infinity  </returns>
		public static bool isFinite(Double number) {
			return false;
		}

		/// <summary>
		/// Returns <c>true</c> if the value is NaN (not a number). The isNaN() function is useful for checking whether a mathematical expression evaluates successfully to a number. The most common use of isNaN() is to check the value returned from the parseInt() and parseFloat() functions. The NaN value is a special member of the Number data type that represents a value that is "not a number." 
		/// </summary>
		/// <param name="number">A numeric value or mathematical expression to evaluate.</param>
		/// <returns>Returns <c>true</c> if the value is NaN (not a number) and <c>false</c> otherwise. </returns>
		public static bool isNaN(Double number) {
			return false;
		}

		/// <summary>
		/// The largest representable number (double-precision IEEE-754).
		/// </summary>
		public const Double MAX_VALUE = 0;

		/// <summary>
		/// The smallest representable non-negative, non-zero, number (double-precision IEEE-754).
		/// </summary>
		public const Double MIN_VALUE = 0;

		/// <summary>
		/// The IEEE-754 value representing Not a Number (NaN).
		/// </summary>
		public const Double NaN = 0;

		/// <summary>
		/// Specifies the IEEE-754 value representing negative infinity.
		/// </summary>
		public const Double NEGATIVE_INFINITY = 0;

		/// <summary>
		/// Specifies the IEEE-754 value representing positive infinity.
		/// </summary>
		public const Double POSITIVE_INFINITY = 0;


		/// <summary>
		/// Returns a string representation of the number in exponential notation. The string contains one digit before the decimal point and up to 20 digits after the decimal point, as specified by the <paramref name="fractionDigits"/> parameter. 
		/// </summary>
		/// <param name="fractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the <paramref name="fractionDigits"/> argument is outside the range 0 to 20. </exception>
		public string toExponential(uint fractionDigits) {
			return "";
		}

		/// <summary>
		/// Returns a string representation of the number in fixed-point notation. Fixed-point notation means that the string will contain a specific number of digits after the decimal point, as specified in the <paramref name="fractionDigits"/> parameter. The valid range for the <paramref name="fractionDigits"/> parameter is from 0 to 20. Specifying a value outside this range throws an exception. 
		/// </summary>
		/// <param name="fractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the <paramref name="fractionDigits"/> argument is outside the range 0 to 20. </exception>
		public string toFixed(uint fractionDigits) {
			return "";
		}

		/// <summary>
		/// Returns a string representation of the number either in exponential notation or in fixed-point notation. The string will contain the number of digits specified in the precision parameter. 
		/// </summary>
		/// <param name="precision">An integer between 1 and 21, inclusive, that represents the desired number of digits to represent in the resulting string.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the <paramref name="precision"/> argument is outside the range 0 to 21. </exception>
		public string toPrecision(uint precision) {
			return "";
		}

		//public static implicit operator double(Number pStr) {
		//    return 0;
		//}

		//public static implicit operator Number(double pStr) {
		//    return null;
		//}
	}
}
