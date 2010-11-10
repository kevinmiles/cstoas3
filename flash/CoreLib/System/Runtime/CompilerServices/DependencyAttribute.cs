#if NET_2_0

namespace System.Runtime.CompilerServices {
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)] 
	
	public sealed class DependencyAttribute : Attribute {
		private readonly string dependentAssembly;
		private readonly LoadHint hint;

		public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument) {
			dependentAssembly = dependentAssemblyArgument;
			hint = loadHintArgument;
		}

		public string DependentAssembly {
			get {
				return dependentAssembly;
			}
		}

		public LoadHint LoadHint {
			get {
				return hint;
			}
		}
	}
}


#endif