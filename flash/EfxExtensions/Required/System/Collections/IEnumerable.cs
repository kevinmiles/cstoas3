namespace System.Collections {

	public interface IEnumerable {
		IEnumerator GetEnumerator();
	}

	public interface IEnumerable<T> : IEnumerable {
		new IEnumerator<T> GetEnumerator ();
	} 
}