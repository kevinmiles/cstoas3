namespace System.Collections {
	public interface IEqualityComparer {
		// Methods
		bool Equals(object x, object y);
		int GetHashCode(object obj);
	}
}