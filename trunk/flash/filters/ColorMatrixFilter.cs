namespace flash.filters {
	public class ColorMatrixFilter :BitmapFilter {
		/// <summary>
		/// An array of 20 items for 4 x 5 color transform.
		/// </summary>
		public float[] matrix;

		public ColorMatrixFilter(){}
		public ColorMatrixFilter(float[] matrix) {
		}
	}
}
