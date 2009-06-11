namespace flash.Global {
	[As3Name("*")]
	public class Untyped {
		//From
		public static implicit operator int (Untyped pUntyped) {
			return 0;
		}

		public static implicit operator uint(Untyped pUntyped) {
			return 0;
		}

		public static implicit operator float(Untyped pUntyped) {
			return 0;
		}

		public static implicit operator double(Untyped pUntyped) {
			return 0;
		}

		public static implicit operator string(Untyped pUntyped) {
			return "";
		}

		//To
		public static implicit operator Untyped(int pVal) {
			return null;
		}

		public static implicit operator Untyped(uint pVal) {
			return null;
		}

		public static implicit operator Untyped(float pVal) {
			return null;
		}

		public static implicit operator Untyped(double pVal) {
			return null;
		}

		public static implicit operator Untyped(string pVal) {
			return null;
		}
	}
}
