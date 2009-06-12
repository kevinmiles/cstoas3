namespace flash.display {
	public enum StageScaleMode {
		/// <summary>
		/// Specifies that the entire Adobe® Flash® application be visible in the specified area without trying to preserve the original aspect ratio.
		/// </summary>
		EXACT_FIT,

		/// <summary>
		/// Specifies that the entire Flash application fill the specified area, without distortion but possibly with some cropping, while maintaining the original aspect ratio of the application.
		/// </summary>
		NO_BORDER ,

		/// <summary>
		/// Specifies that the size of the Flash application be fixed, so that it remains unchanged even as the size of the player window changes.
		/// </summary>
		NO_SCALE ,

		/// <summary>
		/// Specifies that the entire Flash application be visible in the specified area without distortion while maintaining the original aspect ratio of the application.
		/// </summary>
		SHOW_ALL
	}
}