namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false), ComVisible(true)]
	public sealed class DecimalConstantAttribute : Attribute {
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) {
		}

		public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low) {
		}

		public Decimal Value {
			get;
			set;
		}
	}
}