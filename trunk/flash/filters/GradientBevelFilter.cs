namespace flash.filters {
	public class GradientBevelFilter : BitmapFilter{
		/// <summary>
		/// The alpha transparency value for the shadow color.
		/// </summary>
		public float[] alphas;

		/// <summary>
		/// The angle of the bevel.
		/// </summary>
		public float angle;

		/// <summary>
		/// The amount of horizontal blur, in pixels.
		/// </summary>
		public float blurX;

		/// <summary>
		/// The amount of vertical blur, in pixels.
		/// </summary>
		public float blurY;

		/// <summary>
		/// The color of the shadow.
		/// </summary>
		public uint[] colors;

		/// <summary>
		/// The offset distance of the bevel.
		/// </summary>
		public float distance;

		/// <summary>
		/// Applies a knockout effect (true), which effectively makes the object's fill transparent and reveals the background color of the document.
		/// </summary>
		public bool knockout;

		/// <summary>
		/// The number of times to apply the filter.
		/// </summary>
		public int quality;

		/// <summary>
		/// An array of color distribution ratios for the corresponding colors in the colors array.
		/// </summary>
		public byte[] ratios;

		/// <summary>
		/// The strength of the imprint or spread.
		/// </summary>
		public float strength;

		public BitmapFilterType type;

		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX, float blurY, float strength, int quality, BitmapFilterType type, bool knockout) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX, float blurY, float strength, int quality, BitmapFilterType type) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX, float blurY, float strength, int quality) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX, float blurY, float strength) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX, float blurY) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios, float blurX) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas, byte[] ratios) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors, float[] alphas) {}
		public GradientBevelFilter(float distance, float angle, uint[] colors) {}
		public GradientBevelFilter(float distance, float angle) {}
		public GradientBevelFilter(float distance) {}
		public GradientBevelFilter() {}

	}
}
