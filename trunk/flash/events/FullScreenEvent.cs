namespace flash.events {
	public class FullScreenEvent : ActivityEvent {
		/// <summary>
		/// The <see cref="FullScreenEvent"/>.FULL_SCREEN constant defines the value of the type property of a fullScreen event object.
		/// </summary>
		public const string FULL_SCREEN = "fullScreen";

		public FullScreenEvent(string pType) : base(pType) {}

		public FullScreenEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public FullScreenEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// Indicates whether the Stage object is in full-screen mode (true) or not (false).
		/// </summary>
		public readonly bool fullScreen;
	}
}