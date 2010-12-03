namespace System.Runtime.CompilerServices {
	using InteropServices;

	[ComVisible(false)]
	public sealed class ConditionalWeakTable<TKey, TValue> where TKey : class where TValue : class {
		public void Add(TKey key, TValue value) {
			
		}

		public bool TryGetValue(TKey key, out TValue value) {
			value = default(TValue);
			return false;
		}
	}
}
