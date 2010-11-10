namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false), ComVisible(true)]
#if NET_2_0
	
#endif
	public sealed class MethodImplAttribute : Attribute {
		private readonly MethodImplOptions _val;

		public MethodImplAttribute() {}

		public MethodImplAttribute(short value) {
			_val = (MethodImplOptions) value;
		}

		public MethodImplAttribute(MethodImplOptions methodImplOptions) {
			_val = methodImplOptions;
		}

		public MethodCodeType MethodCodeType;

		public MethodImplOptions Value {
			get {
				return _val;
			}
		}
	}
}