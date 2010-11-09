namespace System {

	public struct UInt16 {
		public static implicit operator UInt16(UInt32 pStr) {
			return new UInt16();
		}

		public static implicit operator UInt32(UInt16 pStr) {
			return new UInt32();
		}

		public static implicit operator UInt(UInt16 pStr) {
			return new UInt();
		}

		public static implicit operator UInt16(UInt pStr) {
			return new UInt16();
		}
	}
}