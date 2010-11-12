namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCompanyAttribute : Attribute {
		public AssemblyCompanyAttribute(string title) {
		}
	}

}