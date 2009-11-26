namespace flash.Global {
	public sealed class Namespace {
		/// <summary>
		/// The prefix of the namespace.
		/// </summary>
		public string prefix {
			get;
			set;
		}

		/// <summary>
		/// The Uniform Resource Identifier (URI) of the namespace.
		/// </summary>
		public string uri {
			get;
			set;
		}

		/// <summary>
		/// Returns the URI value of the specified object.
		/// </summary>
		new public string valueOf() {
			return default(string);
		}

		/// <summary>
		/// Creates a Namespace object.
		/// </summary>
		public Namespace(object uriValue) {
			return;
		}

		/// <summary>
		/// Creates a Namespace object according to the values of the prefixValue and uriValue parameters.
		/// </summary>
		public Namespace(object prefixValue, object uriValue) {
			return;
		}
	}
}