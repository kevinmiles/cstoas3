namespace System {
	using ComponentModel;

	public abstract class Delegate {
		/// <summary>
		/// Specifies the value of <paramref name="thisObject"/> to be used within any function that ActionScript calls.
		/// </summary>
		/// <param name="thisObject">An object that specifies the value of <paramref name="thisObject"/> within the function body. </param>
		/// <param name="arguments"></param>
		/// <returns></returns>
		public object apply(object thisObject, object[] arguments) {
			return default(object);
		}

		public object apply(object thisObject, Array arguments) {
			return default(object);
		}

		/// <summary>
		/// Invokes the function represented by a Function object.
		/// </summary>
		/// <param name="thisObject">An object that specifies the value of <paramref name="thisObject"/> within the function body. </param>
		/// <param name="arguments">The parameter or parameters to be passed to the function. You can specify zero or more parameters.</param>
		/// <returns></returns>
		public object call(object thisObject, params object[] arguments) {
			return null;
		}

		/// <summary>
		/// Invokes the function represented by a Function object.
		/// </summary>
		/// <param name="thisObject">An object that specifies the value of <paramref name="thisObject"/> within the function body. </param>
		/// <returns></returns>
		public object call(object thisObject) {
			return null;
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
