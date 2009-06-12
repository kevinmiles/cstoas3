namespace flash.display {
	public enum StageQuality {
		/// <summary>
		/// Specifies low rendering quality: graphics are not anti-aliased, and bitmaps are not smoothed.
		/// </summary>
		LOW,
		/// <summary>
		/// Specifies medium rendering quality: graphics are anti-aliased using a 2 x 2 pixel grid, but bitmaps are not smoothed.
		/// </summary>
		MEDIUM,
		/// <summary>
		/// Specifies high rendering quality: graphics are anti-aliased using a 4 x 4 pixel grid, and bitmaps are smoothed if the movie is static.
		/// </summary>
		HIGH,
		/// <summary>
		/// Specifies very high rendering quality: graphics are anti-aliased using a 4 x 4 pixel grid and bitmaps are always smoothed.
		/// </summary>
		BEST
	}
}
