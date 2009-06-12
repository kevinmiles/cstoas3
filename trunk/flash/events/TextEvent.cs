namespace flash.events {
	public class TextEvent : Event {
		/// <summary>
		///  Defines the value of the type property of a link event object.
		/// </summary>
		public const string LINK="link";

		/// <summary>
		/// Defines the value of the type property of a textInput event object.
		/// </summary>
		public const string TEXT_INPUT = "textInput";

		/// <summary>
		/// Creates an Event object that contains information about text events.
		/// </summary>
		public TextEvent(string type, bool bubbles, bool cancelable, string text) : base("", false, false) {}

		/// <summary>
		/// Creates an Event object that contains information about text events.
		/// </summary>
		public TextEvent(string type, bool bubbles, bool cancelable) : base("", false, false) {}

		/// <summary>
		/// Creates an Event object that contains information about text events.
		/// </summary>
		public TextEvent(string type, bool bubbles) : base("", false) {}

		/// <summary>
		/// Creates an Event object that contains information about text events.
		/// </summary>
		public TextEvent(string type) : base("") {}

		/// <summary>
		/// For a textInput event, the character or sequence of characters entered by the user.
		/// </summary>
		public string text {
			get;
			set;
		}

		/// <summary>
		/// Creates a copy of the <see cref="TextEvent"/> object and sets the value of each property to match that of the original.
		/// </summary>
		public Event clone() {
			return default(Event);
		}
	}
}