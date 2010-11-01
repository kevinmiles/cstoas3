namespace System {

	public struct UInt64 {
		public static implicit operator UInt64(UInt32 pStr) {
			return new UInt64();
		}

		public static implicit operator UInt32(UInt64 pStr) {
			return new UInt32();
		}
	}
}