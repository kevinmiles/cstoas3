namespace flash.text {
	public enum AntiAliasType {
		/// <summary>
		/// Applies the regular text anti-aliasing. This value matches the type of anti-aliasing that Flash Player 7 and earlier versions used.
		/// </summary>
		NORMAL,
		/// <summary>
		/// Applies advanced anti-aliasing, which makes text more legible. (This feature became available in Flash Player 8.) Advanced anti-aliasing allows for high-quality rendering of font faces at small sizes. It is best used with applications with a lot of small text. Advanced anti-aliasing is not recommended for fonts that are larger than 48 points.
		/// </summary>
		ADVANCED 
	}
}
