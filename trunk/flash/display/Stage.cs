namespace flash.display {
	using System;

	using events;

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
		public new readonly bool cacheAsBitmap;

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
		public new double height {
			get;
			private set;
		}

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
		/// Indicates the width of the display object, in pixels.
		/// </summary>
		new public double width {
			get;
			private set;
		}

		/// <summary>
		/// Calling the invalidate() method signals Flash Player to alert display objects on the next opportunity it has to render the display list (for example, when the playhead advances to a new frame).
		/// </summary>
		public void invalidate() {
			return;
		}

		/// <summary>
		/// Determines whether the Stage.focus property returns null for security reasons.
		/// </summary>
		public bool isFocusInaccessible() {
			return default(bool);
		}

		/// <summary>
		/// Dispatched when the Stage object enters, or leaves, full-screen mode.
		/// </summary>
		[As3Event("FullScreenEvent.FULL_SCREEN")]
		public event Action<FullScreenEvent> fullScreen;

		/// <summary>
		/// Dispatched by the Stage object when the mouse pointer moves out of the stage area.
		/// </summary>
		[As3Event("Event.MOUSE_LEAVE")]
		public event Action<Event> mouseLeave;

		/// <summary>
		/// Dispatched when the <see cref="scaleMode"/> property of the Stage object is set to <see cref="StageScaleMode"/>.NO_SCALE and the SWF file is resized.
		/// </summary>
		[As3Event("Event.RESIZE")]
		public event Action<Event> resize;
	}
}