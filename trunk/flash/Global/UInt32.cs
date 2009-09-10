namespace flash.Global {
	[As3Name("uint")]
	public class UInt32 {
		public Int32 MAX_VALUE = 1;
		public Int32 MIN_VALUE = 1;

		public static implicit operator UInt32(uint val) {
			return null;
		}

		public static explicit operator UInt32(int val) {
			return null;
		}

		/// <summary>
		/// Returns a string representation of the number in exponential notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the fractionDigits argument is outside the range 0 to 20.</exception>
		public string ToExponential(uint pFractionDigits) {
			return null;
		}


		/// <summary>
		/// Returns a string representation of the number in fixed-point notation
		/// </summary>
		/// <param name="pFractionDigits">An integer between 0 and 20, inclusive, that represents the desired number of decimal places.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the fractionDigits argument is outside the range 0 to 20.</exception>
		public string ToFixed(uint pFractionDigits) {
			return null;
		}


		/// <summary>
		/// Returns a string representation of the number either in exponential notation or in fixed-point notation
		/// </summary>
		/// <param name="pPrecision">An integer between 1 and 21, inclusive, that represents the desired number of digits to represent in the resulting string.</param>
		/// <returns></returns>
		/// <exception cref="RangeError">Throws an exception if the precision argument is outside the range 1 to 21.</exception>
		public string ToPrecision(uint pPrecision) {
			return null;
		}


		public static implicit operator Number(UInt32 val) {
			return null;
		}

		public static explicit operator UInt32(Number val) {
			return null;
		}

		public static explicit operator UInt32(Int32 val) {
			return null;
		}
	}
}