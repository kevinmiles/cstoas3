namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Struct, Inherited = true), ComVisible(true)] 
	public sealed class NativeCppClassAttribute : Attribute {}
}
