namespace System.Runtime.CompilerServices {
	using InteropServices;

#if NET_2_0
	[ComVisible(true)]
	public static class IsVolatile {}
#else
	public sealed class IsVolatile {
		private IsVolatile ()
		{
		}
	}
#endif
}