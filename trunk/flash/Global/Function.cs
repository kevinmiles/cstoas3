namespace flash.Global {
	using System;

	public class Function {
		/// <summary>
		/// Specifies the value of thisObject to be used within any function that ActionScript calls.
		/// </summary>
		/// <param name="thisObject">An object that specifies the value of thisObject within the function body. </param>
		/// <param name="argArray"></param>
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
		/// <param name="thisObject">An object that specifies the value of thisObject within the function body. </param>
		/// <param name="arguments">The parameter or parameters to be passed to the function. You can specify zero or more parameters.</param>
		/// <returns></returns>
		public object call(object thisObject, params object[] arguments) {
			return null;
		}

		/// <summary>
		/// Invokes the function represented by a Function object.
		/// </summary>
		/// <param name="thisObject">An object that specifies the value of thisObject within the function body. </param>
		/// <returns></returns>
		public object call(object thisObject) {
			return null;
		}
	}
}