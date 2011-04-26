namespace System {

	public struct Int64 {
		public static implicit operator Int64(Int32 pStr) {
			return new Int64();
		}

		public static implicit operator Int32(Int64 pStr) {
			return new Int32();
		}
	}
}