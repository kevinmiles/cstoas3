namespace flash.display {
	public class Bitmap : DisplayObject{
		/// <summary>
		/// The <see cref="BitmapData"/> object being referenced.
		/// </summary>
		public BitmapData bitmapData;

		/// <summary>
		/// Controls whether or not the Bitmap object is snapped to the nearest pixel.
		/// </summary>
		public PixelSnapping pixelSnapping;

		/// <summary>
		/// Controls whether or not the bitmap is smoothed when scaled.
		/// </summary>
		public bool smoothing;

		/// <summary>
		/// Initializes a Bitmap object to refer to the specified <see cref="BitmapData"/> object.
		/// </summary>
		/// <param name="bitmapData">The <see cref="BitmapData"/> object being referenced.</param>
		/// <param name="pixelSnapping">Whether or not the Bitmap object is snapped to the nearest pixel.</param>
		/// <param name="smoothing">Whether or not the bitmap is smoothed when scaled.</param>
		public Bitmap(BitmapData bitmapData, PixelSnapping pixelSnapping, bool smoothing) {
			return;
		}
		public Bitmap(BitmapData bitmapData, PixelSnapping pixelSnapping) {
			return;
		}
		public Bitmap(BitmapData bitmapData) {
			return;
		}
		public Bitmap() {
			return;
		}
	}
}
