namespace flash.display {
	public class MovieClip : Sprite {
		/// <summary>
		/// [read-only] Specifies the number of the frame in which the playhead is located in the timeline of the MovieClip instance.
		/// </summary>
		public readonly int currentFrame;

		/// <summary>
		/// [read-only] The current label in which the playhead is located in the timeline of the MovieClip instance.
		/// </summary>
		public readonly string currentLabel;

		/// <summary>
		/// [read-only] Returns an array of FrameLabel objects from the current scene.
		/// </summary>
		public readonly FrameLabel currentLabels;

		/// <summary>
		/// [read-only] The current scene in which the playhead is located in the timeline of the MovieClip instance.
		/// </summary>
		public readonly Scene currentScene;

		/// <summary>
		/// A Boolean value that indicates whether a movie clip is enabled.
		/// </summary>
		public bool enabled {
			get;
			set;
		}

		/// <summary>
		/// [read-only] The number of frames that are loaded from a streaming SWF file.
		/// </summary>
		public readonly int framesLoaded;

		/// <summary>
		/// [read-only] An array of Scene objects, each listing the name, the number of frames, and the frame labels for a scene in the MovieClip instance.
		/// </summary>
		public readonly Scene[] scenes;

		/// <summary>
		/// [read-only] The total number of frames in the MovieClip instance.
		/// </summary>
		public readonly int totalFrames;

		/// <summary>
		/// Indicates whether other display objects that are SimpleButton or MovieClip objects can receive mouse release events.
		/// </summary>
		public bool trackAsMenu {
			get;
			set;
		}

		/// <summary>
		/// Moves the playhead in the timeline of the movie clip.
		/// </summary>
		public void play() {
			return;
		}

		/// <summary>
		/// Stops the playhead in the movie clip.
		/// </summary>
		public void stop() {
			return;
		}

		public void nextFrame() {
			return;
		}
	}
}