namespace flash.Global {
	public class TypeError : Error {

		/// <summary>
		/// A TypeError exception is thrown when the actual type of an operand is different from the expected type
		/// </summary>
		/// <param name="pMessage">Contains the message associated with the TypeError object</param>
		public TypeError(string pMessage) : base(pMessage, 0) {

		}
	}
}
