namespace flash.events {
	public class NetStatusEvent : Event {
		public NetStatusEvent(string pType) : base(pType) {}

		public NetStatusEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public NetStatusEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// An object with properties that describe the object's status or error condition.
		/// </summary>
		public object info {
			get;
			set;
		}

		/// <summary>
		/// Defines the value of the type property of a netStatus event object.
		/// </summary>
		public static readonly string NET_STATUS;
	}
}