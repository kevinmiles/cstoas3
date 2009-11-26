namespace flash.display {
	using geom;

	public sealed class Graphics {
		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix, bool repeat, bool smooth) {
			return;
		}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix, bool repeat) {
			return;
		}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix) {
			return;
		}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap) {
			return;
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod, InterpolationMethod interpolationMethod, float focalPointRatio) {
			return;
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod, InterpolationMethod interpolationMethod) {
			return;
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod) {
			return;
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix) {
			return;
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios) {
			return;
		}

		/// <summary>
		/// Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
		/// </summary>
		public void clear() {
			return;
		}

		/// <summary>
		/// Specifies a simple one-color fill that Flash Player uses for subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		/// <param name="color"></param>
		/// <param name="alpha"></param>
		public void beginFill(uint color, float alpha) {
			return;
		}

		public void beginFill(uint color) {
			return;
		}

		/// <summary>
		/// Draws a circle.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="radius"></param>
		public void drawCircle(float x, float y, float radius) {
			return;
		}

		/// <summary>
		/// Draws a rectangle.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public void drawRect(float x, float y, float width, float height) {
			return;
		}

		/// <summary>
		/// Applies a fill to the lines and curves that were added since the last call to the beginFill(), beginGradientFill(), or beginBitmapFill() method.
		/// </summary>
		public void endFill() {
			return;
		}

		/// <summary>
		/// Specifies a line style that Flash uses for subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void lineStyle(float thickness, uint color, float alpha) {
			return;
		}

		/// <summary>
		/// Draws a line using the current line style from the current drawing position to (x, y); the current drawing position is then set to (x, y).
		/// </summary>
		public void lineTo(float x, float y) {
			return;
		}

		/// <summary>
		/// Moves the current drawing position to (x, y).
		/// </summary>
		public void moveTo(float x, float y) {
			return;
		}
	}
}