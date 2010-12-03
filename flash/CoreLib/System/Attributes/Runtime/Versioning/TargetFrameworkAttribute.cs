namespace System.Runtime.Versioning {
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public sealed class TargetFrameworkAttribute : Attribute {
		public string FrameworkDisplayName;
		public TargetFrameworkAttribute(string pFVersion) {
		}
	}
}
