namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyVersionAttribute : Attribute {
		public AssemblyVersionAttribute(string version) {
		}
	}
}