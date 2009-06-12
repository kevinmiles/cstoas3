namespace flash.utils {
	public interface IExternalizable {
		/// <summary>
		/// A class implements this method to decode itself from a data stream by calling the methods of the IDataInput interface.
		/// </summary>
		void readExternal(IDataInput input);

		/// <summary>
		/// A class implements this method to encode itself for a data stream by calling the methods of the IDataOutput interface.
		/// </summary>
		void writeExternal(IDataOutput output);
	}
}