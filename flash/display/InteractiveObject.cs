namespace flash.display {
	using System;

	using events;

	using ui;

	public class InteractiveObject : DisplayObject {
		/// <summary>
		/// Dispatched when a user presses and releases the main button of the user's pointing device over the same InteractiveObject.
		/// </summary>
		[EventAttribute("MouseEvent.CLICK")]
		public event Action<MouseEvent> click;
        
		/// <summary>
		/// Dispatched when a user presses and releases the main button of a pointing device twice in rapid succession over the same InteractiveObject when that object's doubleClickEnabled flag is set to true.
		/// </summary>
		[EventAttribute("MouseEvent.DOUBLE_CLICK")]
		public event Action<MouseEvent> doubleClick;

		/// <summary>
		/// Dispatched after a display object gains focus.
		/// </summary>
		[EventAttribute("FocusEvent.FOCUS_IN")]
		public event Action<FocusEvent> focusIn;

		/// <summary>
		/// Dispatched after a display object loses focus.
		/// </summary>
		[EventAttribute("FocusEvent.FOCUS_OUT")]
		public event Action<FocusEvent> focusOut;

		/// <summary>
		/// Dispatched when the user presses a key.
		/// </summary>
		[EventAttribute("KeyboardEvent.KEY_DOWN")]
		public event Action<KeyboardEvent> keyDown;

		/// <summary>
		/// Dispatched when the user attempts to change focus by using keyboard navigation.
		/// </summary>
		[EventAttribute("FocusEvent.KEY_FOCUS_CHANGE")]
		public event Action<FocusEvent> keyFocusChange;

		/// <summary>
		/// Dispatched when the user releases a key.
		/// </summary>
		[EventAttribute("KeyboardEvent.KEY_UP")]
		public event Action<KeyboardEvent> keyUp;

		/// <summary>
		/// Dispatched when a user presses the pointing device button over an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_DOWN")]
		public event Action<MouseEvent> mouseDown;

		/// <summary>
		/// Dispatched when the user attempts to change focus by using a pointer device.
		/// </summary>
		[EventAttribute("FocusEvent.MOUSE_FOCUS_CHANGE")]
		public event Action<FocusEvent> mouseFocusChange;

		/// <summary>
		/// Dispatched when a user moves the pointing device while it is over an InteractiveObject.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_MOVE")]
		public event Action<MouseEvent> mouseMove;

		/// <summary>
		/// Dispatched when the user moves a pointing device away from an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_OUT")]
		public event Action<MouseEvent> mouseOut;

		/// <summary>
		/// Dispatched when the user moves a pointing device over an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_OVER")]
		public event Action<MouseEvent> mouseOver;

		/// <summary>
		/// Dispatched when a user releases the pointing device button over an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_UP")]
		public event Action<MouseEvent> mouseUp;

		/// <summary>
		/// Dispatched when a mouse wheel is spun over an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.MOUSE_WHEEL")]
		public event Action<MouseEvent> mouseWheel;

		/// <summary>
		/// Dispatched when the user moves a pointing device away from an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.ROLL_OUT")]
		public event Action<MouseEvent> rollOut;

		/// <summary>
		/// Dispatched when the user moves a pointing device over an InteractiveObject instance.
		/// </summary>
		[EventAttribute("MouseEvent.ROLL_OVER")]
		public event Action<MouseEvent> rollOver;

		/// <summary>
		/// Dispatched when the value of the object's tabChildren flag changes.
		/// </summary>
		[EventAttribute("Event.TAB_CHILDREN_CHANGE")]
		public event Action<Event> tabChildrenChange;

		/// <summary>
		/// Dispatched when the object's tabEnabled flag changes.
		/// </summary>
		[EventAttribute("Event.TAB_ENABLED_CHANGE")]
		public event Action<Event> tabEnabledChange;

		/// <summary>
		/// Dispatched when the value of the object's tabIndex property changes.
		/// </summary>
		[EventAttribute("Event.TAB_INDEX_CHANGE")]
		public event Action<Event> tabIndexChange;

		public ContextMenu contextMenu;
		public bool doubleClickEnabled;
		public object focusRect;
		public bool mouseEnabled;
		public bool tabEnabled;
		public int tabIndex;
	}
}
