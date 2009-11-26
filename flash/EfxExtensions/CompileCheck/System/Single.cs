namespace System {
	using flash.Global;

	public struct Single {
		public static implicit operator Single(Number pStr) {
			return new Single();
		}

		public static implicit operator Number(Single pStr) {
			return null;
		}
	}
}