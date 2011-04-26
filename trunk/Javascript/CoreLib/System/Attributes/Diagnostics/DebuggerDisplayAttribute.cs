namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Field |
		AttributeTargets.Delegate | AttributeTargets.Property | AttributeTargets.Assembly, AllowMultiple = true),
	 ComVisible(true)]

	internal sealed class DebuggerDisplayAttribute : Attribute {
		public DebuggerDisplayAttribute(string value) {
			if (value == null) {
				value = "";
			}

			Value = value;
			Type = "";
			Name = "";
		}

		public string Value {
			get;
			private set;
		}

		public Type Target {
			get;
			set;
		}

		public string TargetTypeName {
			get;
			set;
		}

		public string Type {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}
	}
}