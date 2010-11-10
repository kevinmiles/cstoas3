namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface,
#if NET_2_0
		AllowMultiple = true,
#endif
		Inherited = false), ComVisible(true)]
#if NET_2_0
	
#endif
	public sealed class RequiredAttributeAttribute : Attribute {
		public RequiredAttributeAttribute(Type requiredContract) {}

		public Type RequiredContract {
			get {
				return null;
			}
		}
	}
}