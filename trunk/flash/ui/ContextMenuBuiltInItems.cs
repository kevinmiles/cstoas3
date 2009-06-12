namespace flash.ui {
	public sealed class ContextMenuBuiltInItems {
		/// <summary>
		/// Lets the user move forward or backward one frame in a SWF file at run time (does not appear for a single-frame SWF file).
		/// </summary>
		public bool forwardAndBack;

		/// <summary>
		/// Lets the user set a SWF file to start over automatically when it reaches the final frame (does not appear for a single-frame SWF file).
		/// </summary>
		public bool loop;

		/// <summary>
		/// Lets the user start a paused SWF file (does not appear for a single-frame SWF file).
		/// </summary>
		public bool play ;

		/// <summary>
		/// Lets the user send the displayed frame image to a printer.
		/// </summary>
		public bool print ;

		/// <summary>
		/// Lets the user set the resolution of the SWF file at run time.
		/// </summary>
		public bool quality ;

		/// <summary>
		/// Lets the user set a SWF file to play from the first frame when selected, at any time (does not appear for a single-frame SWF file).
		/// </summary>
		public bool rewind ;

		/// <summary>
		/// Lets the user with Shockmachine installed save a SWF file.
		/// </summary>
		public bool save ;

		/// <summary>
		/// Lets the user zoom in and out on a SWF file at run time.
		/// </summary>
		public bool zoom ;
	}
}