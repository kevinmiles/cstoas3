namespace System.Collections.Generic {
	public interface IEqualityComparer<in T> {
		// Methods
		bool Equals(T x, T y);
		int GetHashCode(T obj);
	}
}