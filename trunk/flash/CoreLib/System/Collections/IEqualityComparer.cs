namespace System.Collections {
	using ComponentModel;

	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
	public interface IEqualityComparer {
		bool Equals(object x, object y);
		int GetHashCode(object obj);
	}

	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
	public interface IEqualityComparer<in T> {
		bool Equals(T x, T y);
		int GetHashCode(T obj);
	}
}