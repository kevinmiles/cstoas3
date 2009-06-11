namespace flash.geom {
	using Global;

	public class Matrix3D {
		public readonly float determinant;
		public Vector3D position;
		public Vector<float> rawData;

		public Matrix3D(Vector<float> v){}
		public Matrix3D(){}

		public void append(Matrix3D lhs){}

		public void appendRotation(float degrees, Vector3D axis, Vector3D pivotPoint) {}
		public void appendRotation(float degrees, Vector3D axis) {}

		public void appendScale(float xScale, float yScale, float zScale) {}

		public void appendTranslation(float x, float y, float z){}

		public Matrix3D clone() {
			return this;
		}

		public Vector<Vector3D> decompose(Orientation3D orientationStyle) {return null;}
		public Vector<Vector3D> decompose() {return null;}

		public Vector3D deltaTransformVector(Vector3D v) {
			return v;
		}

		public void identity(){}

		static public Matrix3D interpolate(Matrix3D thisMat, Matrix3D toMat, float percent) {
			return thisMat;
		}

		public void interpolateTo(Matrix3D toMat, float percent) {
		}

		public bool invert() {
			return false;
		}

		public void pointAt(Vector3D pos, Vector3D at, Vector3D up){}
		public void pointAt(Vector3D pos, Vector3D at){}
		public void pointAt(Vector3D pos){}

		public void prepend(Vector3D rhs){}

		public void prependRotation(float degrees, Vector3D axis, Vector3D pivotPoint){}
		public void prependRotation(float degrees, Vector3D axis){}

		public void prependScale(float xScale, float yScale, float zScale){}

		public void prependTranslation(float x, float y, float z){}

		public bool recompose(Vector<Vector3D> components, Orientation3D orientationStyle) {return true;}
		public bool recompose(Vector<Vector3D> components) {return true;}

		public Vector3D transformVector(Vector3D v) {
			return v;
		}

		public void transformVectors(Vector<float> vin, Vector<float> vout){}

		public void transpose(){}

	}
}
