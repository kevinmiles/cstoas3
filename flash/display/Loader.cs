namespace flash.display {
	using net;

	using system;

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
		public void close() {
			return;
		}

		/// <summary>
		/// Loads a SWF, JPEG, progressive JPEG, unanimated GIF, or PNG file into an object that is a child of this Loader object.
		/// </summary>
		public void load(URLRequest request, LoaderContext context) {
			return;
		}

		/// <summary>
		/// Loads a SWF, JPEG, progressive JPEG, unanimated GIF, or PNG file into an object that is a child of this Loader object.
		/// </summary>
		public void load(URLRequest request) {
			return;
		}

		/// <summary>
		/// Loads from binary data stored in a ByteArray object.
		/// </summary>
		public void loadBytes(ByteArray bytes, LoaderContext context) {
			return;
		}

		/// <summary>
		/// Loads from binary data stored in a ByteArray object.
		/// </summary>
		public void loadBytes(ByteArray bytes) {
			return;
		}

		/// <summary>
		/// Removes a child of this Loader object that was loaded by using the load() method.
		/// </summary>
		public void unload() {
			return;
		}
	}
}