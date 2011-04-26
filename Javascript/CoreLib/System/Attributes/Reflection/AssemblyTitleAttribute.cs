namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTitleAttribute : Attribute {
		public AssemblyTitleAttribute(string title) {
		}
	}

}