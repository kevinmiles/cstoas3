namespace flash.text {
	public class TextLineMetrics {
		/// <summary>
		/// The ascent value of the text is the length from the baseline to the top of the line height in pixels.
		/// </summary>
		public double ascent;

		/// <summary>
		/// The descent value of the text is the length from the baseline to the bottom depth of the line in pixels.
		/// </summary>
		public double descent;

		/// <summary>
		/// The height value of the text of the selected lines (not necessarily the complete text) in pixels.
		/// </summary>
		public double height;

		/// <summary>
		/// The leading value is the measurement of the vertical distance between the lines of text.
		/// </summary>
		public double leading;

		/// <summary>
		/// The width value is the width of the text of the selected lines (not necessarily the complete text) in pixels.
		/// </summary>
		public double width;

		/// <summary>
		/// The x value is the left position of the first character in pixels.
		/// </summary>
		public double x;

		public TextLineMetrics(double x, double width, double height, double ascent, double descent, double leading){}

	}
}