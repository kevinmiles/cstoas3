namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Field), ComVisible(true)]
#if NET_2_0
	
#endif
	public sealed class AccessedThroughPropertyAttribute : Attribute {
		private readonly string name;

		public AccessedThroughPropertyAttribute(string propertyName) {
			name = propertyName;
		}

		public string PropertyName {
			get {
				return name;
			}
		}
	}
}