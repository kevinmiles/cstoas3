namespace System.Collections {
	public sealed class KeyValuePair<TKey, TValue> {
		public TKey key;
		public TValue value;

		public KeyValuePair(TKey key, TValue value) {
			this.key = key;
			this.value = value;
		}

		public new string toString() {
			return "[" + key + ", " + value + "]";
		}
	}
}
