namespace System {
	using flash.Global;

	public sealed class Exception {
		public static implicit operator Error(Exception pStr) {
			return new Error();
		}

		public static implicit operator Exception(Error pStr) {
			return new Exception();
		}
	}
}