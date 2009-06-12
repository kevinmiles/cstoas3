namespace flash.net {
	public class URLRequestHeader {
		/// <summary>
		/// An HTTP request header name (such as Content-Type or SOAPAction).
		/// </summary>
		public string name {
			get;
			set;
		}

		/// <summary>
		/// The value associated with the name property (such as text/plain).
		/// </summary>
		public string value {
			get;
			set;
		}

		/// <summary>
		/// Creates a new URLRequestHeader object that encapsulates a single HTTP request header.
		/// </summary>
		public URLRequestHeader(string name, string value) {}

		/// <summary>
		/// Creates a new URLRequestHeader object that encapsulates a single HTTP request header.
		/// </summary>
		public URLRequestHeader(string name) {}

		/// <summary>
		/// Creates a new URLRequestHeader object that encapsulates a single HTTP request header.
		/// </summary>
		public URLRequestHeader() {}
	}
}