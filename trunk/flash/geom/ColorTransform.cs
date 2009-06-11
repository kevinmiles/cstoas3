namespace flash.geom {
	public class ColorTransform {
		public float alphaMultiplier;
		public float alphaOffset;
		public float blueMultiplier;
		public float blueOffset;
		public float greenMultiplier;
		public float greenOffset;
		public float redMultiplier;
		public float redOffset;

		public uint color;

		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset, float blueOffset, float alphaOffset) {}
		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset, float blueOffset) {}
		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset, float greenOffset) {}
		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier, float redOffset) {}
		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier, float alphaMultiplier) {}
		public ColorTransform(float redMultiplier, float greenMultiplier, float blueMultiplier) {}
		public ColorTransform(float redMultiplier, float greenMultiplier) {}
		public ColorTransform(float redMultiplier) {}
		public ColorTransform() {}

		public void concat(ColorTransform second) {
			
		}
	}
}
