namespace flash.events {
	public class SyncEvent : Event {
		/// <summary>
		/// Defines the value of the type property of a sync event object.
		/// </summary>
		public static readonly string SYNC;

		public SyncEvent(string pType) : base(pType) {}
		public SyncEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}
		public SyncEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}
	}
}