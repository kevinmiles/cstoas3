namespace flash.geom {
	public class Vector3D {
		public readonly float length;
		public readonly float lengthSquared;
		public float w;
		public float x;
		public float y;
		public float z;

		public Vector3D(float x, float y, float z, float w){}
		public Vector3D(float x, float y, float z){}
		public Vector3D(float x, float y){}
		public Vector3D(float x){}
		public Vector3D(){}

		public Vector3D add(Vector3D a) {
			return this;
		}

		static public float angleBetween(Vector3D a, Vector3D b) {
			return 0;
		}

		public Vector3D clone() {
			return this;
		}

		public Vector3D crossProduct(Vector3D a) {
			return this;
		}

		public void decrementBy(Vector3D a){}

		static public float distance(Vector3D a, Vector3D b) {
			return 0;
		}

		public float dotProduct(Vector3D a) {
			return 0;
		}

		public bool equals(Vector3D a, bool allFour) {
			return false;
		}

		public bool equals(Vector3D a) {
			return false;
		}

		public void incrementBy(Vector3D a){}

		public bool nearEquals(Vector3D toCompare, float tolerance, bool allFour) {
			return false;
		}

		public bool nearEquals(Vector3D toCompare, float tolerance) {
			return false;
		}

		public void negate() {
		}

		public float normalize() {
			return 0;
		}

		public void project(){}

		public void scaleBy(float s){}

		public Vector3D subtract(Vector3D a) {
			return this;
		}

		public static Vector3D X_AXIS;
		public static Vector3D Y_AXIS;
		public static Vector3D Z_AXIS;
	}
}
