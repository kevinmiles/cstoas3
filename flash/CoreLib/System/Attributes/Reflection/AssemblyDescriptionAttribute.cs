namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyDescriptionAttribute : Attribute {
		public AssemblyDescriptionAttribute(string title) {
		}
	}

}