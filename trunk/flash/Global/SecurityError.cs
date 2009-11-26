namespace flash.Global {
	public class SecurityError : Error {

		/// <summary>
		/// The SecurityError exception is thrown when some type of security violation takes place. 
		/// </summary>
		/// <param name="pMessage">A string associated with the error object. </param>
		public SecurityError(string pMessage)
			: base(pMessage, 0) {
			return;
		}

		public SecurityError()
			: base("", 0) {
			return;
		}
	}
}
