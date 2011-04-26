namespace Javascript.Global {
	using System.Collections.Generic;
	using System.Collections;

	public class HtmlNodeCollection : HtmlNodeCollection<HtmlNode> {}
	public class HtmlElementCollection : HtmlNodeCollection<HtmlElement> {}

	public class HtmlNodeCollection<T> : IEnumerable<T> where T : class {
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

		///<summary>
		///Access an item in an array
		///</summary>
		///<returns></returns>
		public T item(int index) {
			return null;
		}
	}
}
