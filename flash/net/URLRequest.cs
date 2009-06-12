namespace flash.net {
	public class URLRequest {
		/// <summary>
		/// Creates a URLRequest object.
		/// </summary>
		public URLRequest(string url) {}

		/// <summary>
		/// Creates a URLRequest object.
		/// </summary>
		public URLRequest() {}

		/// <summary>
		/// The MIME content type of the content in the the data property.
		/// </summary>
		public string contentType {
			get;
			set;
		}

		/// <summary>
		/// An object containing data to be transmitted with the URL request.
		/// </summary>
		public object data {
			get;
			set;
		}

		/// <summary>
		/// A string that uniquely identifies the signed Adobe platform component to be stored to (or retrieved from) the Flash Player cache.
		/// </summary>
		public string digest {
			get;
			set;
		}

		/// <summary>
		/// Controls the HTTP form submission method.
		/// </summary>
		public URLRequestMethod method {
			get;
			set;
		}

		/// <summary>
		/// The array of HTTP request headers to be appended to the HTTP request.
		/// </summary>
		public URLRequestHeader[] requestHeaders {
			get;
			set;
		}

		/// <summary>
		/// The URL to be requested.
		/// </summary>
		public string url {
			get;
			set;
		}
	}
}