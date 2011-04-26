namespace Javascript.Global {
	using System.Collections;
	using System.Collections.Generic;

	public class HtmlAttributeCollection : IEnumerable<HtmlAttribute> {
		protected HtmlAttributeCollection() {}

		///<summary>
		///	Sets or retrieves the number of objects in a collection.
		///</summary>
		public int length {
			get;
			private set;
		}

		///<summary>
		///	Gets an attribute for an element from the attributes collection.
		///</summary>
		///<param name = "index">Integer that specifies the attribute. It is the zero-based index of the attribute to be retrieved from the attributes collection.</param>
		///<returns>Returns an attribute for an element from the attributes collection</returns>
		public HtmlAttribute this[int index] {
			get {
				return null;
			}
			set {}
		}

		///<summary>
		///	Gets an attribute for an element from the attributes collection.
		///</summary>
		///<param name = "name">String that specifies the attribute. The attribute whose name matches the JsString is retrieved.</param>
		///<returns>Returns an attribute for an element from the attributes collection</returns>
		public new HtmlAttribute this[string name] {
			get {
				return null;
			}
			set {}
		}

		#region IEnumerable<HtmlAttribute> Members
		public new IEnumerator<HtmlAttribute> GetEnumerator() {
			return default(IEnumerator<HtmlAttribute>);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return null;
		}
		#endregion
	}
}