namespace flash.events {
	public class TimerEvent : Event {
		/// <summary>
		/// Defines the value of the type property of a timer event object.
		/// </summary>
		public static readonly string TIMER;

		/// <summary>
		/// Defines the value of the type property of a timerComplete event object.
		/// </summary>
		public static readonly string TIMER_COMPLETE;

		public TimerEvent(string pType) : base(pType) {}
		public TimerEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}
		public TimerEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}
	}
}