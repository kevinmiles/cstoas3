namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyConfigurationAttribute : Attribute {
		public AssemblyConfigurationAttribute(string title) {
		}
	}

}