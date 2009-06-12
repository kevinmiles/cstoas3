namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
	internal sealed class As3NameAttribute : Attribute {
		public As3NameAttribute(string pAs3Name) {

		}
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	internal sealed class As3NamespaceAttribute : Attribute {
		public As3NamespaceAttribute(string pAs3Namespace) {

		}
	}

	[AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
	internal sealed class As3IsGenericAttribute : Attribute {
		public As3IsGenericAttribute(bool pIsGeneric) {

		}
	}

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	internal sealed class As3EventAttribute : Attribute {
		public As3EventAttribute(string eventName) {

		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal sealed class As3AsObject : Attribute {
		
	}
}