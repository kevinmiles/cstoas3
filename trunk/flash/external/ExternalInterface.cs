namespace flash.external {
	using System;

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


		public delegate object ExternalInterfaceCallback(params object[] arguments);

		/// <summary>
		/// Registers an ActionScript method as callable from the container.
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="callBack"></param>
		public static void addCallback(string functionName, ExternalInterfaceCallback callBack) {
		}

		/// <summary>
		/// Calls a function exposed by the Flash Player container, passing zero or more arguments.
		/// </summary>
		/// <param name="functionName"></param>
		/// <param name="arguments"></param>
		/// <returns></returns>
		public static object call(string functionName, params object[] arguments) {
			return default(object);
		}

		/// <summary>
		/// Calls a function exposed by the Flash Player container, passing zero or more arguments.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		public static object call(string functionName) {
			return default(object);
		}
	}
}
