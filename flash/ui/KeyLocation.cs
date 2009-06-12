namespace flash.ui {
	public enum KeyLocation {
		/// <summary>
		/// Indicates the key activated is in the left key location (there is more than one possible location for this key).
		/// </summary>
		LEFT ,

		/// <summary>
		/// Indicates the key activation originated on the numeric keypad or with a virtual key corresponding to the numeric keypad.
		/// </summary>
		NUM_PAD ,

		/// <summary>
		/// Indicates the key activated is in the right key location (there is more than one possible location for this key).
		/// </summary>
		RIGHT ,

		/// <summary>
		/// Indicates the key activation is not distinguished as the left or right version of the key, and did not originate on the numeric keypad (or did not originate with a virtual key corresponding to the numeric keypad).
		/// </summary>
		STANDARD
	}
}