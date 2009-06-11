namespace flash.net {
	public interface IDynamicPropertyWriter {
		/// <summary>
		/// Writes the name and value of an <see cref="IDynamicPropertyOutput"/> object to an object with dynamic properties.
		/// </summary>
		/// <param name="pObject">The object to write to.</param>
		/// <param name="pOutput">The <see cref="IDynamicPropertyOutput"/> object that contains the name and value to dynamically write to the object.</param>
		void writeDynamicProperties(object pObject, IDynamicPropertyOutput pOutput);
	}
}
