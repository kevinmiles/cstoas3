namespace flash.display {
	using events;

	using ui;

	public class InteractiveObject : DisplayObject {
		/// <summary>
		/// Dispatched when a user presses and releases the main button of the user's pointing device over the same InteractiveObject.
		/// </summary>
		[As3Event(MouseEvent.CLICK)]
		public event MouseEventDelegate click;
        
		/// <summary>
		/// Dispatched when a user presses and releases the main button of a pointing device twice in rapid succession over the same InteractiveObject when that object's doubleClickEnabled flag is set to true.
		/// </summary>
		[As3Event(MouseEvent.DOUBLE_CLICK)]
		public event MouseEventDelegate doubleClick;

		/// <summary>
		/// Dispatched after a display object gains focus.
		/// </summary>
		[As3Event(FocusEvent.FOCUS_IN)]
		public event FocusEventDelegate focusIn;

		/// <summary>
		/// Dispatched after a display object loses focus.
		/// </summary>
		[As3Event(FocusEvent.FOCUS_OUT)]
		public event FocusEventDelegate focusOut;

		/// <summary>
		/// Dispatched when the user presses a key.
		/// </summary>
		[As3Event(KeyboardEvent.KEY_DOWN)]
		public event KeyboardEventDelegate keyDown;

		/// <summary>
		/// Dispatched when the user attempts to change focus by using keyboard navigation.
		/// </summary>
		[As3Event(FocusEvent.KEY_FOCUS_CHANGE)]
		public event FocusEventDelegate keyFocusChange;

		/// <summary>
		/// Dispatched when the user releases a key.
		/// </summary>
		[As3Event(KeyboardEvent.KEY_UP)]
		public event KeyboardEventDelegate keyUp;

		/// <summary>
		/// Dispatched when a user presses the pointing device button over an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_DOWN)]
		public event MouseEventDelegate mouseDown;

		/// <summary>
		/// Dispatched when the user attempts to change focus by using a pointer device.
		/// </summary>
		[As3Event(FocusEvent.MOUSE_FOCUS_CHANGE)]
		public event FocusEventDelegate mouseFocusChange;

		/// <summary>
		/// Dispatched when a user moves the pointing device while it is over an InteractiveObject.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_MOVE)]
		public event MouseEventDelegate mouseMove;

		/// <summary>
		/// Dispatched when the user moves a pointing device away from an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_OUT)]
		public event MouseEventDelegate mouseOut;

		/// <summary>
		/// Dispatched when the user moves a pointing device over an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_OVER)]
		public event MouseEventDelegate mouseOver;

		/// <summary>
		/// Dispatched when a user releases the pointing device button over an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_UP)]
		public event MouseEventDelegate mouseUp;

		/// <summary>
		/// Dispatched when a mouse wheel is spun over an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.MOUSE_WHEEL)]
		public event MouseEventDelegate mouseWheel;

		/// <summary>
		/// Dispatched when the user moves a pointing device away from an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.ROLL_OUT)]
		public event MouseEventDelegate rollOut;

		/// <summary>
		/// Dispatched when the user moves a pointing device over an InteractiveObject instance.
		/// </summary>
		[As3Event(MouseEvent.ROLL_OVER)]
		public event MouseEventDelegate rollOver;

		/// <summary>
		/// Dispatched when the value of the object's tabChildren flag changes.
		/// </summary>
		[As3Event(Event.TAB_CHILDREN_CHANGE)]
		public event EventDelegate tabChildrenChange;

		/// <summary>
		/// Dispatched when the object's tabEnabled flag changes.
		/// </summary>
		[As3Event(Event.TAB_ENABLED_CHANGE)]
		public event EventDelegate tabEnabledChange;

		/// <summary>
		/// Dispatched when the value of the object's tabIndex property changes.
		/// </summary>
		[As3Event(Event.TAB_INDEX_CHANGE)]
		public event EventDelegate tabIndexChange;

		public ContextMenu contextMenu;
		public bool doubleClickEnabled;
		public object focusRect;
		public bool mouseEnabled;
		public bool tabEnabled;
		public int tabIndex;
	}
}
