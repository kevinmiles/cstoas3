namespace System {

	public struct Byte {
		public static implicit operator int(Byte pStr) {
			return new int();
		}
		
		public static implicit operator Byte(int pStr) {
			return new Byte();
		}
	}
}