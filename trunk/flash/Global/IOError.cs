namespace flash.Global {
	public class IOError : Error {

		/// <summary>
		/// The IOError exception is thrown when some type of input or output failure occurs. For example, an IOError exception is thrown if a read/write operation is attempted on a socket that has not connected or that has become disconnected.
		/// </summary>
		/// <param name="pMessage">A string associated with the error object. </param>
		public IOError(string pMessage)
			: base(pMessage, 0) {
		}

		public IOError()
			: base("", 0) {
		}
	}
}
