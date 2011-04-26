namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface,
		AllowMultiple = true,
		Inherited = false), ComVisible(true)]
	public sealed class RequiredAttributeAttribute : Attribute {
		public RequiredAttributeAttribute(Type requiredContract) {}

		public Type RequiredContract {
			get {
				return null;
			}
		}
	}
}