#if NET_2_0

namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Struct, Inherited = true), ComVisible(true)] 
	public sealed class NativeCppClassAttribute : Attribute {}
}


#endif