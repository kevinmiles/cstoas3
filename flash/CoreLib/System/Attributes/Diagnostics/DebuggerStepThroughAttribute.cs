namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method,
		Inherited = false), ComVisible(true)]
	
	
	public sealed class DebuggerStepThroughAttribute : Attribute {}
}