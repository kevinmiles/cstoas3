namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false), ComVisible(true)]
	public sealed class IUnknownConstantAttribute : CustomConstantAttribute {
		public override object Value {
			get {
				return null;
			} // this is correct.
		}
	}
}