namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyFileVersionAttribute : Attribute {
		public AssemblyFileVersionAttribute(string title) {
		}
	}

}