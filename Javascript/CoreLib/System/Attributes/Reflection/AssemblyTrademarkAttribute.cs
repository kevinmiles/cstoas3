namespace System.Reflection {
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class AssemblyTrademarkAttribute : Attribute {
		public AssemblyTrademarkAttribute(string title) {
		}
	}

}