namespace flash.Global {
	public class RangeError : Error {

		/// <summary>
		/// A RangeError exception is thrown when a numeric value is outside the acceptable range. When working with arrays, referring to an index position of an array item that does not exist will throw a RangeError exception. Using Number.toExponential() , Number.toPrecision() , and Number.toFixed() methods will throw a RangeError exception in cases where the arguments are outside the acceptable range of numbers. You can extend Number.toExponential() , Number.toPrecision() , and Number.toFixed() to avoid throwing a RangeError.
		/// </summary>
		/// <param name="pMessage">Contains the message associated with the RangeError object</param>
		public RangeError(string pMessage)
			: base(pMessage, 0) {
			return;
		}
	}
}
