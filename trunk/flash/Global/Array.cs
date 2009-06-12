namespace flash.Global {
	using System;

	[Flags]
	[As3Name("Array")]
	public enum ArraySortOptions {
		/// <summary>
		/// [static] Specifies case-insensitive sorting for the Array class sorting methods.
		/// </summary>
		CASEINSENSITIVE,

		/// <summary>
		/// [static] Specifies descending sorting for the Array class sorting methods.
		/// </summary>
		DESCENDING,

		/// <summary>
		/// [static] Specifies numeric (instead of character-string) sorting for the Array class sorting methods.
		/// </summary>
		NUMERIC,

		/// <summary>
		/// [static] Specifies that a sort returns an array that consists of array indices.
		/// </summary>
		RETURNINDEXEDARRAY,

		/// <summary>
		/// [static] Specifies the unique sorting requirement for the Array class sorting methods.
		/// </summary>
		UNIQUESORT
	}

	public class Array {
		public delegate bool ArrayFilterCallback(object item, int index, Array array);
		public delegate void ArrayForeachCallback(object item, int index, Array array);
		public delegate float ArraySortCallback(object itemA, object itemB);


		/// <summary>
		/// A non-negative integer specifying the number of elements in the array.
		/// </summary>
		public uint length {
			get;
			set;
		}

		/// <summary>
		/// Concatenates the elements specified in the parameters with the elements in an array and creates a new array.
		/// </summary>
		public Array concat(params object[] args) {
			return default(Array);
		}

		/// <summary>
		/// Concatenates the elements specified in the parameters with the elements in an array and creates a new array.
		/// </summary>
		public Array concat() {
			return default(Array);
		}

		

		/// <summary>
		/// Executes a test function on each item in the array until an item is reached that returns false for the specified function.
		/// </summary>
		public bool every(ArrayFilterCallback callback, object thisObject) {
			return default(bool);
		}

		/// <summary>
		/// Executes a test function on each item in the array until an item is reached that returns false for the specified function.
		/// </summary>
		public bool every(ArrayFilterCallback callback) {
			return default(bool);
		}

		/// <summary>
		/// Executes a test function on each item in the array and constructs a new array for all items that return true for the specified function.
		/// </summary>
		public Array filter(ArrayFilterCallback callback, object thisObject) {
			return default(Array);
		}

		/// <summary>
		/// Executes a test function on each item in the array and constructs a new array for all items that return true for the specified function.
		/// </summary>
		public Array filter(ArrayFilterCallback callback) {
			return default(Array);
		}

		/// <summary>
		/// Executes a function on each item in the array.
		/// </summary>
		public void forEach(ArrayForeachCallback callback, object thisObject) {
		}

		/// <summary>
		/// Executes a function on each item in the array.
		/// </summary>
		public void forEach(ArrayForeachCallback callback) {
		}

		/// <summary>
		/// Searches for an item in an array by using strict equality (===) and returns the index position of the item.
		/// </summary>
		public int indexOf(object searchElement, int fromIndex) {
			return default(int);
		}

		/// <summary>
		/// Searches for an item in an array by using strict equality (===) and returns the index position of the item.
		/// </summary>
		public int indexOf(object searchElement) {
			return default(int);
		}

		/// <summary>
		/// Converts the elements in an array to strings, inserts the specified separator between the elements, concatenates them, and returns the resulting string.
		/// </summary>
		public string join(object sep) {
			return default(string);
		}

		/// <summary>
		/// Searches for an item in an array, working backward from the last item, and returns the index position of the matching item using strict equality (===).
		/// </summary>
		public int lastIndexOf(object searchElement, int fromIndex) {
			return default(int);
		}

		/// <summary>
		/// Searches for an item in an array, working backward from the last item, and returns the index position of the matching item using strict equality (===).
		/// </summary>
		public int lastIndexOf(object searchElement) {
			return default(int);
		}

		/// <summary>
		/// Executes a function on each item in an array, and constructs a new array of items corresponding to the results of the function on each item in the original array.
		/// </summary>
		public Array map(ArrayForeachCallback callback, object thisObject) {
			return default(Array);
		}

		/// <summary>
		/// Executes a function on each item in an array, and constructs a new array of items corresponding to the results of the function on each item in the original array.
		/// </summary>
		public Array map(ArrayForeachCallback callback) {
			return default(Array);
		}

		/// <summary>
		/// Removes the last element from an array and returns the value of that element.
		/// </summary>
		public object pop() {
			return default(object);
		}

		/// <summary>
		/// Adds one or more elements to the end of an array and returns the new length of the array.
		/// </summary>
		public uint push(params object[] args) {
			return default(uint);
		}

		/// <summary>
		/// Adds one or more elements to the end of an array and returns the new length of the array.
		/// </summary>
		public uint push() {
			return default(uint);
		}

		/// <summary>
		/// Reverses the array in place.
		/// </summary>
		public Array reverse() {
			return default(Array);
		}

		/// <summary>
		/// Removes the first element from an array and returns that element.
		/// </summary>
		public object shift() {
			return default(object);
		}

		/// <summary>
		/// Returns a new array that consists of a range of elements from the original array, without modifying the original array.
		/// </summary>
		public Array slice(int startIndex, int endIndex) {
			return default(Array);
		}

		/// <summary>
		/// Returns a new array that consists of a range of elements from the original array, without modifying the original array.
		/// </summary>
		public Array slice(int startIndex) {
			return default(Array);
		}

		/// <summary>
		/// Returns a new array that consists of a range of elements from the original array, without modifying the original array.
		/// </summary>
		public Array slice() {
			return default(Array);
		}

		/// <summary>
		/// Executes a test function on each item in the array until an item is reached that returns true.
		/// </summary>
		public bool some(ArrayFilterCallback callback, object thisObject) {
			return default(bool);
		}

		/// <summary>
		/// Executes a test function on each item in the array until an item is reached that returns true.
		/// </summary>
		public bool some(ArrayFilterCallback callback) {
			return default(bool);
		}

		/// <summary>
		/// Sorts the elements in an array.
		/// </summary>
		public Array sort(ArraySortCallback callback) {
			return default(Array);
		}

		public Array sort(ArraySortOptions options) {
			return default(Array);
		}

		/// <summary>
		/// Sorts the elements in an array.
		/// </summary>
		public Array sort() {
			return default(Array);
		}

		/// <summary>
		/// Sorts the elements in an array according to one or more fields in the array.
		/// </summary>
		public Array sortOn(object fieldName, object options) {
			return default(Array);
		}

		/// <summary>
		/// Sorts the elements in an array according to one or more fields in the array.
		/// </summary>
		public Array sortOn(object fieldName) {
			return default(Array);
		}

		/// <summary>
		/// Adds elements to and removes elements from an array.
		/// </summary>
		public Array splice(int startIndex, uint deleteCount,  params object[] values) {
			return default(Array);
		}

		/// <summary>
		/// Adds elements to and removes elements from an array.
		/// </summary>
		public Array splice(int startIndex, uint deleteCount) {
			return default(Array);
		}

		/// <summary>
		/// Returns a string that represents the elements in the specified array.
		/// </summary>
		public string toLocaleString() {
			return default(string);
		}

		/// <summary>
		/// Adds one or more elements to the beginning of an array and returns the new length of the array.
		/// </summary>
		public uint unshift( params object[] args) {
			return default(uint);
		}

		/// <summary>
		/// Adds one or more elements to the beginning of an array and returns the new length of the array.
		/// </summary>
		public uint unshift() {
			return default(uint);
		}

		/// <summary>
		/// Lets you create an array of the specified number of elements.
		/// </summary>
		public Array(int numElements) {
		}

		/// <summary>
		/// Lets you create an array of the specified number of elements.
		/// </summary>
		public Array() {
		}

		/// <summary>
		/// Lets you create an array that contains the specified elements.
		/// </summary>
		public Array( params object[] values) {
		}

		public object this[int i] {
			get {
				return null;
			}
		}

		//from to..
		public static implicit operator string[](Array array) {
			return null;
		}

		public static implicit operator object[](Array array) {
			return null;
		}
		//----
		public static implicit operator Array(string[] val) {
			return null;
		}

		public static implicit operator Array(object[] val) {
			return null;
		}

		public static implicit operator Array(int[] val) {
			return null;
		}
	}
}