namespace System.Collections.Generic {
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> {
		private static EqualityComparer<T> defaultComparer;

		private static EqualityComparer<T> CreateComparer() {
			return default(EqualityComparer<T>);
		}

		public abstract bool Equals(T x, T y);
		public abstract int GetHashCode(T obj);
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count) {
			return -1;
		}

		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) {
			return -1;
		}

		bool IEqualityComparer.Equals(object x, object y) {
			return false;
		}

		int IEqualityComparer.GetHashCode(object obj) {
			return 0;
		}

		public static EqualityComparer<T> Default {
			get {
				EqualityComparer<T> defaultComparer = EqualityComparer<T>.defaultComparer;
				if (defaultComparer == null) {
					defaultComparer = EqualityComparer<T>.CreateComparer();
					EqualityComparer<T>.defaultComparer = defaultComparer;
				}
				return defaultComparer;
			}
		}
	}
}