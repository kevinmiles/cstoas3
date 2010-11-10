namespace flash.net {
	using System;

	using events;

	public class URLLoader : EventDispatcher {
		/// <summary>
		/// Indicates the number of bytes that have been loaded thus far during the load operation.
		/// </summary>
		public uint bytesLoaded;

		/// <summary>
		/// Indicates the total number of bytes in the downloaded data.
		/// </summary>
		public uint bytesTotal;

		/// <summary>
		/// The data received from the load operation.
		/// </summary>
		public object data;

		/// <summary>
		/// Controls whether the downloaded data is received as text (<see cref="URLLoaderDataFormat"/>.TEXT), raw binary data (URLLoaderDataFormat.BINARY), or URL-encoded variables (URLLoaderDataFormat.VARIABLES).
		/// </summary>
		public URLLoaderDataFormat dataFormat;

		/// <summary>
		/// Closes the load operation in progress.
		/// </summary>
		public void close() {}

		/// <summary>
		/// Sends and loads data from the specified URL.
		/// </summary>
		public void load(URLRequest request) {}

		/// <summary>
		/// Creates a URLLoader object.
		/// </summary>
		public URLLoader(URLRequest request) {}

		/// <summary>
		/// Creates a URLLoader object.
		/// </summary>
		public URLLoader() {}

		/// <summary>
		/// Dispatched after all the received data is decoded and placed in the data property of the URLLoader object.
		/// </summary>
		[As3Event("Event.COMPLETE")]
		public event Action<Event> complete;

		/// <summary>
		/// Dispatched if a call to URLLoader.load() attempts to access data over HTTP.
		/// </summary>
		[As3Event("HTTPStatusEvent.HTTP_STATUS")]
		public event Action<HTTPStatusEvent> httpStatus;

		/// <summary>
		/// Dispatched if a call to URLLoader.load() results in a fatal error that terminates the download.
		/// </summary>
		[As3Event("IOErrorEvent.IO_ERROR")]
		public event Action<IOErrorEvent> ioError;

		/// <summary>
		/// Dispatched when the download operation commences following a call to the URLLoader.load() method.
		/// </summary>
		[As3Event("Event.OPEN")]
		public event Action<Event> open;

		/// <summary>
		/// Dispatched when data is received as the download operation progresses.
		/// </summary>
		[As3Event("ProgressEvent.PROGRESS")]
		public event Action<ProgressEvent> progress;

		/// <summary>
		/// Dispatched if a call to URLLoader.load() attempts to load data from a server outside the security sandbox.
		/// </summary>
		[As3Event("SecurityErrorEvent.SECURITY_ERROR")]
		public event Action<SecurityErrorEvent> securityError;
	}
}