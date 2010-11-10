namespace flash.net {
	using System;

	using events;

	public class NetConnection : EventDispatcher {
		#region Properties
		/// <summary>
		/// Indicates the object on which callback methods should be invoked.
		/// </summary>
		public object client {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the application is connected to a server through a persistent RTMP connection (true) or not (false).
		/// </summary>
		public bool connected;

		/// <summary>
		/// The proxy type used to make a successful NetConnection.connect() call to Flash Media Server: "none", "HTTP", "HTTPS", or "CONNECT".
		/// </summary>
		public readonly string connectedProxyType;

		/// <summary>
		/// The default object encoding for NetConnection objects.
		/// </summary>
		public static uint defaultObjectEncoding {
			get;
			set;
		}

		/// <summary>
		/// The identifier of the Flash Media Server instance to which this Flash Player or Adobe AIR instance is connected.
		/// </summary>
		public readonly string farID;

		/// <summary>
		/// A value chosen substantially by Flash Media Server, unique to this connection.
		/// </summary>
		public string farNonce {
			get;
			private set;
		}

		/// <summary>
		/// The total number of inbound and outbound peer connections that this instance of Flash Player or Adobe AIR allows.
		/// </summary>
		public uint maxPeerConnections {
			get;
			set;
		}

		/// <summary>
		/// The identifier of this Flash Player or Adobe AIR instance for this NetConnection instance.
		/// </summary>
		public string nearID {
			get;
			private set;
		}

		/// <summary>
		/// A value chosen substantially by this Flash Player or Adobe AIR instance, unique to this connection.
		/// </summary>
		public string nearNonce {
			get;
			private set;
		}

		/// <summary>
		/// The object encoding for this NetConnection instance.
		/// </summary>
		public uint objectEncoding {
			get;
			set;
		}

		/// <summary>
		/// The protocol used to establish the connection.
		/// </summary>
		public string protocol {
			get;
			private set;
		}

		/// <summary>
		/// Determines which fallback methods are tried if an initial connection attempt to the server fails.
		/// </summary>
		public string proxyType {
			get;
			set;
		}

		/// <summary>
		/// [read-only] An object that holds all of the peer subscriber NetStream objects that are not associated with publishing NetStream objects.
		/// </summary>
		public NetStream[] unconnectedPeerStreams {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] The URI passed to the NetConnection.connect() method.
		/// </summary>
		public string uri {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] Indicates whether a secure connection was made using native Transport Layer Security (TLS) rather than HTTPS.
		/// </summary>
		public bool usingTLS {
			get;
			private set;
		}
		#endregion

		/// <summary>
		/// Adds a context header to the Action Message Format (AMF) packet structure.
		/// </summary>
		public void addHeader(string operation, bool mustUnderstand, object param) {}

		/// <summary>
		/// Adds a context header to the Action Message Format (AMF) packet structure.
		/// </summary>
		public void addHeader(string operation, bool mustUnderstand) {}

		/// <summary>
		/// Adds a context header to the Action Message Format (AMF) packet structure.
		/// </summary>
		public void addHeader(string operation) {}

		/// <summary>
		/// Invokes a command or method on Flash Media Server or on an application server running Flash Remoting.
		/// </summary>
		public void call(string command, Responder responder, params object[] arguments) {}

		/// <summary>
		/// Invokes a command or method on Flash Media Server or on an application server running Flash Remoting.
		/// </summary>
		public void call(string command, Responder responder) {}

		/// <summary>
		/// Closes the connection that was opened locally or to the server and dispatches a netStatus event with a code property of NetConnection.Connect.Closed.
		/// </summary>
		public void close() {}

		/// <summary>
		/// Creates a bidirectional connection between a Flash Player or AIR an AIR application and a Flash Media Server application.
		/// </summary>
		public void connect(string command, /* params */ object arguments) {}

		/// <summary>
		/// Creates a bidirectional connection between a Flash Player or AIR an AIR application and a Flash Media Server application.
		/// </summary>
		public void connect(string command) {}

		/// <summary>
		/// Dispatched when an exception is thrown asynchronously — that is, from native asynchronous code.
		/// </summary>
		[As3Event("AsyncErrorEvent.ASYNC_ERROR")]
		public event Action<AsyncErrorEvent> asyncError;

		/// <summary>
		/// Dispatched when an input or output error occurs that causes a network operation to fail.
		/// </summary>
		[As3Event("IOErrorEvent.IO_ERROR")]
		public event Action<IOErrorEvent> ioError;

		/// <summary>
		/// Dispatched when a NetConnection object is reporting its status or error condition.
		/// </summary>
		[As3Event("NetStatusEvent.NET_STATUS")]
		public event Action<NetStatusEvent> netStatus;

		/// <summary>
		/// Dispatched if a call to NetConnection.call() attempts to connect to a server outside the caller's security sandbox.
		/// </summary>
		[As3Event("SecurityErrorEvent.SECURITY_ERROR")]
		public event Action<SecurityErrorEvent> securityError;
	}
}