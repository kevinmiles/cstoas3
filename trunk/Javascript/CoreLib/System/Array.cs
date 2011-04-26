namespace System {
	using Collections;

	using ComponentModel;

	public class Array : IEnumerable {
		public Array() {}
		public Array(int size) {}
		public Array(Array array) {}
		public Array(params object[] items) {}

		/// <summary>
		/// Returns an integer value one higher than the highest element defined in an array.
		/// </summary>
		public int length {
			get;
			set;
		}

		/// <summary>
		/// Appends new elements to an array, and returns the new length of the array.
		/// </summary>
		/// <param name="items">Optional. New elements of the Array.</param>
		public void push(params object[] items) {}

		/// <summary>
		/// Removes the last element from an array and returns it.
		/// </summary>
		/// <returns>If the array is empty, null is returned.</returns>
		public object pop() {
			return default(object);
		}

		/// <summary>
		/// Returns a new array consisting of a combination of the current array and any additional items.
		/// </summary>
		/// <param name="items">Optional. Additional items to add to the end of the current array.</param>
		/// <returns></returns>
		public Array concat(params object[] items) {
			return default(Array);
		}

		/// <summary>
		/// Returns a string value consisting of all the elements of an array concatenated together and separated by the specified separator character.
		/// </summary>
		/// <param name="separator">Required. A JsString that is used to separate one element of an array from the next in the resulting String object. If omitted, the array elements are separated with a comma.</param>
		/// <returns></returns>
		public string join(string separator) {
			return default(string);
		}

		/// <summary>
		/// Removes elements from an array and, if necessary, inserts new elements in their place, returning the deleted elements. Returns the elements removed from the array.
		/// </summary>
		/// <param name="start">Required. The zero-based location in the array from which to start removing elements.</param>
		/// <param name="deleteCount">Required. The number of elements to remove.</param>
		/// <param name="newItems">Optional. Elements to insert into the array in place of the deleted elements.</param>
		/// <returns></returns>
		public Array splice(int start, int deleteCount, params object[] newItems) {
			return default(Array);
		}

		/// <summary>
		/// Returns a section of an array.
		/// </summary>
		/// <param name="start">Required. The index to the beginning of the specified portion of the array.</param>
		/// <param name="end">Optional. The index to the end of the specified portion of the array.</param>
		/// <remarks>
		/// The slice method returns an Array object containing the specified portion of the array.
		/// The slice method copies up to, but not including, the element indicated by end. If start is negative, it is treated as length + start where length is the length of the array. If end is negative, it is treated as length + end where length is the length of the array. If end is omitted, extraction continues to the end of the array. If end occurs before start, no elements are copied to the new array.
		/// </remarks>
		/// <returns></returns>
		public Array slice(int start, int end = int.MAX_VALUE) {
			return default(Array);
		}

		/// <summary>
		/// Returns an Array object with the elements reversed.
		/// </summary>
		/// <returns></returns>
		public Array reverse() {
			return default(Array);
		}

		/// <summary>
		/// Removes the first element from an array and returns that element.
		/// </summary>
		/// <returns></returns>
		public object shift() {
			return default(object);
		}

		
		///<summary>
		/// Inserts specified elements into the beginning of an array.
		///</summary>
		///<param name="newItems">Optional. Elements to insert at the start of the Array.</param>
		///<returns></returns>
		public object unshift(params object[] newItems) {
			return default(object);
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		/// <param name="sortFunction">Optional. OriginalValue of the function used to determine the order of the elements.</param>
		/// <returns></returns>
		public Array sort(Func<object, object, int> sortFunction) {
			return default(Array);
		}

		/// <summary>
		/// Returns an Array object with the elements sorted.
		/// </summary>
		public void sort() {
		}

		
		public object this[int i] {
			get {
				return null;
			}

			set {
				return;
			}
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public new IEnumerator GetEnumerator() {
			return new ArrayEnumerator();
		}

		sealed class ArrayEnumerator : IEnumerator {
			public object Current {
				get {
					return null;
				}
			}

			public bool MoveNext() {
				return true;
			}

			public void Reset() {
			}
		}
	}
	
}