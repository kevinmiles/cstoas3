namespace System {
	public class Array {

		public static implicit operator Array(flash.Global.Array pStr) {
			return new Array();
		}

		public static implicit operator flash.Global.Array(Array pStr) {
			return new flash.Global.Array();
		}
	}
}