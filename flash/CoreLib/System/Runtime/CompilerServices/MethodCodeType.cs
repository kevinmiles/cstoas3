namespace System.Runtime.CompilerServices {
	using InteropServices;

#if !NET_2_0
[Flags]
#endif
#if NET_2_0
	[ComVisible(true)]
 
#endif
	public enum MethodCodeType {
		IL,
		Native,
		OPTIL,
		Runtime,
	}
}


// Namespace