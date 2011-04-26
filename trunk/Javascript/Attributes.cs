namespace Javascript {
	using System;

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	public sealed class EventAttribute : Attribute {
		public EventAttribute(string eventName) {
		}
	}

	[AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
	public sealed class AsIntegerAttribute : Attribute {
		public AsIntegerAttribute() {
		}
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class NameAttribute : Attribute {
		public NameAttribute(string pAs3Name, string pAs3Imports) {
		}
		public NameAttribute(string pAs3Name, string pAs3RealName, string pAs3Imports) {
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class IsGenericAttribute : Attribute {
		public IsGenericAttribute(bool pIsGeneric) {
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class AsObjectAttribute : Attribute {
	}
}

