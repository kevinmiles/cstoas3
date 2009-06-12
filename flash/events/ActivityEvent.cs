namespace flash.events {
	public class ActivityEvent : Event {
		/// <summary>
		/// The <see cref="ActivityEvent"/>.ACTIVITY constant defines the value of the type property of an activity event object.
		/// </summary>
		public const string ACTIVITY = "activity";

		public ActivityEvent(string pType) : base(pType) {}

		public ActivityEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public ActivityEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// Indicates whether the device is activating (true) or deactivating (false).
		/// </summary>
		public bool activating {
			get;
			set;
		}
	}
}