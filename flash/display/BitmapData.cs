namespace flash.display {
	using filters;

	using geom;

	using Global;

	using utils;

	[As3Name("lockData","lock","")]
	public class BitmapData : IBitmapDrawable {
		public readonly int height;

		public readonly Rectangle rect;
		public readonly bool transparent;
		public readonly int width;

		public BitmapData(int width, int height, bool transparent, uint fillColor) {
			return;
		}
		public BitmapData(int width, int height, bool transparent) {
			return;
		}
		public BitmapData(int width, int height) {
			return;
		}

		public void applyFilter(BitmapData sourceBitmapData, Rectangle sourceRectangle, Point destination, BitmapFilter filter) {
			return;
		}

		public BitmapData clone() {
			return null;
		}

		public void colorTransform(Rectangle rectangle, ColorTransform colorTransform) {
			return;
		}

		public object compare(BitmapData otherBitmapData) {
			return null;
		}

		public void copyChannel(BitmapData sourceBitmapData, Rectangle sourceRectangle, Point destination,
		                        BitmapDataChannel sourceChannel, BitmapDataChannel destinationChannel) {
			return;
		}

		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData,
		                       Point alphaPoint, bool mergeAlpha) {
			return;
		}

		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData,
		                       Point alphaPoint) {
			return;
		}

		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData) {
			return;
		}

		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {
			return;
		}

		public void dispose() {
			return;
		}

		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode,
		                 Rectangle clipRect, bool smoothing) {
			return;
		}

		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode,
		                 Rectangle clipRect) {
			return;
		}

		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode) {
			return;
		}

		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform) {
			return;
		}

		public void draw(IBitmapDrawable source, Matrix matrix) {
			return;
		}

		public void draw(IBitmapDrawable source) {
			return;
		}

		public void fillRect(Rectangle rectangle, uint color) {
			return;
		}

		public void floodFill(int x, int y, uint color) {
			return;
		}

		public Rectangle generateFilterRect(Rectangle source, BitmapFilter filter) {
			return source;
		}

		public Rectangle getColorBoundsRect(uint mask, uint color, bool findColor) {
			return null;
		}

		public Rectangle getColorBoundsRect(uint mask, uint color) {
			return null;
		}

		public uint getPixel(int x, int y) {
			return 0;
		}

		public uint getPixel32(int x, int y) {
			return 0;
		}

		public ByteArray getPixels(Rectangle rectangle) {
			return null;
		}

		public Vector<uint> getVector(Rectangle rectangle) {
			return null;
		}

		public Vector<float> histogram(Rectangle rectangle) {
			return null;
		}

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject, Point secondBitmapDataPoint,
		                    float secondAlphaThreshold) {
			return false;
		}

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject, Point secondBitmapDataPoint) {
			return false;
		}

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject) {
			return false;
		}

		public void lockData() {
			return;
		}

		public void merge(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, uint redMultiplier,
		                  uint greenMultiplier, uint blueMultiplier, uint alphaMultiplier) {
			return;
		}

		public void noise(int randomSeed, uint low, uint high, BitmapDataChannel channelOptions, bool grayScale) {
			return;
		}

		public void noise(int randomSeed, uint low, uint high, BitmapDataChannel channelOptions) {
			return;
		}

		public void noise(int randomSeed, uint low, uint high) {
			return;
		}

		public void noise(int randomSeed, uint low) {
			return;
		}

		public void noise(int randomSeed) {
			return;
		}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, ByteArray redArray,
		                       ByteArray greenArray, ByteArray blueArray, ByteArray alphaArray) {
			return;
		}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, ByteArray redArray,
		                       ByteArray greenArray, ByteArray blueArray) {
			return;
		}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, ByteArray redArray,
		                       ByteArray greenArray) {
			return;
		}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, ByteArray redArray) {
			return;
		}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {
			return;
		}

		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise,
		                        BitmapDataChannel channelOptions, bool grayScale, int[] offsets) {
			return;
		}

		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise,
		                        BitmapDataChannel channelOptions, bool grayScale) {
			return;
		}

		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise,
		                        BitmapDataChannel channelOptions) {
			return;
		}

		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise) {
			return;
		}

		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed,
		                         int numPixels, uint fillColor) {
			return 0;
		}

		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed,
		                         int numPixels) {
			return 0;
		}

		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed) {
			return 0;
		}

		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {
			return 0;
		}

		public void scroll(int x, int y) {
			return;
		}

		public void setPixel(int x, int y, uint color) {
			return;
		}

		public void setPixel32(int x, int y, uint color) {
			return;
		}

		public void setPixels(Rectangle rectangle, ByteArray inputByteArray) {
			return;
		}

		public void setVector(Rectangle rectangle, Vector<uint> vector) {
			return;
		}

		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation,
		                      uint threshold, uint color, uint mask, bool copySource) {
			return 0;
		}

		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation,
		                      uint threshold, uint color, uint mask) {
			return 0;
		}

		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation,
		                      uint threshold, uint color) {
			return 0;
		}

		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation,
		                      uint threshold) {
			return 0;
		}

		public void unlock(Rectangle changeRect) {
			return;
		}

		public void unlock() {
			return;
		}
	}
}