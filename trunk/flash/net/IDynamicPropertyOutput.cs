namespace flash.net {
	using Global;

	public interface IDynamicPropertyOutput {
		/// <summary>
		/// Adds a dynamic property to the binary output of a serialized object.
		/// </summary>
		/// <param name="pName">The name of the property. You can use this parameter either to specify the name of an existing property of the dynamic object or to create a new property.</param>
		/// <param name="pValue">The value to write to the specified property.</param>
		void writeDynamicProperty(string pName, Untyped pValue);
	}
}
