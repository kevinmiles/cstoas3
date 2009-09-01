namespace flash.Global {
	public static class Reflection {
		[As3Name("getDefinitionByName")]
		[As3Namespace("flash.utils.getDefinitionByName")]
		public static object getDefinitionByName(string pName) {
			return null;
		}

		/// <summary>
		/// Returns the fully qualified class name of an object.
		/// </summary>
		/// <param name="pClass">The object for which a fully qualified class name is desired. Any ActionScript value may be passed to this method including all available ActionScript types, object instances, primitive types such as <c>uint</c>, and class objects.</param>
		/// <returns>A string containing the fully qualified class name.</returns>
		[As3Name("getQualifiedClassName")]
		[As3Namespace("flash.utils.getQualifiedClassName")]
		public static string getQualifiedClassName(object pClass) {
			return "";
		}

		[As3Name("(new {0}())")]
		public static object create(Class pClass) {
			return null;
		}

		[As3Name("(new {0}({1}))")]
		public static object create(Class pClass, params object[] pParams) {
			return null;
		}
	}
}
