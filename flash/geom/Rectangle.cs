namespace flash.geom {
	public class Rectangle {
		public float bottom;
		public Point bottomRight;
		public float height;
		public float left;
		public float right;
		public Point size;
		public float top;
		public Point topLeft;
		public float width;
		public float x;
		public float y;

		public Rectangle(float x, float y, float width, float height) {}
		public Rectangle(float x, float y, float width) {}
		public Rectangle(float x, float y) {}
		public Rectangle(float x) {}
		public Rectangle() {}

		public Rectangle clone() {
			return null;
		}

		public bool contains(float x, float y) {
			return false;
		}

		public bool containsPoint(Point point) {
			return false;
		}

		public bool containsRect(Rectangle rectangle) {
			return false;
		}

		public bool equals(Rectangle rectangle) {
			return false;
		}

		public void inflate(float dx, float dy) {
			
		}

		public void inflatePoint(Point point){}

		public Rectangle intersection(Rectangle rectangle) {
			return null;
		}

		public bool intersects(Rectangle rectangle) {
			return false;
		}

		public bool isEmpty() {
			return false;
		}

		public void offset(float dx, float dy) {
			
		}

		public void offsetPoint(Point point){}

		public void setEmpty() {}

		public Rectangle union(Rectangle rectangle) {
			return null;
		}
	}
}
