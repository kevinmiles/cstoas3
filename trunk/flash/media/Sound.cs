namespace flash.media {
	using events;

	using net;

	public class Sound : EventDispatcher {
		public Sound() {}

		public Sound(URLRequest stream) {}

		/// <summary>
		/// Generates a new <see cref="SoundChannel"/> object to play back the sound.
		/// </summary>
		/// <param name="startTime"></param>
		/// <param name="loops"></param>
		/// <param name="sndTransform"></param>
		/// <returns></returns>
		public SoundChannel play(double startTime, int loops, SoundTransform sndTransform) {
			return default(SoundChannel);
		}

		public SoundChannel play(double startTime, int loops) {
			return default(SoundChannel);
		}

		public SoundChannel play(double startTime) {
			return default(SoundChannel);
		}

		public SoundChannel play() {
			return default(SoundChannel);
		}

		public double length {
			get;
			private set;
		}
	}
}