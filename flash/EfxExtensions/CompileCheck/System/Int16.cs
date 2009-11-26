namespace System {

	public struct Int16 {
		public static implicit operator Int32(Int16 pStr) {
			return new Int32();
		}

		public static implicit operator Int16(Int32 pStr) {
			return new Int16();
		}
	}
}