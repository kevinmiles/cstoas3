namespace flash.net {
	using events;

	public class LocalConnection : EventDispatcher {
		/// <summary>
		/// Indicates the object on which callback methods are invoked.
		/// </summary>
		public object client {
			get;
			set;
		}

		/// <summary>
		/// A string representing the domain of the location of the current file.
		/// </summary>
		public readonly string domain;

		/// <summary>
		/// Specifies one or more domains that can send <see cref="LocalConnection"/> calls to this <see cref="LocalConnection"/> instance.
		/// </summary>
		public void allowDomain( params string[] domains) {}

		/// <summary>
		/// Specifies one or more domains that can send <see cref="LocalConnection"/> calls to this <see cref="LocalConnection"/> instance.
		/// </summary>
		public void allowDomain() {}

		/// <summary>
		/// Specifies one or more domains that can send <see cref="LocalConnection"/> calls to this <see cref="LocalConnection"/> object.
		/// </summary>
		public void allowInsecureDomain( params string[] domains) {}

		/// <summary>
		/// Specifies one or more domains that can send <see cref="LocalConnection"/> calls to this <see cref="LocalConnection"/> object.
		/// </summary>
		public void allowInsecureDomain() {}

		/// <summary>
		/// Closes (disconnects) a <see cref="LocalConnection"/> object.
		/// </summary>
		public void close() {}

		/// <summary>
		/// Prepares a <see cref="LocalConnection"/> object to receive commands from a send() command (called the sending LocalConnection object).
		/// </summary>
		public void connect(string connectionName) {}

		/// <summary>
		/// Invokes the method named methodName on a connection opened with the connect(connectionName) method (the receiving LocalConnection object).
		/// </summary>
		public void send(string connectionName, string methodName, /* params */ object arguments) {}

		/// <summary>
		/// Invokes the method named methodName on a connection opened with the connect(connectionName) method (the receiving LocalConnection object).
		/// </summary>
		public void send(string connectionName, string methodName) {}

		/// <summary>
		/// Dispatched when an exception is thrown asynchronously — that is, from native asynchronous code.
		/// </summary>
		[As3Event("AsyncErrorEvent.ASYNC_ERROR")]
		public event AsyncErrorEventDelegate asyncError;

		/// <summary>
		/// Dispatched if a call to LocalConnection.send() attempts to send data to a different security sandbox.
		/// </summary>
		[As3Event("SecurityErrorEvent.SECURITY_ERROR")]
		public event SecurityErrorEventDelegate securityError;

		/// <summary>
		/// Dispatched when a LocalConnection object reports its status.
		/// </summary>
		[As3Event("StatusEvent.STATUS")]
		public event StatusEventDelegate status;
	}
}