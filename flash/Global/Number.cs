namespace flash.Global {
	/// <summary>
	/// A data type representing an IEEE-754 double-precision floating-point number. You can manipulate primitive numeric values by using the methods and properties associated with the Number class. This class is identical to the JavaScript Number class.
	/// </summary>
	public sealed class Number {
		/// <summary>
		/// The largest representable number (double-precision IEEE-754).
		/// </summary>
		public const Number MAX_VALUE = null;

		/// <summary>
		/// The smallest representable non-negative, non-zero, number (double-precision IEEE-754).
		/// </summary>
		public const Number MIN_VALUE = null;

		/// <summary>
		/// The IEEE-754 value representing Not a Number (NaN).
		/// </summary>
		public const Number NaN = null;

		/// <summary>
		/// Specifies the IEEE-754 value representing negative infinity.
		/// </summary>
		public const Number NEGATIVE_INFINITY = null;

		/// <summary>
		/// Specifies the IEEE-754 value representing positive infinity.
		/// </summary>
		public const Number POSITIVE_INFINITY = null;


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

		//public static implicit operator Number(double pStr) {
		//    return null;
		//}

		//public static implicit operator double (Number pStr) {
		//    return null;
		//}

		//public static implicit operator Number(float pStr) {
		//    return null;
		//}

		//public static implicit operator float (Number pStr) {
		//    return null;
		//}

		//public static explicit operator uint(Number val) {
		//    return new uint();
		//}

		//public static explicit operator int(Number val) {
		//    return new int();
		//}
	}
}
