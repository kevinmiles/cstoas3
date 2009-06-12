namespace flash.display {
	using geom;
	using text;

	public class Stage : DisplayObjectContainer {
		/// <summary>
		/// A value from the <see cref="StageAlign"/> class that specifies the alignment of the stage in Flash Player or the browser.
		/// </summary>
		public StageAlign align {
			get;
			set;
		}

		/// <summary>
		/// [write-only]
		/// </summary>
		public readonly bool cacheAsBitmap;

		/// <summary>
		/// A value from the <see cref="StageDisplayState"/> class that specifies which display state to use.
		/// </summary>
		public StageDisplayState displayState {
			get;
			set;
		}

		/// <summary>
		/// The interactive object with keyboard focus; or null if focus is not set or if the focused object belongs to a security sandbox to which the calling object does not have access.
		/// </summary>
		public InteractiveObject focus {
			get;
			set;
		}

		/// <summary>
		/// Gets and sets the frame rate of the stage.
		/// </summary>
		public double frameRate {
			get;
			set;
		}

		/// <summary>
		/// [read-only] Returns the height of the monitor that will be used when going to full screen size, if that state is entered immediately.
		/// </summary>
		public readonly uint fullScreenHeight;

		/// <summary>
		/// Sets Flash Player to scale a specific region of the stage to full-screen mode.
		/// </summary>
		public Rectangle fullScreenSourceRect {
			get;
			set;
		}

		/// <summary>
		/// [read-only] Returns the width of the monitor that will be used when going to full screen size, if that state is entered immediately.
		/// </summary>
		public readonly uint fullScreenWidth;

		/// <summary>
		/// Indicates the height of the display object, in pixels.
		/// </summary>
		public double height {
			get;
			set;
		}

		/// <summary>
		/// Determines whether or not the children of the object are mouse enabled.
		/// </summary>
		public bool mouseChildren {
			get;
			set;
		}

		/// <summary>
		/// [read-only] Returns the number of children of this object.
		/// </summary>
		public readonly int numChildren;

		/// <summary>
		/// A value from the <see cref="StageQuality"/> class that specifies which rendering quality is used.
		/// </summary>
		public StageQuality quality {
			get;
			set;
		}

		/// <summary>
		/// A value from the <see cref="StageScaleMode"/> class that specifies which scale mode to use.
		/// </summary>
		public StageScaleMode scaleMode {
			get;
			set;
		}

		/// <summary>
		/// Specifies whether to show or hide the default items in the Flash Player context menu.
		/// </summary>
		public bool showDefaultContextMenu {
			get;
			set;
		}

		/// <summary>
		/// Specifies whether or not objects display a glowing border when they have focus.
		/// </summary>
		public bool stageFocusRect {
			get;
			set;
		}

		/// <summary>
		/// The current height, in pixels, of the Stage.
		/// </summary>
		public int stageHeight {
			get;
			set;
		}

		/// <summary>
		/// Specifies the current width, in pixels, of the Stage.
		/// </summary>
		public int stageWidth {
			get;
			set;
		}

		/// <summary>
		/// Determines whether the children of the object are tab enabled.
		/// </summary>
		public bool tabChildren {
			get;
			set;
		}

		/// <summary>
		/// [write-only]
		/// </summary>
		public bool tabEnabled {
			get;
			set;
		}

		/// <summary>
		/// [read-only] Returns a <see cref="TextSnapshot"/> object for this <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public readonly TextSnapshot textSnapshot;

		/// <summary>
		/// Indicates the width of the display object, in pixels.
		/// </summary>
		public double width {
			get;
			set;
		}

		/// <summary>
		/// Calling the invalidate() method signals Flash Player to alert display objects on the next opportunity it has to render the display list (for example, when the playhead advances to a new frame).
		/// </summary>
		public void invalidate() {}

		/// <summary>
		/// Determines whether the Stage.focus property returns null for security reasons.
		/// </summary>
		public bool isFocusInaccessible() {
			return default(bool);
		}
	}
}