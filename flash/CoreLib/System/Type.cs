
namespace System {
	using ComponentModel;

	using flash;
	[NameAttribute("createWithParameters", "(new {0}({1}))", "")]
	[NameAttribute("create", "(new {0}())", "")]
	[NameAttribute("getDefinitionByName", "flash.utils.getDefinitionByName")]
	[NameAttribute("getQualifiedClassName", "flash.utils.getQualifiedClassName")]
	public abstract class Type {
		public static object getDefinitionByName(string pName) {
			return null;
		}

		/// <summary>
		/// Returns the fully qualified class name of an object.
		/// </summary>
		/// <param name="pClass">The object for which a fully qualified class name is desired. Any ActionScript value may be passed to this method including all available ActionScript types, object instances, primitive types such as <c>uint</c>, and class objects.</param>
		/// <returns>A string containing the fully qualified class name.</returns>
		public static string getQualifiedClassName(object pClass) {
			return "";
		}

		public static object create(Type pClass) {
			return null;
		}

		public static object createWithParameters(Type pClass, params object[] pParams) {
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public static Type GetTypeFromHandle(RuntimeTypeHandle pHandle) {
			return null;
		}
	}
}
