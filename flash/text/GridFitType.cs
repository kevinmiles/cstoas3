namespace flash.text {
	public enum GridFitType {
        /// <summary>
        /// Specifies no grid fitting. Horizontal and vertical lines in the glyphs are not
        /// forced to the pixel grid. This setting is recommended for animation or for
        /// large font sizes.
        /// </summary>
		NONE ,
		/// <summary>
		/// Specifies that strong horizontal and vertical lines are fit to the pixel grid.
		/// This setting works only for left-aligned text fields. To use this setting, the
		/// AntiAliasType property of the text field must be set to AntiAliasType.ADVANCED
		/// . This setting generally provides the best legibility for left-aligned text. 
		/// </summary>
		PIXEL ,
		/// <summary>
		/// Specifies that strong horizontal and vertical lines are fit to the subpixel
		/// grid on an LCD monitor. To use this setting, the AntiAliasType property of the
		/// text field must be set to AntiAliasType.ADVANCED . The GridFitType.SUBPIXEL
		/// setting is often good for right-aligned or centered dynamic text, and it is
		/// sometimes a useful trade-off for animation versus text quality. 
		/// </summary>
		SUBPIXEL 
	}
}
