namespace System.Collections {
	public interface IEnumerable {
		IEnumerator GetEnumerator();
	}

	public interface IEnumerable<out T> : IEnumerable {
		new IEnumerator<T> GetEnumerator();
	}
}