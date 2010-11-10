
#if NET_2_0 || BOOTSTRAP_NET_2_0


namespace System.Runtime.CompilerServices {
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	
	public sealed class RuntimeCompatibilityAttribute : Attribute {
		#region Synch with object-internals.h
		private bool wrap_non_exception_throws;
		#endregion

		public bool WrapNonExceptionThrows {
			get {
				return wrap_non_exception_throws;
			}
			set {
				wrap_non_exception_throws = value;
			}
		}
	}
}


#endif