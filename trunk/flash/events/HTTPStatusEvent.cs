namespace flash.events {
	public class HTTPStatusEvent : Event {
		public HTTPStatusEvent(string pType) : base(pType) {}

		public HTTPStatusEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public HTTPStatusEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// The HTTP status code returned by the server.
		/// </summary>
		public readonly int status;

		/// <summary>
		/// The <see cref="HTTPStatusEvent"/>.HTTP_STATUS constant defines the value of the type property of a httpStatus event object.
		/// </summary>
		public const string HTTP_STATUS = "httpStatus";

		/// <summary>
		/// The <see cref="HTTPStatusEvent"/>.HTTP_STATUS constant defines the value of the type property of a httpStatus event object.
		/// </summary>
		public const string HTTP_RESPONSE_STATUS = "httpResponseStatus";
	}
}