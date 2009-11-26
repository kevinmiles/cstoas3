namespace System {
	using flash.Global;

	public abstract class Delegate {
		static public Delegate Combine(Delegate[] delegates) {
			return null;
		}

		static public Delegate Combine(Delegate a, Delegate b) {
			return null;
		}

		public static Delegate Remove(Delegate source, Delegate value) {
			return null;
		}

		public static Delegate RemoveAll(Delegate source,Delegate value) {
			return null;
		}

		public static implicit operator Function(Delegate pDelegate) {
			return new Function();
		}

		//public static explicit operator Delegate(Function pFunction) {
		//    return new Delegate();
		//}
	}
}
