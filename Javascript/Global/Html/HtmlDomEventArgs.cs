namespace Javascript.Global {
	using System;

	[AsIntegerAttribute, Flags]
	public enum MousePressState {
		None = 0,
		LeftButton = 1,
		RightButton = 2,
		MiddleButton = 4
	}

	///<summary>
	///	Represents the state of an event, such as the element in which the event occurred, the state of the keyboard keys, the location of the mouse, and the state of the mouse buttons.
	///</summary>
	public class HtmlDomEventArgs {
		///<summary>
		///	Sets or retrieves the state of the CTRL key.
		///</summary>
		public bool ctrlKey;

		///<summary>
		///	Sets or retrieves the Unicode key code associated with the key that caused the event.
		///</summary>
		public int keyCode;

		///<summary>
		///	Sets or retrieves the name of the property that changes on the object.
		///</summary>
		public string propertyName;

		///<summary>
		///	Sets or retrieves the state of the SHIFT key.
		///</summary>
		public bool shiftKey;

		protected HtmlDomEventArgs() {}

		///<summary>
		///	Sets or retrieves the x-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
		///</summary>
		public int x {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the y-coordinate, in pixels, of the mouse pointer's position relative to a relatively positioned parent element.
		///</summary>
		public int y {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the x-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
		///</summary>
		public int clientX {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the y-coordinate of the mouse pointer's position relative to the client area of the window, excluding window decorations and scroll bars.
		///</summary>
		public int clientY {
			get;
			set;
		}

		///<summary>
		///	Returns the horizontal coordinate of the event relative to whole document.
		///</summary>
		public int pageX {
			get;
			set;
		}

		///<summary>
		///	Returns the vertical coordinate of the event relative to the whole document.
		///</summary>
		public int pageY {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the x-coordinate of the mouse pointer's position relative to the object firing the event.
		///</summary>
		public int offsetX {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the y-coordinate of the mouse pointer's position relative to the object firing the event.
		///</summary>
		public int offsetY {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the object that fired the event.
		///</summary>
		public HtmlElement srcElement {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the return value from the event.
		///</summary>
		public object returnValue {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves whether the current event should bubble up the hierarchy of event handlers.
		///</summary>
		public bool cancelBubble {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the event name from the event object.
		///</summary>
		public string type {
			get;
			set;
		}

		/// <summary>
		/// 	Sets or retrieves the mouse button pressed by the user.
		/// 	Values:
		/// </summary>
		public MousePressState button {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves a value that indicates the state of the ALT key.
		///</summary>
		public bool altKey {
			get;
			set;
		}

		///<summary>
		///	Retrieves the state of the left CTRL key.
		///</summary>
		public bool ctrlLeft {
			get;
			set;
		}

		///<summary>
		///	Retrieves the state of the right CTRL key.
		///</summary>
		public bool ctrlRight {
			get;
			set;
		}

		///<summary>
		///	Retrieves the state of the left SHIFT key.
		///</summary>
		public bool shiftLeft {
			get;
			set;
		}

		///<summary>
		///	Retrieves the state of the right SHIFT key.
		///</summary>
		public bool shiftRight {
			get;
			set;
		}

		///<summary>
		///	Retrieves whether the onkeydown event is being repeated.
		///</summary>
		public bool repeat {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the x-coordinate of the mouse pointer's position relative to the user's screen.
		///</summary>
		public int screenX {
			get;
			set;
		}

		///<summary>
		///	Sets or retrieves the y-coordinate of the mouse pointer's position relative to the user's screen.
		///</summary>
		public int screenY {
			get;
			set;
		}

		///<summary>
		///	Retrieves the distance and direction the wheel button has rolled.
		///</summary>
		public int wheelDelta {
			get;
			set;
		}
	}
}