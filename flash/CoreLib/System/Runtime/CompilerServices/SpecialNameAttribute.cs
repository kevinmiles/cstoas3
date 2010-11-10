#if NET_2_0

namespace System.Runtime.CompilerServices {
	[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property |
		AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class SpecialNameAttribute : Attribute {}
}


#endif