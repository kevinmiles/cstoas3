namespace flash.events {
	public class ProgressEvent : Event {
		public ProgressEvent(string pType) : base(pType) {}

		public ProgressEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public ProgressEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// The number of items or bytes loaded when the listener processes the event.
		/// </summary>
		public double bytesLoaded {
			get;
			set;
		}

		/// <summary>
		/// The total number of items or bytes that will be loaded if the loading process succeeds.
		/// </summary>
		public double bytesTotal {
			get;
			set;
		}

		/// <summary>
		/// Defines the value of the type property of a progress event object.
		/// </summary>
		public static readonly string PROGRESS;

		/// <summary>
		/// Defines the value of the type property of a socketData event object.
		/// </summary>
		public static readonly string SOCKET_DATA;
	}
}