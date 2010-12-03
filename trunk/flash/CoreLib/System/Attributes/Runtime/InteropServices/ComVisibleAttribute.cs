namespace System.Runtime.InteropServices {
	using System;

	[AttributeUsage(
		AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
		AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface |
		AttributeTargets.Delegate)]
	public sealed class ComVisibleAttribute : Attribute {
		public ComVisibleAttribute(bool visibility) {
		}
	}
}
