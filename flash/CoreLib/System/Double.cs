
namespace System {
	using flash.Global;

	public struct Double  {
		public static implicit operator double(Number pStr) {
			return 0;
		}

		public static implicit operator Number(double pStr) {
			return null;
		}
	}
}
