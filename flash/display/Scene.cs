namespace flash.display {
	public class Scene {
		/// <summary>
		/// [read-only] An array of <see cref="FrameLabel"/> objects for the scene.
		/// </summary>
		public readonly FrameLabel[] labels;

		/// <summary>
		/// [read-only] The name of the scene.
		/// </summary>
		public readonly string name;

		/// <summary>
		/// [read-only] The number of frames in the scene.
		/// </summary>
		public readonly int numFrames;
	}
}