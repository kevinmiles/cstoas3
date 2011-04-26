namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyCopyrightAttribute : Attribute {
		public AssemblyCopyrightAttribute(string title) {
		}
	}

}