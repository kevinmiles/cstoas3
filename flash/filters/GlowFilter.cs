namespace flash.filters {
	public class GlowFilter : BitmapFilter {
		/// <summary>
		/// The alpha transparency value for the shadow color.
		/// </summary>
		public float alpha;

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
		public uint color;

		/// <summary>
		/// Indicates whether or not the shadow is an inner shadow.
		/// </summary>
		public bool inner;

		/// <summary>
		/// Applies a knockout effect (true), which effectively makes the object's fill transparent and reveals the background color of the document.
		/// </summary>
		public bool knockout;

		/// <summary>
		/// The number of times to apply the filter.
		/// </summary>
		public int quality;

		/// <summary>
		/// The strength of the imprint or spread.
		/// </summary>
		public float strength;

		public GlowFilter(uint color, uint alpha, uint blurX, uint blurY, float strength, int quality, bool inner, bool knockout) {}
		public GlowFilter(uint color, uint alpha, uint blurX, uint blurY, float strength, int quality, bool inner) {}
		public GlowFilter(uint color, uint alpha, uint blurX, uint blurY, float strength, int quality) {}
		public GlowFilter(uint color, uint alpha, uint blurX, uint blurY, float strength) {}
		public GlowFilter(uint color, uint alpha, uint blurX, uint blurY) {}
		public GlowFilter(uint color, uint alpha, uint blurX) {}
		public GlowFilter(uint color, uint alpha) {}
		public GlowFilter(uint color) {}
		public GlowFilter() {}

	}
}
