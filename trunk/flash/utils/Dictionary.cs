namespace flash.utils {
	using System.Collections;
	using System.ComponentModel;
	public class Dictionary : IEnumerable<object> {
		/// <summary>
		/// Creates a new Dictionary object.
		/// </summary>
		public Dictionary(bool weakKeys)
		{
		}

		/// <summary>
		/// Creates a new Dictionary object.
		/// </summary>
		public Dictionary()
		{
		}

		public object this[object i] {
			get {
				return null;
			}

			set {
				value = i;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new IEnumerator<object> GetEnumerator() {
			return new DictionaryEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}
	}

	class DictionaryEnumerator : IEnumerator<object> {
		public object Current {
			get {
				return null;
			}
		}

		public bool MoveNext() {
			return true;
		}

		public void Reset() {}
	}
}