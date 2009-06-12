namespace flash.media {
	using display;

	using net;

	public class Video : DisplayObject {
		/// <summary>
		/// Specifies a video stream from a camera to be displayed within the boundaries of the Video object in the application.
		/// </summary>
		public void attachCamera(Camera camera) {}

		/// <summary>
		/// Specifies a video stream to be displayed within the boundaries of the Video object in the application.
		/// </summary>
		public void attachNetStream(NetStream netStream) {}

		/// <summary>
		/// Clears the image currently displayed in the Video object.
		/// </summary>
		public void clear() {}

		/// <summary>
		/// Creates a new Video instance.
		/// </summary>
		public Video(int width, int height) {}

		/// <summary>
		/// Creates a new Video instance.
		/// </summary>
		public Video(int width) {}

		/// <summary>
		/// Creates a new Video instance.
		/// </summary>
		public Video() {}

		/// <summary>
		/// Indicates the type of filter applied to decoded video as part of post-processing.
		/// </summary>
		public int deblocking {
			get;
			set;
		}

		/// <summary>
		/// Specifies whether the video should be smoothed (interpolated) when it is scaled.
		/// </summary>
		public bool smoothing {
			get;
			set;
		}

		/// <summary>
		/// [read-only] An integer specifying the height of the video stream, in pixels.
		/// </summary>
		public int videoHeight {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] An integer specifying the width of the video stream, in pixels.
		/// </summary>
		public int videoWidth {
			get;
			private set;
		}
	}
}