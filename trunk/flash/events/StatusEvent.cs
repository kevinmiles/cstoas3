namespace flash.events {
	public class StatusEvent : Event {
		public StatusEvent(string pType) : base(pType) {}

		public StatusEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public StatusEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// A description of the object's status.
		/// </summary>
		public string code {
			get;
			set;
		}

		/// <summary>
		/// The category of the message, such as "status", "warning" or "error".
		/// </summary>
		public string level {
			get;
			set;
		}

		/// <summary>
		/// Defines the value of the type property of a status event object.
		/// </summary>
		public static readonly string STATUS;
	}
}