﻿namespace System {
	using Javascript;

	[Name("parse", "parseInt", "")]
	public struct Int32 {
		public const int MAX_VALUE = 0;
		public const int MIN_VALUE = 0;

		/// <summary>
		/// Converts a string to an integer. If the specified string in the parameters cannot be converted to a number, the function returns NaN . Strings beginning with 0x are interpreted as hexadecimal numbers. Unlike in previous versions of ActionScript, integers beginning with 0 are not interpreted as octal numbers. You must specify a radix of 8 for octal numbers. White space and zeroes preceding valid integers are ignored, as are trailing non-numeric characters.
		/// </summary>
		/// <param name="str">A string to convert to an integer.</param>
		/// <param name="radix">An integer representing the radix (base) of the number to parse. Legal values are from 2 to 36.</param>
		/// <returns>A number or NaN (not a number).</returns>
		public static int? parse(string str, uint radix) {
			return 0;
		}


		public static int? parse(string str) {
			return 0;
		}

		/// <summary>
		/// Returns a string representation of the number in exponential notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		public string toExponential(uint pFractionDigits) {
			return null;
		}


		/// <summary>
		/// Returns a string representation of the number in fixed-point notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		public string toFixed(uint pFractionDigits) {
			return null;
		}

		/// <summary>
		/// Returns a string representation of the number either in exponential notation or in fixed-point notation
		/// </summary>
		/// <param name="pPrecision">An integer between 1 and 21, inclusive, that represents the desired number of digits to represent in the resulting string.</param>
		/// <returns></returns>
		public string toPrecision(uint pPrecision) {
			return null;
		}

		public static implicit operator uint(int pStr) {
			return new uint();
		}

		public static implicit operator int(uint pStr) {
			return 0;
		}
	}
}