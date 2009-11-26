namespace flash.Global {
	public class QName {
		/// <summary>
		/// [read-only] The local name of the QName object.
		/// </summary>
		public string localName {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] The Uniform Resource Identifier (URI) of the QName object.
		/// </summary>
		public string uri {
			get;
			private set;
		}

		/// <summary>
		/// Creates a QName object with a URI from a Namespace object and a localName from a QName object.
		/// </summary>
		public QName(Namespace uri, QName localName) {
			return;
		}

		/// <summary>
		/// Creates a QName object that is a copy of another QName object.
		/// </summary>
		public QName(QName qname) {
			return;
		}

		/// <summary>
		/// Returns a string composed of the URI, and the local name for the QName object, separated by "::".
		/// </summary>
		new public string toString() {
			return default(string);
		}

		/// <summary>
		/// Returns the QName object.
		/// </summary>
		new public QName valueOf() {
			return default(QName);
		}
	}
}