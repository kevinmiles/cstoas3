namespace System {
	public struct UIntPtr {
		public static implicit operator UInt(UIntPtr pStr) {
			return new UInt();
		}

		public static implicit operator UIntPtr(UInt pStr) {
			return new UIntPtr();
		}
	}
}