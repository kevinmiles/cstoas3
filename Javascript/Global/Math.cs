namespace Javascript.Global {
	///<summary>
	/// A built-in object that has properties and methods for mathematical constants and functions.
	///</summary>
	public static class Math {
		/// <summary>
		/// Returns the mathematical constant e, the base of natural logarithms. The E property is approximately equal to 2.718.
		/// </summary>
		public static readonly double E = 2.71828182845905;

		/// <summary>
		/// Returns the natural logarithm of 10.
		/// </summary>
		public static readonly double LN10 = 2.302585092994046;

		/// <summary>
		/// Returns the natural logarithm of 2.
		/// </summary>
		public static readonly double LN2 = 0.6931471805599453;

		/// <summary>
		/// Returns the base-10 logarithm of e, Euler's number.
		/// </summary>
		public static readonly double LOG10E = 0.4342944819032518;

		/// <summary>
		/// Returns the base-2 logarithm of e, Euler's number.
		/// </summary>
		public static readonly double LOG2E = 1.442695040888963387;

		/// <summary>
		/// Returns the ratio of the circumference of a circle to its diameter, approximately 3.141592653589793.
		/// </summary>
		public static readonly double PI = 3.141592653589793;

		/// <summary>
		/// Returns the square root of 0.5, or one divided by the square root of 2.
		/// </summary>
		public static readonly double SQRT1_2 = 0.7071067811865476;

		/// <summary>
		/// Returns the square root of 2, with an approximate value of 1.4142135623730951.
		/// </summary>
		public static readonly double SQRT2 = 1.4142135623730951;

		///<summary>
		///Returns the absolute value of a number.
		///</summary>
		///<param name="val">A numeric expression for which the absolute value is needed</param>
		///<returns>The absolute value of the number argument</returns>
		public static double abs(double val) {
			return default(double);
		}

		///<summary>
		///Returns the arccosine of a number.
		///</summary>
		///<param name="val">A numeric expression for which the arccosine is needed.</param>
		///<returns>the arccosine of the number argument.</returns>
		public static double acos(double val) {
			return default(double);
		}

		///<summary>
		///Returns the arcsine of a number.
		///</summary>
		///<param name="val">A numeric expression for which the arcsine is needed.</param>
		///<returns>The arcsine of its numeric argument.</returns>
		public static double asin(double val) {
			return default(double);
		}

		///<summary>
		///Returns the arctangent of a number.
		///</summary>
		///<param name="val">A numeric expression for which the arctangent is needed.</param>
		///<returns>The return value is the arctangent of its numeric argument.</returns>
		public static double atan(double val) {
			return default(double);
		}

		///<summary>
		///Returns the angle (in radians) from the X axis to a point (y,x).
		///</summary>
		///<param name="y">A numeric expression representing the cartesian x-coordinate.</param>
		///<param name="x">A numeric expression representing the cartesian y-coordinate.</param>
		///<returns>The return value is between -pi and pi, representing the angle of the supplied (y,x) point.</returns>
		public static double atan2(double y, double x) {
			return default(double);
		}

		///<summary>
		///Returns the smallest integer greater than or equal to its numeric argument.
		///</summary>
		///<param name="val">A numeric expression.</param>
		///<returns>An integer value equal to the smallest integer greater than or equal to its numeric argument.</returns>
		public static double ceil(double val) {
			return default(double);
		}

		///<summary>
		///Returns the cosine of a number.
		///</summary>
		///<param name="angleRadians">A numeric expression for which the cosine is needed.</param>
		///<returns>The return value is the cosine of its numeric argument.</returns>
		public static double cos(double angleRadians) {
			return default(double);
		}

		///<summary>
		///Returns e (the base of natural logarithms) raised to a power.
		///</summary>
		///<param name="val">A numeric expression representing the power of e.</param>
		///<returns>The return value is a number. The constant e is Euler's number, approximately equal to 2.71828 and number is the supplied argument.</returns>
		public static double exp(double val) {
			return default(double);
		}

		///<summary>
		///Returns the greatest integer less than or equal to its numeric argument.
		///</summary>
		///<param name="val">A numeric expression.</param>
		///<returns>An integer value equal to the greatest integer less than or equal to its numeric argument.</returns>
		public static double floor(double val) {
			return default(double);
		}

		///<summary>
		///Returns the natural logarithm of a number.
		///</summary>
		///<param name="val">A numeric expression for which the natural logarithm is sought.</param>
		///<returns>The return value is the natural logarithm of number. The base is e.</returns>
		public static double log(double val) {
			return default(double);
		}

		///<summary>
		///Returns the greater of zero or more supplied numeric expressions.
		///</summary>
		///<param name="values">Numeric expressions to be evaluated</param>
		///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		public static double max(params double[] values) {
			return default(double);
		}

		///<summary>
		///Returns the greater of zero or more supplied numeric expressions.
		///</summary>
		///<param name="values">Numeric expressions to be evaluated</param>
		///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		public static double max(params int[] values) {
			return default(double);
		}

		///<summary>
		///Returns the greater of zero or more supplied numeric expressions.
		///</summary>
		///<param name="values">Numeric expressions to be evaluated</param>
		///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		public static double max(params float [] values) {
			return default(double);
		}

		///<summary>
		///Returns the greater of zero or more supplied numeric expressions.
		///</summary>
		///<param name="values">Numeric expressions to be evaluated</param>
		///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		public static double max(params uint[] values) {
			return default(double);
		}


		///<summary>
		///Returns the lesser of zero or more supplied numeric expressions.
		///</summary>
		///<param name="values">Numeric expressions to be evaluated</param>
		///<returns>If no arguments are provided, the return value is equal to NEGATIVE_INFINITY. If any argument is NaN, the return value is also NaN.</returns>
		public static double min(params double[] values) {
			return default(double);
		}


		///<summary>
		///Returns the value of a base expression taken to a specified power.
		///</summary>
		///<param name="base">The base value of the expression.</param>
		///<param name="exponent">The exponent value of the expression.</param>
		///<returns></returns>
		public static double pow(double @base, double exponent) {
			return default(double);
		}

		///<summary>
		///Returns a pseudorandom number between 0 and 1.
		///</summary>
		///<returns>The pseudorandom number generated is from 0 (inclusive) to 1 (exclusive), that is, the returned number can be zero, but it will always be less than one.</returns>
		public static double random() {
			return default(double);
		}

		///<summary>
		///Returns a supplied numeric expression rounded to the nearest integer.
		///</summary>
		/// <param name="val">The value to be rounded to the nearest integer.</param>
		///<returns>For positive numbers, if the decimal portion of number is 0.5 or greater,
		///the return value is equal to the smallest integer greater than number. If the
		///decimal portion is less than 0.5, the return value is the largest integer less than
		///or equal to number. For negative numbers, if the decimal portion is exactly -0.5,
		///the return value is the smallest integer that is greater than the number.</returns>
		public static double round(double val) {
			return default(double);
		}

		///<summary>
		///Returns the sine of a number.
		///</summary>
		///<param name="angleRadians">A numeric expression for which the sine is needed</param>
		///<returns>The sine of the numeric argument</returns>
		public static double sin(double angleRadians) {
			return default(double);
		}

		///<summary>
		///Returns the square root of a number.
		///</summary>
		///<param name="val">A numeric expression.</param>
		///<returns>If number is negative, the return value is NaN.</returns>
		public static double sqrt(double val) {
			return default(double);
		}

		///<summary>
		///Returns the tangent of a number.
		///</summary>
		///<param name="angleRadians">A numeric expression for which the tangent is sought.</param>
		///<returns>The tangent of number.</returns>
		public static double tan(double angleRadians) {
			return default(double);
		}
	}
}