namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyProductAttribute : Attribute {
		public AssemblyProductAttribute(string product) {
		}
	}

}