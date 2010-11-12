namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false),
	 ComVisible(true)]
	
	
	public sealed class DebuggerHiddenAttribute : Attribute {}
}