namespace System.Runtime.CompilerServices {
	public sealed class RuntimeWrappedException : Exception {
		private object wrapped_exception = new object();

		// Called by the runtime
		private RuntimeWrappedException() {}

		public object WrappedException {
			get {
				return wrapped_exception;
			}
		}
	}
}
