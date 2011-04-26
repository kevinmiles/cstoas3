namespace System.Runtime.InteropServices {
	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class GuidAttribute : Attribute {
		public GuidAttribute(string guid) {
		}
	}
}