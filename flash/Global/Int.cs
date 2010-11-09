namespace flash.Global {
	using flash;

	[As3Name("int","")]
	public struct Int {
		public const int MAX_VALUE = 0;
		public const int MIN_VALUE = 0;

		/// <summary>
		/// Returns a string representation of the number in exponential notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the fractionDigits argument is outside the range 0 to 20.</exception>
		public string toExponential(uint pFractionDigits) {
			return null;
		}


		/// <summary>
		/// Returns a string representation of the number in fixed-point notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the fractionDigits argument is outside the range 0 to 20.</exception>
		public string toFixed(uint pFractionDigits) {
			return null;
		}


		/// <summary>
		/// Returns a string representation of the number either in exponential notation or in fixed-point notation
		/// </summary>
		/// <param name="pPrecision">An integer between 1 and 21, inclusive, that represents the desired number of digits to represent in the resulting string.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the precision argument is outside the range 1 to 21.</exception>
		public string toPrecision(uint pPrecision) {
			return null;
		}

		public static implicit operator int(Int pStr) {
			return 0;
		}

		public static implicit operator Int(int pStr) {
			return new Int();
		}

		public static explicit operator Int(Number pStr) {
			return new Int();
		}

		public static implicit operator Number(Int pStr) {
			return new Number();
		}
	}
}