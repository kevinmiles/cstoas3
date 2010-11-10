namespace System.Runtime.CompilerServices {
	using InteropServices;

#if NET_2_0
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)
	, ComVisible(true)]
#else
	[AttributeUsage (AttributeTargets.Module)]
#endif
	
	public class CompilationRelaxationsAttribute : Attribute {
		private readonly int relax;

		public CompilationRelaxationsAttribute(int relaxations) {
			relax = relaxations;
		}

#if NET_2_0
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) {
			relax = (int) relaxations;
		}
#endif

		public int CompilationRelaxations {
			get {
				return relax;
			}
		}
	}
}