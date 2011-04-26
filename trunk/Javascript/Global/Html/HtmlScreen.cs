namespace Javascript.Global {
	public class HtmlScreen {
		///<summary>
		///Retrieves the height of the working area of the system's screen, excluding the Microsoft Windows taskbar.
		///</summary>
		public int availHeight {
			get;
			set;
		}
		///<summary>
		///Retrieves the width of the working area of the system's screen, excluding the Windows taskbar.
		///</summary>
		public int availWidth {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the update interval for the screen.
		///</summary>
		public int updateInterval {
			get;
			set;
		}
		///<summary>
		///Retrieves whether the user has enabled font smoothing in the Display control panel. IE only.
		///</summary>
		public bool fontSmoothingEnabled {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the number of bits per pixel used for colors in the off-screen bitmap buffer. IE only.
		///</summary>
		public int bufferDepth {
			get;
			set;
		}
		///<summary>
		///The color depth (in bits) of the screen
		///</summary>
		public int colorDepth {
			get;
			set;
		}
		///<summary>
		///The color depth (in bits) of the screen. (Same as colorDepth)
		///</summary>
		public int pixelDepth {
			get;
			set;
		}
		///<summary>
		///The width of the screen
		///</summary>
		public int width {
			get;
			set;
		}
		///<summary>
		///The height of the screen
		///</summary>
		public int height {
			get;
			set;
		}
	}
}
