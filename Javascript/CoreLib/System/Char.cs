namespace System {
	public struct Char {
		public static implicit operator string(Char pChar) {
			return "";
		}

		public static implicit operator Char(string pStr) {
			return new Char();
		}
	}
}