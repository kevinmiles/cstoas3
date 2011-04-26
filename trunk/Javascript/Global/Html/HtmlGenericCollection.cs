namespace Javascript.Global {
	using System.Collections;
	using System.Collections.Generic;

	///<summary>
	///Represents a generic collection of HtmlNode objects
	///</summary>
	public class HtmlGenericCollection<T> : IEnumerable<T> where T : class {
		public T this[int index] {
			get {
				return null;
			}
		}

		public new T this[string name] {
			get {
				return null;
			}
		}

		public new IEnumerator<T> GetEnumerator() {
			return default(IEnumerator<T>);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return null;
		}

		public int length {
			get;
			private set;
		}
	}
}
