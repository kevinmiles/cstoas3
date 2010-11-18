namespace System {
	using ComponentModel;

	[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public struct Nullable<T> where T : struct {
		public Nullable(T value) {
			
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public bool HasValue {
			get {
				return true;
			}
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public T Value {
			get {
				return default(T);
			}
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public T GetValueOrDefault() {
			return default(T);
		}

		[Obsolete("Just for compatibility with C# compiler. DO NOT USE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public T GetValueOrDefault(T defaultValue) {
			return defaultValue;
		}

		//
		// These are called by the JIT
		//
#pragma warning disable 169
		//
		// JIT implementation of box valuetype System.Nullable`1<T>
		//
		static object Box(T? o) {
			return null;
		}

		static T? Unbox(object o) {
			if (o == null)
				return null;
			return (T)o;
		}
#pragma warning restore 169 
 
	}
}
