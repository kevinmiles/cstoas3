namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field, Inherited = false), ComVisible(true)]
	public abstract class CustomConstantAttribute : Attribute {
		public abstract object Value {
			get;
		}
	}
}