namespace flash.geom {
	using display;

	public class Transform {
		public ColorTransform colorTransform;
		public readonly ColorTransform concatenatedColorTransform;
		public readonly Matrix concatenatedMatrix;
		public Matrix matrix;
		public Matrix3D matrix3D;
		public PerspectiveProjection perspectiveProjection;
		public Rectangle pixelBounds;

		public Matrix3D getRelativeMatrix3D(DisplayObject relativeTo) {
			return null;
		}
	}
}
