namespace flash.events {
	using display;

	public class MouseEvent : Event {
		/// <summary>
		/// Defines the value of the type property of a click event object.
		/// </summary>
		public const string CLICK ="click";

		/// <summary>
		/// Defines the value of the type property of a doubleClick event object.
		/// </summary>
		public const string DOUBLE_CLICK ="doubleClick";

		/// <summary>
		/// Defines the value of the type property of a mouseDown event object.
		/// </summary>
		public const string MOUSE_DOWN="mouseDown" ;

		/// <summary>
		/// Defines the value of the type property of a mouseMove event object.
		/// </summary>
		public const string MOUSE_MOVE ="mouseMove";

		/// <summary>
		/// Defines the value of the type property of a mouseOut event object.
		/// </summary>
		public const string MOUSE_OUT ="mouseOut";

		/// <summary>
		/// Defines the value of the type property of a mouseOver event object.
		/// </summary>
		public const string MOUSE_OVER ="mouseOver";

		/// <summary>
		/// Defines the value of the type property of a mouseUp event object.
		/// </summary>
		public const string MOUSE_UP ="mouseUp";

		/// <summary>
		/// Defines the value of the type property of a mouseWheel event object.
		/// </summary>
		public const string MOUSE_WHEEL ="mouseWheel";

		/// <summary>
		/// Defines the value of the type property of a rollOut event object.
		/// </summary>
		public const string ROLL_OUT ="rollOut";

		/// <summary>
		/// Defines the value of the type property of a rollOver event object.
		/// </summary>
		public const string ROLL_OVER = "rollOver";

		public MouseEvent(string pType) : base(pType) {}

		public MouseEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public MouseEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// Indicates whether the Alt key is active (true) or inactive (false).
		/// </summary>
		public bool altKey {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the primary mouse button is pressed (true) or not (false).
		/// </summary>
		public bool buttonDown {
			get;
			set;
		}

		/// <summary>
		/// On Windows, indicates whether the Ctrl key is active (true) or inactive (false).
		/// </summary>
		public bool ctrlKey {
			get;
			set;
		}

		/// <summary>
		/// Indicates how many lines should be scrolled for each unit the user rotates the mouse wheel.
		/// </summary>
		public int delta {
			get;
			set;
		}

		/// <summary>
		/// The horizontal coordinate at which the event occurred relative to the containing sprite.
		/// </summary>
		public double localX {
			get;
			set;
		}

		/// <summary>
		/// The vertical coordinate at which the event occurred relative to the containing sprite.
		/// </summary>
		public double localY {
			get;
			set;
		}

		/// <summary>
		/// A reference to a display list object that is related to the event.
		/// </summary>
		public InteractiveObject relatedObject {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the Shift key is active (true) or inactive (false).
		/// </summary>
		public bool shiftKey {
			get;
			set;
		}

		/// <summary>
		/// [read-only] The horizontal coordinate at which the event occurred in global Stage coordinates.
		/// </summary>
		public readonly double stageX;

		/// <summary>
		/// [read-only] The vertical coordinate at which the event occurred in global Stage coordinates.
		/// </summary>
		public readonly double stageY;

		/// <summary>
		/// Instructs Flash Player to render after processing of this event completes, if the display list has been modified. 
		/// </summary>
		public void updateAfterEvent() {}
	}
}