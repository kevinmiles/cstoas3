namespace flash.events {
	using Global;

	public class AsyncErrorEvent : ErrorEvent {
		/// <summary>
		/// Creates an AsyncErrorEvent object that contains information about asyncError events.
		/// </summary>
		public AsyncErrorEvent(string type, bool bubbles, bool cancelable, string text, Error error)
			: base(type, bubbles, cancelable, text) {}

		/// <summary>
		/// Creates an AsyncErrorEvent object that contains information about asyncError events.
		/// </summary>
		public AsyncErrorEvent(string type, bool bubbles, bool cancelable, string text)
			: base(type, bubbles, cancelable, text) {}

		/// <summary>
		/// Creates an AsyncErrorEvent object that contains information about asyncError events.
		/// </summary>
		public AsyncErrorEvent(string type, bool bubbles, bool cancelable) : base(type, bubbles, cancelable) {}

		/// <summary>
		/// Creates an AsyncErrorEvent object that contains information about asyncError events.
		/// </summary>
		public AsyncErrorEvent(string type, bool bubbles) : base(type, bubbles) {}

		/// <summary>
		/// Creates an AsyncErrorEvent object that contains information about asyncError events.
		/// </summary>
		public AsyncErrorEvent(string type) : base(type) {}

		/// <summary>
		/// The exception that was thrown.
		/// </summary>
		public Error error {
			get;
			set;
		}

		/// <summary>
		/// [static] The <see cref="AsyncErrorEvent"/>.ASYNC_ERROR constant defines the value of the type property of an asyncError event object.
		/// </summary>
		public static readonly string ASYNC_ERROR;
	}
}