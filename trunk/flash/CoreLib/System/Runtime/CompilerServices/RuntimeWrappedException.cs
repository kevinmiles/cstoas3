#if NET_2_0

namespace System.Runtime.CompilerServices {
	public sealed class RuntimeWrappedException : Exception {
#pragma warning disable 649

		#region Synch with object-internals.h
		private object wrapped_exception;
		#endregion

#pragma warning restore 649

		// Called by the runtime
		private RuntimeWrappedException() {}

		public object WrappedException {
			get {
				return wrapped_exception;
			}
		}
	}
}


#endif