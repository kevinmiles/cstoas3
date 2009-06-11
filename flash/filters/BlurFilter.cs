namespace flash.filters {
	public class BlurFilter : BitmapFilter{
		/// <summary>
		/// The number of times to apply the filter.
		/// </summary>
		public int quality;

		/// <summary>
		/// The amount of horizontal blur, in pixels.
		/// </summary>
		public float blurX;

		/// <summary>
		/// The amount of vertical blur, in pixels.
		/// </summary>
		public float blurY;

		public BlurFilter(float blurX, float blurY, int quality) {}
		public BlurFilter(float blurX, float blurY) {}
		public BlurFilter(float blurX) {}
		public BlurFilter() {}
	}
}
