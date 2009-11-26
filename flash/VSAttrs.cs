namespace System.Reflection  {
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

namespace System.Runtime.CompilerServices {
	public sealed class CompilerGeneratedAttribute : Attribute {
		public CompilerGeneratedAttribute() {
		}
	} 
}

namespace System.Runtime.InteropServices {
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
		| AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Method | AttributeTargets.Property |
		AttributeTargets.Field | AttributeTargets.Interface |
		AttributeTargets.Delegate)] 
	public sealed class ComVisibleAttribute : Attribute {
		public ComVisibleAttribute(bool visibility) {

		}
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class |
			AttributeTargets.Struct | AttributeTargets.Enum |
			AttributeTargets.Interface | AttributeTargets.Delegate)] 
	public sealed class GuidAttribute : Attribute {

		public GuidAttribute(string guid) {

		}

	} 
}