namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field, Inherited = false), ComVisible(true)]
#if NET_2_0
	
#endif
	public abstract class CustomConstantAttribute : Attribute {
		public abstract object Value {
			get;
		}
	}
}