namespace flash.media {
	using events;

	public class SoundChannel : EventDispatcher {
		/// <summary>
		/// [read-only] The current amplitude (volume) of the left channel, from 0 (silent) to 1 (full amplitude).
		/// </summary>
		public double leftPeak {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] When the sound is playing, the position property indicates the current point that is being played in the sound file.
		/// </summary>
		public double position {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] The current amplitude (volume) of the right channel, from 0 (silent) to 1 (full amplitude).
		/// </summary>
		public double rightPeak {
			get;
			private set;
		}

		/// <summary>
		/// The SoundTransform object assigned to the sound channel.
		/// </summary>
		public SoundTransform soundTransform {
			get;
			set;
		}

		/// <summary>
		/// Stops the sound playing in the channel.
		/// </summary>
		public void stop() {}

		/// <summary>
		/// Dispatched when a sound has finished playing.
		/// </summary>
		[As3Event("Event.ACTIVATE")]
		public event EventDelegate soundComplete;
	}
}