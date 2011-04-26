namespace System {
	using ComponentModel;

	public abstract class Delegate {

		///<summary>
		/// Calls a method of an object, substituting another object for the current object.
		///</summary>
		///<param name="thisObject">The object to be used as the current object.</param>
		///<param name="arguments">List of arguments to be passed to the method.</param>
		///<returns></returns>
		public object apply(object thisObject, object[] arguments) {
			return default(object);
		}

		public object apply(object thisObject, Array arguments) {
			return default(object);
		}

		/// <summary>
		/// Calls a method of an object, substituting another object for the current object.
		/// </summary>
		/// <returns></returns>
		public object call() {
			return default(object);
		}

		/// <summary>
		/// Calls a method of an object, substituting another object for the current object.
		/// </summary>
		/// <param name="thisArg">The object to be used as the current object.</param>
		/// <returns></returns>
		public object call(object thisArg) {
			return default(object);
		}

		/// <summary>
		/// Returns a reference to the function that invoked the current function.
		/// </summary>
		public Delegate caller {
			get;
			set;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		static public Delegate Combine(Delegate[] delegates) {
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		static public Delegate Combine(Delegate a, Delegate b) {
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public static Delegate Remove(Delegate source, Delegate value) {
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public static Delegate RemoveAll(Delegate source,Delegate value) {
			return null;
		}

		//public static implicit operator Function(Delegate pDelegate) {
		//    return new Function();
		//}

		//public static explicit operator Delegate(Function pFunction) {
		//    return new Delegate();
		//}
	}
}
