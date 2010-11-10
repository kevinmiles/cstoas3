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

		public bool AllowMultiple {
			get;
			set;
		}

		private bool _inherited = true;

		public bool Inherited {
			get {
				return _inherited = true;
			}
			set {
				_inherited = value;
			}
		}
	}

	[AttributeUsage(AttributeTargets.Enum)]
	public class FlagsAttribute : Attribute {

	}

	public sealed class ParamArrayAttribute : Attribute {
		public ParamArrayAttribute() {
			return;
		}
	}

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

namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyVersionAttribute : Attribute {
		public AssemblyVersionAttribute(string version) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyProductAttribute : Attribute {
		public AssemblyProductAttribute(string product) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTitleAttribute : Attribute {
		public AssemblyTitleAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyDescriptionAttribute : Attribute {
		public AssemblyDescriptionAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyConfigurationAttribute : Attribute {
		public AssemblyConfigurationAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCompanyAttribute : Attribute {
		public AssemblyCompanyAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCopyrightAttribute : Attribute {
		public AssemblyCopyrightAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCultureAttribute : Attribute {
		public AssemblyCultureAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTrademarkAttribute : Attribute {
		public AssemblyTrademarkAttribute(string title) {
		}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyFileVersionAttribute : Attribute {
		public AssemblyFileVersionAttribute(string title) {
		}
	}
}


namespace System.Runtime.InteropServices {
	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface |
		AttributeTargets.Delegate)]
	public sealed class ComVisibleAttribute : Attribute {
		public ComVisibleAttribute(bool visibility) {
		}
	}

	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class GuidAttribute : Attribute {
		public GuidAttribute(string guid) {
		}
	}
}


namespace System.Runtime.Versioning {
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public sealed class TargetFrameworkAttribute : Attribute {
		public string FrameworkDisplayName;
		public TargetFrameworkAttribute(string pFVersion) {
		}
	}
}


namespace System.ComponentModel {
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute {
		public static readonly BrowsableAttribute Default = new BrowsableAttribute(true);
		public static readonly BrowsableAttribute No = new BrowsableAttribute(false);
		public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);
		private readonly bool browsable;

		public BrowsableAttribute(bool browsable) {
			this.browsable = browsable;
		}

		public bool Browsable {
			get {
				return browsable;
			}
		}
	}
}


namespace System.ComponentModel {
	public enum EditorBrowsableState {
		/// <summary>
		/// 	The property or method is always browsable from within an editor.
		/// </summary>
		Always = 0,
		/// <summary>
		/// 	The property or method is never browsable from within an editor.
		/// </summary>
		Never = 1,
		/// <summary>
		/// 	The property or method is a feature that only advanced users should see. An editor can either show or hide such properties.
		/// </summary>
		Advanced = 2
	}

	[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Enum |
		AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method |
		AttributeTargets.Property | AttributeTargets.Struct)]
	public sealed class EditorBrowsableAttribute : Attribute {
		private readonly EditorBrowsableState state;

		public EditorBrowsableAttribute() {
			state = EditorBrowsableState.Always;
		}

		public EditorBrowsableAttribute(EditorBrowsableState state) {
			this.state = state;
		}

		public EditorBrowsableState State {
			get {
				return state;
			}
		}
	}
}