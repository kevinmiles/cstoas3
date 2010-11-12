namespace System.Diagnostics {
	using Runtime.InteropServices;

	[ComVisible(true),
	 AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	 
	
	public sealed class DebuggerStepperBoundaryAttribute : Attribute {}
}