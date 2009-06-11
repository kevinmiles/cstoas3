namespace flash.filters {
	public class DropShadowFilter : BitmapFilter {
		/// <summary>
		/// The alpha transparency value for the shadow color.
		/// </summary>
		public float alpha;

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
		public uint color;

		/// <summary>
		/// The offset distance of the bevel.
		/// </summary>
		public float distance;

		/// <summary>
		/// Indicates whether or not the object is hidden.
		/// </summary>
		public bool hideObject;

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

		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY, float strength, int quality, bool inner, bool knockout, bool hideObject) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY, float strength, int quality, bool inner, bool knockout) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY, float strength, int quality, bool inner) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY, float strength, int quality) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY, float strength) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX, float blurY) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha, float blurX) {}
		public DropShadowFilter(float distance, float angle, uint color, float alpha) {}
		public DropShadowFilter(float distance, float angle, uint color) {}
		public DropShadowFilter(float distance, float angle) {}
		public DropShadowFilter(float distance) {}
		public DropShadowFilter() {}

	}
}
