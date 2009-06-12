namespace flash.events {
	public class DataEvent : TextEvent {
		/// <summary>
		/// Defines the value of the type property of a data event object.
		/// </summary>
		public const string DATA = "data";

		/// <summary>
		/// Defines the value of the type property of an uploadCompleteData event object.
		/// </summary>
		public const string UPLOAD_COMPLETE_DATA = "uploadCompleteData";

		/// <summary>
		/// The raw data loaded into Flash Player or Adobe AIR.
		/// </summary>
		public string data {
			get;
			set;
		}

		/// <summary>
		/// Creates an event object that contains information about data events.
		/// </summary>
		public DataEvent(string type, bool bubbles, bool cancelable, string data) : base(type, bubbles, cancelable) {}

		/// <summary>
		/// Creates an event object that contains information about data events.
		/// </summary>
		public DataEvent(string type, bool bubbles, bool cancelable) : base(type, bubbles, cancelable) {}

		/// <summary>
		/// Creates an event object that contains information about data events.
		/// </summary>
		public DataEvent(string type, bool bubbles) : base(type, bubbles) {}

		/// <summary>
		/// Creates an event object that contains information about data events.
		/// </summary>
		public DataEvent(string type) : base(type) {}
	}
}