namespace System.Runtime.CompilerServices {
	[AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class TypeForwardedToAttribute : Attribute {
		private readonly Type destination;

		public TypeForwardedToAttribute(Type destination) {
			this.destination = destination;
		}

		public Type Destination {
			get {
				return destination;
			}
		}
	}
}