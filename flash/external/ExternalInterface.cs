namespace flash.external {
	public static class ExternalInterface {
		/// <summary>
		/// Indicates whether this player is in a container that offers an external interface.
		/// </summary>
		public static readonly bool available;

		/// <summary>
		/// Indicates whether the external interface should attempt to pass ActionScript exceptions to the current browser and JavaScript exceptions to Flash Player.
		/// </summary>
		public static bool marshallExceptions {
			get;
			set;
		}

		/// <summary>
		/// Returns the id attribute of the object tag in Internet Explorer, or the name attribute of the embed tag in Netscape.
		/// </summary>
		public static readonly string objectID;

		/// <summary>
		/// Registers an ActionScript method as callable from the container.
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="closure"></param>
		public static void addCallback(string functionName, Function closure) {}

		/// <summary>
		/// Calls a function exposed by the Flash Player container, passing zero or more arguments.
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="arguments"></param>
		/// <returns></returns>
		public static object call(string functionName) {
			return default(object);
		}

		public static object call(string functionName, object arguments) {
			return default(object);
		}

		public static object call(string functionName, object arg0, object arg1) {
			return default(object);
		}

		public static object call(string functionName, object arg0, object arg1, object arg2) {
			return default(object);
		}

		public static object call(string functionName, object arg0, object arg1, object arg2, object arg3) {
			return default(object);
		}

		public static object call(string functionName, object arg0, object arg1, object arg2, object arg3, object arg4) {
			return default(object);
		}

		public static object call(string functionName, object arg0, object arg1, object arg2, object arg3, object arg4,
		                          object arg5) {
			return default(object);
		}
	}
}