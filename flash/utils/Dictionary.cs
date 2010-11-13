namespace flash.utils {
	using System.Collections;
	using System.ComponentModel;
	public class Dictionary : IEnumerable {
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
		public new IEnumerator GetEnumerator() {
			return new DictionaryEnumerator();
		}
	}

	class DictionaryEnumerator : IEnumerator {
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