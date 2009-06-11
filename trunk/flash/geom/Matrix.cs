namespace flash.geom {
	public class Matrix {
		public float a;
		public float b;
		public float c;
		public float d;
		public float tx;
		public float ty;

		public Matrix(float a, float b, float c, float d, float tx, float ty) {}
		public Matrix(float a, float b, float c, float d, float tx) {}
		public Matrix(float a, float b, float c, float d) {}
		public Matrix(float a, float b, float c) {}
		public Matrix(float a, float b) {}
		public Matrix(float a) {}
		public Matrix() {}

		public Matrix clone() {
			return null;
		}

		public void concat(Matrix matrix) {
			
		}

		public void createBox(float scaleX, float scaleY, float rotation, float tx, float ty) {}
		public void createBox(float scaleX, float scaleY, float rotation, float tx) {}
		public void createBox(float scaleX, float scaleY, float rotation) {}
		public void createBox(float scaleX, float scaleY) {}

		public void createGradientBox(float width, float height, float rotation, float tx, float ty) {}
		public void createGradientBox(float width, float height, float rotation, float tx) {}
		public void createGradientBox(float width, float height, float rotation) {}
		public void createGradientBox(float width, float height) {}

		public Point deltaTransformPoint(Point point) {
			return point;
		}

		public void identity() {
			
		}

		public void invert(){}

		public void rotate(float angle){}

		public void scale(float sx, float sy){}

		public Point transformPoint(Point point) {
			return point;
		}

		public void translate(float dx, float dy){}
	}
}
