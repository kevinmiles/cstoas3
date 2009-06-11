namespace flash.filters {
	public class ConvolutionFilter : BitmapFilter{
		/// <summary>
		/// The alpha transparency value of the substitute color.
		/// </summary>
		public float alpha;
		/// <summary>
		/// The amount of bias to add to the result of the matrix transformation
		/// </summary>
		public float bias;
		/// <summary>
		/// Indicates whether the image should be clamped.
		/// </summary>
		public bool clamp;
		/// <summary>
		/// The hexadecimal color to substitute for pixels that are off the source image.
		/// </summary>
		public uint color;
		/// <summary>
		/// The divisor used during matrix transformation.
		/// </summary>
		public float divisor;
		/// <summary>
		/// An array of values used for matrix transformation.
		/// </summary>
		public float[] matrix;
		/// <summary>
		/// The x dimension of the matrix (the number of columns in the matrix).
		/// </summary>
		public float matrixX;
		/// <summary>
		/// The y dimension of the matrix (the number of rows in the matrix).
		/// </summary>
		public float matrixY;
		/// <summary>
		/// Indicates if the alpha channel is preserved without the filter effect or if the convolution filter is applied to the alpha channel as well as the color channels.
		/// </summary>
		public bool preserveAlpha;

		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor, float bias, bool preserveAlpha, bool clamp, uint color, float alpha){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor, float bias, bool preserveAlpha, bool clamp, uint color){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor, float bias, bool preserveAlpha, bool clamp){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor, float bias, bool preserveAlpha){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor, float bias){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix, float divisor){}
		public ConvolutionFilter(float matrixX, float matrixY, float[] matrix){}
		public ConvolutionFilter(float matrixX, float matrixY){}
		public ConvolutionFilter(float matrixX){}
		public ConvolutionFilter(){}
	}
}
