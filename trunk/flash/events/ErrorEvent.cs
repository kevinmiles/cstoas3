namespace flash.events {
	public class ErrorEvent : TextEvent {
		/// <summary>
		/// Defines the value of the type property of an error event object.
		/// </summary>
		public const string ERROR = "error";

		/// <summary>
		/// [read-only] Contains the reference number associated with the specific error.
		/// </summary>
		public readonly int errorID;

		/// <summary>
		/// Creates an Event object that contains information about error events.
		/// </summary>
		public ErrorEvent(string type, bool bubbles, bool cancelable, string text, int id)
			: base(type, bubbles, cancelable, text) {}

		/// <summary>
		/// Creates an Event object that contains information about error events.
		/// </summary>
		public ErrorEvent(string type, bool bubbles, bool cancelable, string text) : base(type, bubbles, cancelable, text) {}

		/// <summary>
		/// Creates an Event object that contains information about error events.
		/// </summary>
		public ErrorEvent(string type, bool bubbles, bool cancelable) : base(type, bubbles, cancelable) {}

		/// <summary>
		/// Creates an Event object that contains information about error events.
		/// </summary>
		public ErrorEvent(string type, bool bubbles) : base(type, bubbles) {}

		/// <summary>
		/// Creates an Event object that contains information about error events.
		/// </summary>
		public ErrorEvent(string type) : base(type) {}
	}
}