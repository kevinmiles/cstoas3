namespace flash.desktop {
	using Global;

	public class Clipboard {

		/// <summary>
		/// An array of strings containing the names of the data formats available in this Clipboard object.
		/// </summary>
		public readonly string[] formats;

		/// <summary>
		/// The operating system clipboard.
		/// </summary>
		public static readonly Clipboard generalClipboard;

		/// <summary>
		/// Deletes all data representations from this Clipboard object.
		/// </summary>
		public void clear() {
			
		}

		/// <summary>
		/// Deletes the data representation for the specified format.
		/// </summary>
		/// <param name="pFormat">The data format to remove.</param>
		public void clearData(ClipboardFormats pFormat) {
		}

		/// <summary>
		/// Gets the clipboard data if data in the specified format is present. Flash Player requires a user event (such as a key press or mouse click) before using getData() . Call getData() within a user initiated paste event handler. In AIR, this restriction only applies to content outside of the application security sandbox. 
		/// </summary>
		/// <param name="pFormat">The data format to return</param>
		/// <param name="pTransferMode">Specifies whether to return a reference or serialized copy when an application-defined data format is accessed.</param>
		/// <returns>An object of the type corresponding to the data format.</returns>
		/// <exception cref="Error">transferMode is not one of the names defined in the <see cref="ClipboardTransferMode"/> class.</exception>
		/// <exception cref="IllegalOperationError">The Clipboard object requested is no longer in scope (AIR only).</exception>
		/// <exception cref="SecurityError">Reading from or writing to the clipboard is not permitted in this context. In Flash Player, you can only call this method successfully during the processing of a user event (as in a key press or mouse click). In AIR, this restriction only applies to content outside of the application security sandbox.</exception>
		public object getData(ClipboardFormats pFormat, ClipboardTransferMode pTransferMode) {
			return null;
		}

		/// <summary>
		/// Checks whether data in the specified format exists in this Clipboard object. 
		/// </summary>
		/// <param name="pFormat">The format type to check.</param>
		/// <returns> true , if data in the specified format is present.</returns>
		/// <exception cref="IllegalOperationError">The Clipboard object requested is no longer in scope (AIR only).</exception>
		/// <exception cref="SecurityError">Reading from or writing to the clipboard is not permitted in this context.</exception>
		public bool hasFormat(ClipboardFormats pFormat) {
			return false;
		}

		/// <summary>
		/// Adds a representation of the information to be transferred in the specified data format. Flash Player requires a user event (such as a key press or mouse click) before using setData() . In AIR, this restriction only applies to content outside of the application security sandbox. 
		/// </summary>
		/// <param name="pFormat">The information to add.</param>
		/// <param name="pData">The format of the data.</param>
		/// <param name="pSerializable">Specify true for objects that can be serialized (and deserialized).</param>
		/// <returns>true if the data was successfully set; false otherwise. In Flash Player, returns false when format is an unsupported member of <see cref="ClipboardFormats"/>. (Flash Player does not support <see cref="ClipboardFormats"/>.URL_FORMAT , <see cref="ClipboardFormats"/>.FILE_LIST_FORMAT , or <see cref="ClipboardFormats"/>.BITMAP_FORMAT ).</returns>
		/// <exception cref=" IllegalOperationError">The Clipboard object requested is no longer in scope (AIR only).</exception>
		/// <exception cref="SecurityError">Reading from or writing to the clipboard is not permitted in this context. In Flash Player, you can only call this method successfully during the processing of a user event (as in a key press or mouse click). In AIR, this restriction only applies to content outside of the application security sandbox.</exception>
		/// <exception cref="TypeError">format or data is null.</exception>
		public bool setData(ClipboardFormats pFormat, object pData, bool pSerializable) {
			return false;
		}

		public delegate object ClipboardHandler();


		/// <summary>
		/// Adds a reference to a handler function that produces the data for the specified format on demand. Use this method to defer creation or rendering of the data until it is actually accessed. Flash Player requires a user event (such as a key press or mouse click) before using setDataHandler() . In AIR, this restriction only applies to content outside of the application security sandbox.
		/// </summary>
		/// <param name="pFormat">A function that returns the data to be transferred when called.</param>
		/// <param name="pHandler"></param>
		/// <param name="pSerializable">Specify true if the object returned by handler can be serialized (and deserialized).</param>
		/// <returns>true if the handler was successfully set; false otherwise.</returns>
		/// <exception cref="TypeError">format or handler is null.</exception>
		/// <exception cref="IllegalOperationError">The Clipboard object requested is no longer in scope (AIR only).</exception>
		/// <exception cref="SecurityError">Reading from or writing to the clipboard is not permitted in this context. In Flash Player, you can only call this method successfully during the processing of a user event (such as a key press or mouse click). In AIR, this restriction only applies to content outside of the application security sandbox.</exception>
		public bool setDataHandler(ClipboardFormats pFormat, ClipboardHandler pHandler, bool pSerializable) {
			return false;
		}


	}
}
