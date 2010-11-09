namespace flash.utils {
	using System.Collections;
	using System.ComponentModel;
	[As3Name("DeleteItem", "*delete ({0}[{1}])", "")]
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

		public bool DeleteItem(object i) {
			return true;
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
		public IEnumerator GetEnumerator() {
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