namespace System.Runtime.CompilerServices {
	[AttributeUsage(AttributeTargets.Assembly)] 
	
	public sealed class DefaultDependencyAttribute : Attribute {
		private readonly LoadHint hint;

		public DefaultDependencyAttribute(LoadHint loadHintArgument) {
			hint = loadHintArgument;
		}

		public LoadHint LoadHint {
			get {
				return hint;
			}
		}
	}
}
