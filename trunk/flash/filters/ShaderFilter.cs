namespace flash.filters {
	using display;

	public class ShaderFilter : BitmapFilter {
		/// <summary>
		/// The growth in pixels on the bottom side of the target object
		/// </summary>
		public int bottomExtension;
		/// <summary>
		/// The growth in pixels on the left side of the target object.
		/// </summary>
		public int leftExtension;
		/// <summary>
		/// The growth in pixels on the right side of the target object.
		/// </summary>
		public int rightExtension;
		/// <summary>
		/// The growth in pixels on the top side of the target object.
		/// </summary>
		public int topExtension;
		/// <summary>
		/// The shader to use for this filter.
		/// </summary>
		public Shader shader;

		public ShaderFilter(Shader shader){}
		public ShaderFilter(){}
	}
}
