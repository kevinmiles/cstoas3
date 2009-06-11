namespace flash.desktop {
	public enum ClipboardTransferMode {
		/// <summary>
		/// The Clipboard object should only return a copy.
		/// </summary>
		CLONE_ONLY,

		/// <summary>
		/// The Clipboard object should return a copy if available and a reference if not.
		/// </summary>
		CLONE_PREFERRED,

		/// <summary>
		/// The Clipboard object should only return a reference.
		/// </summary>
		ORIGINAL_ONLY,

		/// <summary>
		/// The Clipboard object should return a reference if available and a copy if not.
		/// </summary>
		ORIGINAL_PREFERRED
	}
}
