namespace flash.filters {
	using display;

	using geom;

	public class DisplacementMapFilter :BitmapFilter{
		public float alpha;
		public uint color;
		public uint componentX;
		public uint componentY;
		public BitmapData mapBitmap;
		public Point mapPoint;
		public DisplacementMapFilterMode mode;
		public float scaleX;
		public float scaleY;

		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY, float scaleX, float scaleY, DisplacementMapFilterMode mode, uint color, float alpha) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY, float scaleX, float scaleY, DisplacementMapFilterMode mode, uint color) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY, float scaleX, float scaleY, DisplacementMapFilterMode mode) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY, float scaleX, float scaleY) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY, float scaleX) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX, uint componentY) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint, uint componentX) {}
		public DisplacementMapFilter(BitmapData mapBitmap, Point mapPoint) {}
		public DisplacementMapFilter(BitmapData mapBitmap) {}
		public DisplacementMapFilter() {}

	}
}
