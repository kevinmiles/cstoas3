namespace flash.events {
	using display;

	public class FocusEvent : Event {
		/// <summary>
		/// Defines the value of the type property of a focusIn event object.
		/// </summary>
		public const string FOCUS_IN = "focusIn";

		/// <summary>
		/// Defines the value of the type property of a focusOut event object.
		/// </summary>
		public const string FOCUS_OUT="focusOut";

		/// <summary>
		/// Defines the value of the type property of a keyFocusChange event object.
		/// </summary>
		public const string KEY_FOCUS_CHANGE="keyFocusChange";

		/// <summary>
		/// Defines the value of the type property of a mouseFocusChange event object.
		/// </summary>
		public const string MOUSE_FOCUS_CHANGE = "mouseFocusChange";

		public FocusEvent(string pType) : base(pType) {}

		public FocusEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public FocusEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// The key code value of the key pressed to trigger a keyFocusChange event.
		/// </summary>
		public uint keyCode {
			get;
			set;
		}

		/// <summary>
		/// A reference to the complementary <see cref="InteractiveObject"/> instance that is affected by the change in focus.
		/// </summary>
		public InteractiveObject relatedObject {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the Shift key modifier is activated, in which case the value is true.
		/// </summary>
		public bool shiftKey {
			get;
			set;
		}
	}
}