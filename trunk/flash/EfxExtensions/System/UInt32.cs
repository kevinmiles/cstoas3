namespace System {
	public struct UInt32 {
		public static implicit operator UInt(UInt32 pStr) {
			return new UInt();
		}

		public static implicit operator UInt32(UInt pStr) {
			return new UInt32();
		}
	}
}