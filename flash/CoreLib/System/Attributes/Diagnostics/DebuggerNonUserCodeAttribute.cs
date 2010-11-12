namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method |
		AttributeTargets.Property, Inherited = false), ComVisible(true)] 
	 
	
	public sealed class DebuggerNonUserCodeAttribute : Attribute {}
}