namespace System {
	public struct UIntPtr {
		public static implicit operator UInt32(UIntPtr pStr) {
			return new UInt32();
		}

		public static implicit operator UIntPtr(UInt32 pStr) {
			return new UIntPtr();
		}
	}
}