namespace System.Collections.Generic {
	using ComponentModel;

	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T> {
		private static EqualityComparer<T> defaultComparer;

		public static EqualityComparer<T> Default {
			get {
				EqualityComparer<T> defaultComparer = EqualityComparer<T>.defaultComparer;
				if (defaultComparer == null) {
					defaultComparer = CreateComparer();
					EqualityComparer<T>.defaultComparer = defaultComparer;
				}
				return defaultComparer;
			}
		}

		#region IEqualityComparer Members
		bool IEqualityComparer.Equals(object x, object y) {
			return false;
		}

		int IEqualityComparer.GetHashCode(object obj) {
			return 0;
		}
		#endregion

		#region IEqualityComparer<T> Members
		public abstract bool Equals(T x, T y);
		public abstract int GetHashCode(T obj);
		#endregion

		private static EqualityComparer<T> CreateComparer() {
			return default(EqualityComparer<T>);
		}

		internal virtual int IndexOf(T[] array, T value, int startIndex, int count) {
			return -1;
		}

		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) {
			return -1;
		}
	}
}