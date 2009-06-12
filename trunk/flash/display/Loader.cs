namespace flash.display {
	using utils;

	public class Loader : DisplayObjectContainer {
		/// <summary>
		/// [read-only] Contains the root display object of the SWF file or image (JPG, PNG, or GIF) file that was loaded by using the load() or loadBytes() methods.
		/// </summary>
		public readonly DisplayObject content;

		/// <summary>
		/// [read-only] Returns a LoaderInfo object corresponding to the object being loaded.
		/// </summary>
		public readonly LoaderInfo contentLoaderInfo;

		/// <summary>
		/// Cancels a load() method operation that is currently in progress for the Loader instance.
		/// </summary>
		public void close() {}

		/// <summary>
		/// Loads a SWF, JPEG, progressive JPEG, unanimated GIF, or PNG file into an object that is a child of this Loader object.
		/// </summary>
		public void load(URLRequest request, LoaderContext context) {}

		/// <summary>
		/// Loads a SWF, JPEG, progressive JPEG, unanimated GIF, or PNG file into an object that is a child of this Loader object.
		/// </summary>
		public void load(URLRequest request) {}

		/// <summary>
		/// Loads from binary data stored in a ByteArray object.
		/// </summary>
		public void loadBytes(ByteArray bytes, LoaderContext context) {}

		/// <summary>
		/// Loads from binary data stored in a ByteArray object.
		/// </summary>
		public void loadBytes(ByteArray bytes) {}

		/// <summary>
		/// Removes a child of this Loader object that was loaded by using the load() method.
		/// </summary>
		public void unload() {}
	}
}