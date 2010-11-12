namespace System {
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
		AttributeTargets.Enum | AttributeTargets.Constructor |
		AttributeTargets.Method | AttributeTargets.Property |
		AttributeTargets.Field | AttributeTargets.Event |
		AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class ObsoleteAttribute : Attribute {
		//	 Constructors
		public ObsoleteAttribute() {
		}

		public ObsoleteAttribute(string message) {
			Message = message;
		}

		public ObsoleteAttribute(string message, bool error) {
			Message = message;
			IsError = error;
		}

		// Properties
		public string Message {
			get;
			private set;
		}

		public bool IsError {
			get;
			private set;
		}
	}
}