#if NET_2_0

namespace System.Runtime.CompilerServices {
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FixedBufferAttribute : Attribute {
		private readonly Type elementType;
		private readonly int length;

		public FixedBufferAttribute(Type elementType, int length) {
			this.elementType = elementType;
			this.length = length;
		}

		public Type ElementType {
			get {
				return elementType;
			}
		}

		public int Length {
			get {
				return length;
			}
		}
	}
}


#endif