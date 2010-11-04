namespace System {
	using flash.Global;

	public struct Int32 {
		public static implicit operator Int(Int32 pStr) {
			return new Int();
		}

		public static implicit operator Int32(Int pStr) {
			return new Int32();
		}
	}
}