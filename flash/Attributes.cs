namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	public sealed class As3EventAttribute : Attribute {
		public As3EventAttribute(string eventName) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
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

namespace System {
	public abstract class Attribute {

	}

	[Flags]
	public enum AttributeTargets {
		Assembly = 0x00000001,
		Module = 0x00000002,
		Class = 0x00000004,
		Struct = 0x00000008,
		Enum = 0x00000010,
		Constructor = 0x00000020,
		Method = 0x00000040,
		Property = 0x00000080,
		Field = 0x00000100,
		Event = 0x00000200,
		Interface = 0x00000400,
		Parameter = 0x00000800,
		Delegate = 0x00001000,
		ReturnValue = 0x00002000,
		GenericParameter = 0x00004000,
		All = Assembly | Module | Class | Struct | Enum | Constructor |
			Method | Property | Field | Event | Interface | Parameter | Delegate | ReturnValue | GenericParameter
	}

	[AttributeUsage(AttributeTargets.Class)]
	public sealed class AttributeUsageAttribute : Attribute {
		public AttributeUsageAttribute(AttributeTargets validOn) {
			return;
		}

		public bool AllowMultiple;
	}

	[AttributeUsage(AttributeTargets.Enum)]
	public class FlagsAttribute : Attribute {

	}

	public sealed class ParamArrayAttribute : Attribute {
		public ParamArrayAttribute() {
			return;
		}
	}
}

namespace System.Reflection {
	sealed class DefaultMemberAttribute : Attribute {
		public DefaultMemberAttribute(string memberName) {
			return;
		}
	}
}

namespace System.Runtime.InteropServices {
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class OutAttribute : Attribute {

	}
}