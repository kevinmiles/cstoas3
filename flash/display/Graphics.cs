namespace flash.display {
	using geom;

	public sealed class Graphics {
		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix, bool repeat, bool smooth) {}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix, bool repeat) {}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap, Matrix matrix) {}

		/// <summary>
		/// Fills a drawing area with a bitmap image.
		/// </summary>
		public void beginBitmapFill(BitmapData bitmap) {}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod, InterpolationMethod interpolationMethod, float focalPointRatio) {
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod, InterpolationMethod interpolationMethod) {
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix,
									  SpreadMethod spreadMethod) {
		}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios, Matrix matrix) {}

		/// <summary>
		/// Specifies a gradient fill used by subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void beginGradientFill(string type, uint[] colors, float[] alphas, int[] ratios) {}

		#region Constructors
		#endregion

		/// <summary>
		/// Clears the graphics that were drawn to this Graphics object, and resets fill and line style settings.
		/// </summary>
		public void clear() {}

		/// <summary>
		/// Specifies a simple one-color fill that Flash Player uses for subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		/// <param name="color"></param>
		/// <param name="alpha"></param>
		public void beginFill(uint color, float alpha) {}

		public void beginFill(uint color) {}

		/// <summary>
		/// Draws a circle.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="radius"></param>
		public void drawCircle(float x, float y, float radius) {}

		/// <summary>
		/// Draws a rectangle.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public void drawRect(float x, float y, float width, float height) {}

		/// <summary>
		/// Applies a fill to the lines and curves that were added since the last call to the beginFill(), beginGradientFill(), or beginBitmapFill() method.
		/// </summary>
		public void endFill() {}

		/// <summary>
		/// Specifies a line style that Flash uses for subsequent calls to other Graphics methods (such as lineTo() or drawCircle()) for the object.
		/// </summary>
		public void lineStyle(float thickness, uint color, float alpha) {}

		/// <summary>
		/// Draws a line using the current line style from the current drawing position to (x, y); the current drawing position is then set to (x, y).
		/// </summary>
		public void lineTo(float x, float y) {}

		/// <summary>
		/// Moves the current drawing position to (x, y).
		/// </summary>
		public void moveTo(float x, float y) {}
	}
}