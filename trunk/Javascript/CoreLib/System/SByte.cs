namespace System {

	public struct SByte {
		public static implicit operator int(SByte pStr) {
			return new int();
		}
		
		public static implicit operator SByte(int pStr) {
			return new SByte();
		}
	}
}