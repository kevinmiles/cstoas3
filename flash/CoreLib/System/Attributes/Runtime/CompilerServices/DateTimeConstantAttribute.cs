namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false), ComVisible(true)]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute {
		private readonly long ticks;

		public DateTimeConstantAttribute(long ticks) {
			this.ticks = ticks;
		}

		internal long Ticks {
			get {
				return ticks;
			}
		}

		public override object Value {
			get {
				return ticks;
			}
		}
	}
}