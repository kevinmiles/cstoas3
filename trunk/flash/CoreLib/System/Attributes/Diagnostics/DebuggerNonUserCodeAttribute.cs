namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method |
		AttributeTargets.Property, Inherited = false), ComVisible(true)]


	internal sealed class DebuggerNonUserCodeAttribute : Attribute {
	}
}