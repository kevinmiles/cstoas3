namespace System.Collections.Generic {
	internal interface IEqualityComparer<in T> {
		// Methods
		bool Equals(T x, T y);
		int GetHashCode(T obj);
	}
}