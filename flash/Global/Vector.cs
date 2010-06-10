namespace flash.Global {
	using System;
	using System.Collections;

	[As3IsGeneric(true)]
	public class Vector<T> : IEnumerable<T> {

		[As3Name("fixed")]
		public bool isFixed;

		public uint length;

		public delegate bool VectorFilterCallback(T pItem, int pIndex, Vector<T> pVector);
		public delegate void VectorForEachCallback(T pItem, int pIndex, Vector<T> pVector);
		public delegate T VectorMapCallback(T pItem, int pIndex, Vector<T> pVector);

		/// <summary>
		/// The logic of the compareFunction function is that, given two elements x and y , the function returns one of the following three values
		/// * a negative number, if x should appear before y in the sorted sequence
		/// * 0, if x equals y
		/// * positive number, if x should appear after y in the sorted sequence 
		/// </summary>
		public delegate int VectorSortCallback(T pItemX, T pItemY);

		/// <summary>
		/// Creates a Vector with the specified base type
		/// </summary>
		public Vector() {
			return;
		}

		/// <summary>
		/// Creates a Vector with the specified base type
		/// </summary>
		/// <param name="pLength">The initial length (number of elements) of the Vector. If this parameter is greater than zero, the specified number of Vector elements are created and populated with the default value appropriate to the base type ( null for reference types).</param>
		public Vector(uint pLength) {
			return;
		}
		/// <summary>
		/// Creates a Vector with the specified base type
		/// </summary>
		/// <param name="pLength">The initial length (number of elements) of the Vector. If this parameter is greater than zero, the specified number of Vector elements are created and populated with the default value appropriate to the base type ( null for reference types).</param>
		/// <param name="pIsFixed">Whether the Vector's length is fixed ( true ) or can be changed ( false ). This value can also be set using the <see cref="isFixed"/> property</param>
		public Vector(uint pLength, bool pIsFixed) {
			return;
		}

		/// <summary>
		/// Concatenates the elements specified in the parameters with the elements in the Vector and creates a new Vector. If the parameters specify a Vector, the elements of that Vector are concatenated.
		/// </summary>
		/// <param name="pElements">One or more values of the base type of this Vector to be concatenated in a new Vector. If you don't pass any values, the new Vector is a duplicate of the original Vector.</param>
		/// <returns>A Vector with the same base type as this Vector that contains the elements from this Vector followed by elements from the parameters</returns>
		/// <exception cref="TypeError">If any argument is not an instance of the base type and can't be converted to the base type</exception>
		public Vector<T> concat(params T[] pElements) {
			return null;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector until an item is reached that returns false for the specified function. You use this method to determine whether all items in a Vector meet a criterion, such as having values less than a particular number.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object</param>
		/// <param name="pThisObject">The object that the identifer this in the callback function refers to when the function is called.</param>
		/// <returns>A Boolean value of true if the specified function returns true when called on all items in the Vector; otherwise, false.</returns>
		public bool every(VectorFilterCallback pCallback, object pThisObject) {
			return false;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector until an item is reached that returns false for the specified function. You use this method to determine whether all items in a Vector meet a criterion, such as having values less than a particular number.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object</param>
		/// <returns>A Boolean value of true if the specified function returns true when called on all items in the Vector; otherwise, false.</returns>
		public bool every(VectorFilterCallback pCallback) {
			return false;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector and returns a new Vector containing all items that return true for the specified function. If an item returns false , it is not included in the result Vector. The base type of the return Vector matches the base type of the Vector on which the method is called.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <param name="pThisObject">The object that the identifer this in the callback function refers to when the function is called.</param>
		/// <returns>A new Vector that contains all items from the original Vector for which the callback function returned true.</returns>
		public Vector<T> filter(VectorFilterCallback pCallback, object pThisObject) {
			return null;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector and returns a new Vector containing all items that return true for the specified function. If an item returns false , it is not included in the result Vector. The base type of the return Vector matches the base type of the Vector on which the method is called.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <returns>A new Vector that contains all items from the original Vector for which the callback function returned true.</returns>
		public Vector<T> filter(VectorFilterCallback pCallback) {
			return null;
		}

		/// <summary>
		/// Executes a function on each item in the Vector.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <param name="pThisObject">The object that the identifer this in the callback function refers to when the function is called.</param>
		public void forEach(VectorForEachCallback pCallback, object pThisObject) {
			return;
		}

		/// <summary>
		/// Executes a function on each item in the Vector.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		public void forEach(VectorForEachCallback pCallback) {
			return;
		}

		/// <summary>
		/// Searches for an item in the Vector and returns the index position of the item. The item is compared to the Vector elements using strict equality ( === )
		/// </summary>
		/// <param name="pSearchElement">The item to find in the Vector.</param>
		/// <param name="pFrom">The location in the Vector from which to start searching for the item. If this parameter is negative, it is treated as length + fromIndex , meaning the search starts -fromIndex items from the end and searches from that position forward to the end of the Vector.</param>
		/// <returns>A zero-based index position of the item in the Vector. If the searchElement argument is not found, the return value is -1.</returns>
		public int indexOf(T pSearchElement, int pFrom) {
			return 0;
		}

		/// <summary>
		/// Searches for an item in the Vector and returns the index position of the item. The item is compared to the Vector elements using strict equality ( === )
		/// </summary>
		/// <param name="pSearchElement">The item to find in the Vector.</param>
		/// <returns>A zero-based index position of the item in the Vector. If the searchElement argument is not found, the return value is -1.</returns>
		public int indexOf(T pSearchElement) {
			return 0;
		}

		/// <summary>
		/// Converts the elements in the Vector to strings, inserts the specified separator between the elements, concatenates them, and returns the resulting string. A nested Vector is always separated by a comma (,), not by the separator passed to the join() method.
		/// </summary>
		/// <param name="pSeparator">A character or string that separates Vector elements in the returned string. If you omit this parameter, a comma is used as the default separator.</param>
		/// <returns>A string consisting of the elements of the Vector converted to strings and separated by the specified string.</returns>
		public string join(string pSeparator) {
			return "";
		}

		/// <summary>
		/// Converts the elements in the Vector to strings, inserts the specified separator between the elements, concatenates them, and returns the resulting string. A nested Vector is always separated by a comma (,), not by the separator passed to the join() method.
		/// </summary>
		/// <returns>A string consisting of the elements of the Vector converted to strings and separated by the specified string.</returns>
		public string join() {
			return "";
		}

		/// <summary>
		/// Searches for an item in the Vector, working backward from the specified index position, and returns the index position of the matching item. The item is compared to the Vector elements using strict equality ( === ).
		/// </summary>
		/// <param name="pSearchElement">The location in the Vector from which to start searching for the item. The default is the maximum allowable index value, meaning that the search starts at the last item in the Vector.</param>
		/// <param name="pFrom">The item to find in the Vector.</param>
		/// <returns>A zero-based index position of the item in the Vector. If the searchElement argument is not found, the return value is -1.</returns>
		public int lastIndexOf(T pSearchElement, int pFrom) {
			return 0;
		}

		/// <summary>
		/// Searches for an item in the Vector, working backward from the specified index position, and returns the index position of the matching item. The item is compared to the Vector elements using strict equality ( === ).
		/// </summary>
		/// <param name="pSearchElement">The location in the Vector from which to start searching for the item. The default is the maximum allowable index value, meaning that the search starts at the last item in the Vector.</param>
		/// <returns>A zero-based index position of the item in the Vector. If the searchElement argument is not found, the return value is -1.</returns>
		public int lastIndexOf(T pSearchElement) {
			return 0;
		}

		/// <summary>
		/// Executes a function on each item in the Vector, and returns a new Vector of items corresponding to the results of calling the function on each item in this Vector. The result Vector has the same base type and length as the original Vector. The element at index i in the result Vector is the result of the call on the element at index i in the original Vector.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <param name="pThisObject">The object that the identifer this in the callback function refers to when the function is called.</param>
		/// <returns>A new Vector that contains the results of calling the function on each item in this Vector. The result Vector has the same base type and length as the original.</returns>
		public Vector<T> map(VectorMapCallback pCallback, object pThisObject) {
			return null;
		}

		/// <summary>
		/// Executes a function on each item in the Vector, and returns a new Vector of items corresponding to the results of calling the function on each item in this Vector. The result Vector has the same base type and length as the original Vector. The element at index i in the result Vector is the result of the call on the element at index i in the original Vector.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <returns>A new Vector that contains the results of calling the function on each item in this Vector. The result Vector has the same base type and length as the original.</returns>
		public Vector<T> map(VectorMapCallback pCallback) {
			return null;
		}

		/// <summary>
		/// Removes the last element from the Vector and returns that element. The length property of the Vector is decreased by one when this function is called.
		/// </summary>
		/// <returns>The value of the last element in the specified Vector.</returns>
		/// <exception cref="RangeError">If this method is called while <see cref="isFixed"/> is true.</exception>
		public T pop() {
			return default(T);
		}

		/// <summary>
		/// Adds one or more elements to the end of the Vector and returns the new length of the Vector. Because this function can accept multiple arguments, the data type of the arguments is not checked at compile time even in strict mode. However, if an argument is passed that is not an instance of the base type, an exception occurs at run time.
		/// </summary>
		/// <param name="pElements">One or more values to append to the Vector.</param>
		/// <returns>The length of the Vector after the new elements are added.</returns>
		/// <exception cref="TypeError">If any argument is not an instance of the base type T of the Vector.</exception>
		/// <exception cref="RangeError">If this method is called while <see cref="isFixed"/> is true.</exception>
		public uint push(params T[] pElements) {
			return 0;
		}

		/// <summary>
		/// Reverses the order of the elements in the Vector. This method alters the Vector on which it is called
		/// </summary>
		/// <returns>The Vector with the elements in reverse order.</returns>
		public Vector<T> reverse() {
			return null;
		}

		/// <summary>
		/// Removes the first element from the Vector and returns that element. The remaining Vector elements are moved from their original position, i, to i - 1.
		/// </summary>
		/// <returns>The first element in the Vector.</returns>
		/// <exception cref="RangeError">If <see cref="isFixed"/> is true.</exception>
		public T shift() {
			return default(T);
		}

		/// <summary>
		/// Returns a new Vector that consists of a range of elements from the original Vector, without modifying the original Vector. The returned Vector includes the startIndex element and all elements up to, but not including, the endIndex element. If you don't pass any parameters, a duplicate of the original Vector is created.
		/// </summary>
		/// <param name="pStartIndex">A number specifying the index of the starting point for the slice. If startIndex is a negative number, the starting point begins at the end of the Vector, where -1 is the last element.</param>
		/// <param name="pEndIndex">A number specifying the index of the ending point for the slice. If you omit this parameter, the slice includes all elements from the starting point to the end of the Vector. If endIndex is a negative number, the ending point is specified from the end of the Vector, where -1 is the last element.</param>
		/// <returns>a Vector that consists of a range of elements from the original Vector.</returns>
		public Vector<T> slice(int pStartIndex, int pEndIndex) {
			return null;
		}

		/// <summary>
		/// Returns a new Vector that consists of a range of elements from the original Vector, without modifying the original Vector. The returned Vector includes the startIndex element and all elements up to, but not including, the endIndex element. If you don't pass any parameters, a duplicate of the original Vector is created.
		/// </summary>
		/// <param name="pStartIndex">A number specifying the index of the starting point for the slice. If startIndex is a negative number, the starting point begins at the end of the Vector, where -1 is the last element.</param>
		/// <returns>a Vector that consists of a range of elements from the original Vector.</returns>
		public Vector<T> slice(int pStartIndex) {
			return null;
		}

		/// <summary>
		/// Returns a new Vector that consists of a range of elements from the original Vector, without modifying the original Vector. The returned Vector includes the startIndex element and all elements up to, but not including, the endIndex element. If you don't pass any parameters, a duplicate of the original Vector is created.
		/// </summary>
		/// <returns>a Vector that consists of a range of elements from the original Vector.</returns>
		public Vector<T> slice() {
			return null;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector until an item is reached that returns true . Use this method to determine whether any items in a Vector meet a criterion, such as having a value less than a particular number.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <param name="pThisObject">The object that the identifer this in the callback function refers to when the function is called.</param>
		/// <returns>A Boolean value of true if any items in the Vector return true for the specified function; otherwise, false.</returns>
		public bool some(VectorFilterCallback pCallback, object pThisObject) {
			return false;
		}

		/// <summary>
		/// Executes a test function on each item in the Vector until an item is reached that returns true. Use this method to determine whether any items in a Vector meet a criterion, such as having a value less than a particular number.
		/// </summary>
		/// <param name="pCallback">The function to run on each item in the Vector. This function is invoked with three arguments: the current item from the Vector, the index of the item, and the Vector object.</param>
		/// <returns>A Boolean value of true if any items in the Vector return true for the specified function; otherwise, false.</returns>
		public bool some(VectorFilterCallback pCallback) {
			return false;
		}

		/// <summary>
		/// Sorts the elements in the Vector. This method sorts according to the function provided as the <paramref name="pCallback"/> parameter.
		/// </summary>
		/// <param name="pCallback">A comparison method that determines the behavior of the sort.</param>
		/// <returns>This Vector, with elements in the new order.</returns>
		public Vector<T> sort(VectorSortCallback pCallback) {
			return null;
		}

		/// <summary>
		/// Adds elements to and removes elements from the Vector. This method modifies the Vector without making a copy.
		/// </summary>
		/// <param name="pStartIndex">An integer that specifies the index of the element in the Vector where the insertion or deletion begins. You can use a negative integer to specify a position relative to the end of the Vector (for example, -1 for the last element of the Vector).</param>
		/// <param name="pDeleteCount">An integer that specifies the number of elements to be deleted. This number includes the element specified in the startIndex parameter. If you do not specify a value for the deleteCount parameter, the method deletes all of the values from the startIndex element to the last element in the Vector. If the value is 0, no elements are deleted.</param>
		/// <param name="pElements">An optional list of one or more comma-separated values, or a Vector, to insert into the Vector at the position specified in the startIndex parameter.</param>
		/// <returns></returns>
		public Vector<T> splice(int pStartIndex, int pDeleteCount, params T[] pElements) {
			return null;
		}

		/// <summary>
		/// Adds elements to and removes elements from the Vector. This method modifies the Vector without making a copy.
		/// </summary>
		/// <param name="pStartIndex">An integer that specifies the index of the element in the Vector where the insertion or deletion begins. You can use a negative integer to specify a position relative to the end of the Vector (for example, -1 for the last element of the Vector).</param>
		/// <param name="pDeleteCount">An integer that specifies the number of elements to be deleted. This number includes the element specified in the startIndex parameter. If you do not specify a value for the deleteCount parameter, the method deletes all of the values from the startIndex element to the last element in the Vector. If the value is 0, no elements are deleted.</param>
		/// <param name="pElements">An optional list of one or more comma-separated values, or a Vector, to insert into the Vector at the position specified in the startIndex parameter.</param>
		/// <returns></returns>
		public Vector<T> splice(int pStartIndex, int pDeleteCount, Vector<T> pElements) {
			return null;
		}

		/// <summary>
		/// Adds elements to and removes elements from the Vector. This method modifies the Vector without making a copy.
		/// </summary>
		/// <param name="pStartIndex">An integer that specifies the index of the element in the Vector where the insertion or deletion begins. You can use a negative integer to specify a position relative to the end of the Vector (for example, -1 for the last element of the Vector).</param>
		/// <param name="pDeleteCount">An integer that specifies the number of elements to be deleted. This number includes the element specified in the startIndex parameter. If you do not specify a value for the deleteCount parameter, the method deletes all of the values from the startIndex element to the last element in the Vector. If the value is 0, no elements are deleted.</param>
		/// <returns></returns>
		public Vector<T> splice(int pStartIndex, int pDeleteCount) {
			return null;
		}

		/// <summary>
		/// Returns a string that represents the elements in the specified Vector. Every element in the Vector, starting with index 0 and ending with the highest index, is converted to a concatenated string and separated by commas. In the ActionScript 3.0 implementation, this method returns the same value as the Vector.toString() method.
		/// </summary>
		/// <returns>A string of Vector elements.</returns>
		public string toLocaleString() {
			return "";
		}

		/// <summary>
		/// Returns a string that represents the elements in the Vector. Every element in the Vector, starting with index 0 and ending with the highest index, is converted to a concatenated string and separated by commas. To specify a custom separator, use the Vector.join() method.
		/// </summary>
		/// <returns>A string of Vector elements.</returns>
		new public string toString() {
			return "";
		}

		/// <summary>
		/// Adds one or more elements to the beginning of the Vector and returns the new length of the Vector. The other elements in the Vector are moved from their original position, i, to i + the number of new elements. Because this function can accept multiple arguments, the data type of the arguments is not checked at compile time even in strict mode. However, if an argument is passed that is not an instance of the base type, an exception occurs at run time.
		/// </summary>
		/// <param name="pElements">One or more instances of the base type of the Vector to be inserted at the beginning of the Vector.</param>
		/// <returns>An integer representing the new length of the Vector.</returns>
		/// <exception cref="TypeError">If any argument is not an instance of the base type T of the Vector.</exception>
		/// <exception cref="RangeError">If this method is called while <see cref="isFixed"/> is true.</exception>
		public uint unshift(params T[] pElements) {
			return 0;
		}

		public object this[int i] {
			get {
				return null;
			}
		}

		///<summary>
		/// Converts an Array to a Vector of type <typeparamref name="T"/>
		///</summary>
		///<param name="array"></param>
		///<returns></returns>
		public static explicit operator Vector<T>(Array array) {
			return null;
		}

		public static explicit operator Array(Vector<T> vector) {
			return null;
		}

		//public static explicit operator Vector<T>(T[] array) {
		//    return null;
		//}

		public static implicit operator Vector<T>(T[] array) {
		    return null;
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		public IEnumerator<T> GetEnumerator() {
			return new VectorEnumerator<T>();
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}
	}

	[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
	public class VectorEnumerator<T> : IEnumerator<T> {
		object IEnumerator.Current {
			get {
				return Current;
			}
		}

		public T Current {
			get {
				return default(T);
			}
		}

		public bool MoveNext() {
			return true;
		}

		public void Reset() {
			
		}
	}
}