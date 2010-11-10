namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false), ComVisible(true)]
#if NET_2_0
	
#endif
	public sealed class IDispatchConstantAttribute : CustomConstantAttribute {
		public override object Value {
			get {
				return null;
			} // this is correct.
		}
	}
}