namespace System {

	public struct UInt16 {
		public static implicit operator UInt16(UInt32 pStr) {
			return new UInt16();
		}

		public static implicit operator UInt32(UInt16 pStr) {
			return new UInt32();
		}
	}
}