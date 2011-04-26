namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCultureAttribute : Attribute {
		public AssemblyCultureAttribute(string title) {
		}
	}

}