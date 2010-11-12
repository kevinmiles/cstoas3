namespace System.Collections {
	internal interface IEqualityComparer {
		// Methods
		bool Equals(object x, object y);
		int GetHashCode(object obj);
	}
}