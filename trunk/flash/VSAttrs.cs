namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyVersionAttribute : Attribute {
		public AssemblyVersionAttribute(string version) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyProductAttribute : Attribute {
		public AssemblyProductAttribute(string product) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTitleAttribute : Attribute {
		public AssemblyTitleAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyDescriptionAttribute : Attribute {
		public AssemblyDescriptionAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyConfigurationAttribute : Attribute {
		public AssemblyConfigurationAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCompanyAttribute : Attribute {
		public AssemblyCompanyAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCopyrightAttribute : Attribute {
		public AssemblyCopyrightAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCultureAttribute : Attribute {
		public AssemblyCultureAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTrademarkAttribute : Attribute {
		public AssemblyTrademarkAttribute(string title) {}
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyFileVersionAttribute : Attribute {
		public AssemblyFileVersionAttribute(string title) {}
	}
}


namespace System.Runtime.CompilerServices {
	public sealed class CompilerGeneratedAttribute : Attribute {}

}


namespace System.Runtime.InteropServices {
	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface |
		AttributeTargets.Delegate)]
	public sealed class ComVisibleAttribute : Attribute {
		public ComVisibleAttribute(bool visibility) {}
	}

	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class GuidAttribute : Attribute {
		public GuidAttribute(string guid) {}
	}
}


namespace System.Runtime.Versioning {
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public sealed class TargetFrameworkAttribute : Attribute {
		public string FrameworkDisplayName;
		public TargetFrameworkAttribute(string pFVersion) {}
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