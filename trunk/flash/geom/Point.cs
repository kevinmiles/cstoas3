namespace flash.geom {
	public class Point {
		/// <summary>
		/// The length of the line segment from (0,0) to this point.
		/// </summary>
		public readonly float length;

		/// <summary>
		/// The horizontal coordinate of the point.
		/// </summary>
		public float x;

		/// <summary>
		/// The vertical coordinate of the point.
		/// </summary>
		public float y;

		public Point(float x, float y) {}
		public Point(float x) {}
		public Point() {}

		/// <summary>
		/// Adds the coordinates of another point to the coordinates of this point to create a new point.
		/// </summary>
		/// <param name="point">The point to be added.</param>
		/// <returns>The new point.</returns>
		public Point add(Point point) {
			return null;
		}

		/// <summary>
		/// Creates a copy of this Point object.
		/// </summary>
		/// <returns></returns>
		public Point clone() {
			return null;
		}

		static public float distance(Point point1, Point point2) {
			return 0;
		}

		public bool equals(Point point) {
			return false;
		}

		static public Point interpolate(Point point1, Point point2) {
			return null;
		}

		public void normalize(float thickness) {
			
		}

		public void offset(float dx, float dy) {
			
		}

		public static Point polar(float len, float angle) {
			return null;
		}

		public Point subtract(Point point) {
			return null;
		}



	}
}
