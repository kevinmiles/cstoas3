namespace flash.Global {
	public class EOFError : Error {

		/// <summary>
		/// An EOFError exception is thrown when you attempt to read past the end of the available data. For example, an EOFError is thrown when one of the read methods in the IDataInput interface is called and there is insufficient data to satisfy the read request.
		/// </summary>
		/// <param name="pMessage">A string associated with the error object. </param>
		public EOFError(string pMessage)
			: base(pMessage, 0) {
		}

		public EOFError()
			: base("", 0) {
		}
	}
}
