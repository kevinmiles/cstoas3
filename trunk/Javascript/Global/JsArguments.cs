namespace Javascript.Global {
	using System;

	public sealed class JsArguments {
		public object this[int index] {
			get {
				return default(object);
			}
			set {
			}
		}

		public int length {
			get;
			set;
		}

		public Delegate callee {
			get;
			set;
		}
	}
}
