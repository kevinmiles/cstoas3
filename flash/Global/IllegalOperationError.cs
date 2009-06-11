namespace flash.Global {
	public class IllegalOperationError : Error {

		/// <summary>
		/// The IllegalOperationError exception is thrown when a method is not implemented or the implementation doesn't cover the current usage. 
		/// </summary>
		/// <param name="pMessage">A string associated with the error object. </param>
		public IllegalOperationError(string pMessage)
			: base(pMessage, 0) {
		}

		public IllegalOperationError()
			: base("", 0) {
		}
	}
}
