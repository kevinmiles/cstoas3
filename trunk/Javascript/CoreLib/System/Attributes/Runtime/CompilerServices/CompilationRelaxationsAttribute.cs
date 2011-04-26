namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)
	, ComVisible(true)]
	public class CompilationRelaxationsAttribute : Attribute {
		private readonly int relax;

		public CompilationRelaxationsAttribute(int relaxations) {
			relax = relaxations;
		}

		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) {
			relax = (int) relaxations;
		}

		public int CompilationRelaxations {
			get {
				return relax;
			}
		}
	}
}