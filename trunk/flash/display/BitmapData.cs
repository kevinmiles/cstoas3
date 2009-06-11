namespace flash.display {
	using filters;

	using geom;

	using Global;

	using utils;

	public class BitmapData : IBitmapDrawable {
		public readonly int height;
		public readonly int width;

		public readonly Rectangle rect;
		public readonly bool transparent;

		public BitmapData(int width, int height, bool transparent, uint fillColor) {}
		public BitmapData(int width, int height, bool transparent) {}
		public BitmapData(int width, int height) {}

		public void applyFilter(BitmapData sourceBitmapData, Rectangle sourceRectangle, Point destination, BitmapFilter filter) {
			
		}

		public BitmapData clone() {
			return null;
		}

		public void colorTransform(Rectangle rectangle, ColorTransform colorTransform) {
			
		}

		public object compare(BitmapData otherBitmapData) {
			return null;
		}

		public void copyChannel(BitmapData sourceBitmapData, Rectangle sourceRectangle, Point destination, BitmapDataChannel sourceChannel, BitmapDataChannel destinationChannel) {
			
		}

		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData, Point alphaPoint, bool mergeAlpha) {}
		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData, Point alphaPoint) {}
		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, BitmapData alphaBitmapData) {}
		public void copyPixels(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {}

		public void dispose() {
			
		}

		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode, Rectangle clipRect, bool smoothing) {}
		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode, Rectangle clipRect) {}
		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform, string blendMode) {}
		public void draw(IBitmapDrawable source, Matrix matrix, ColorTransform colorTransform) {}
		public void draw(IBitmapDrawable source, Matrix matrix) {}
		public void draw(IBitmapDrawable source) {}

		public void fillRect(Rectangle rectangle, uint color){}

		public void floodFill(int x, int y, uint color){}

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

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject, Point secondBitmapDataPoint, float secondAlphaThreshold) {
			return false;
		}

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject, Point secondBitmapDataPoint) {
			return false;
		}

		public bool hitTest(Point firstPoint, uint firstAlphaThreshold, object secondObject) {
			return false;
		}

		[As3Name("lock")]
		public void lockData(){
		
		}

		public void merge(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, uint redMultiplier, uint greenMultiplier, uint blueMultiplier, uint alphaMultiplier) {
			
		}

		public void noise(int randomSeed, uint low, uint high, BitmapDataChannel channelOptions, bool grayScale) {}
		public void noise(int randomSeed, uint low, uint high, BitmapDataChannel channelOptions) {}
		public void noise(int randomSeed, uint low, uint high) {}
		public void noise(int randomSeed, uint low) {}
		public void noise(int randomSeed) {}

		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, byte[] redArray, byte[] greenArray, byte[] blueArray, byte[] alphaArray) {}
		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, byte[] redArray, byte[] greenArray, byte[] blueArray) {}
		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, byte[] redArray, byte[] greenArray) {}
		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, byte[] redArray) {}
		public void paletteMap(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {}

		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise, BitmapDataChannel channelOptions, bool grayScale, int[] offsets) {}
		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise, BitmapDataChannel channelOptions, bool grayScale) {}
		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise, BitmapDataChannel channelOptions) {}
		public void perlinNoise(float baseX, float baseY, uint numOctaves, int randomSeed, bool stitch, bool fractalNoise) {}

		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed, int numPixels, uint fillColor) {return 0;}
		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed, int numPixels) {return 0;}
		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, int randomSeed) {return 0;}
		public int pixelDissolve(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint) {return 0;}

		public void scroll(int x, int y){}

		public void setPixel(int x, int y, uint color){}
		public void setPixel32(int x, int y, uint color) {
		}

		public void setPixels(Rectangle rectangle, ByteArray inputByteArray) {
			
		}

		public void setVector(Rectangle rectangle, Vector<uint> vector) {
			
		}

		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation, uint threshold, uint color, uint mask, bool copySource) {return 0;}
		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation, uint threshold, uint color, uint mask) {return 0;}
		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation, uint threshold, uint color) {return 0;}
		public uint threshold(BitmapData sourceBitmapData, Rectangle sourceRect, Point destPoint, string operation, uint threshold) {return 0;}

		public void unlock(Rectangle changeRect){}
		public void unlock(){}
	}
}
