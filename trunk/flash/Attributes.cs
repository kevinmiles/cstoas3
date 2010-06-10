namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	public sealed class As3EventAttribute : Attribute {
		public As3EventAttribute(string eventName) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class As3MainClassAttribute : Attribute {
		public As3MainClassAttribute(int pWidth, int pHeight, int pFrameRate, uint pBackgroundColor) {
			return;
		}
	}


	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = false)]
	internal sealed class As3NameAttribute : Attribute {
		public As3NameAttribute(string pAs3Name) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = false)]
	internal sealed class As3NamespaceAttribute : Attribute {
		public As3NamespaceAttribute(string pAs3Namespace) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
	internal sealed class As3IsGenericAttribute : Attribute {
		public As3IsGenericAttribute(bool pIsGeneric) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal sealed class As3AsObject : Attribute {
		
	}
}

