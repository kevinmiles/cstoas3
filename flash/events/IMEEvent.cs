namespace flash.events {
	public class IMEEvent : Event {
		/// <summary>
		/// The <see cref="ActivityEvent"/>.ACTIVITY constant defines the value of the type property of an activity event object.
		/// </summary>
		public const string IME_COMPOSITION = "imeComposition";

		public IMEEvent(string pType) : base(pType) {}

		public IMEEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public IMEEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {
		}


	}
}