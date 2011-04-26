namespace System {
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AttributeUsageAttribute : Attribute {
		public AttributeUsageAttribute(AttributeTargets validOn) {
			Inherited = true;
			return;
		}

		public bool AllowMultiple {
			get;
			set;
		}

		public bool Inherited {
			get;
			set;
		}
	}
}