namespace flash.display {
	using events;

	using system;

	using utils;

	public class LoaderInfo : EventDispatcher {
		public readonly ActionScriptVersion actionScriptVersion;
		public readonly ApplicationDomain applicationDomain;

		public readonly ByteArray bytes;

		public readonly uint bytesLoaded;
		public readonly uint bytesTotal;

		public readonly bool childAllowsParent;
		
		public object childSandboxBridge;

		public readonly DisplayObject content;
		public readonly string contentType;
		public readonly float frameRate;
		public readonly int height;
		public readonly Loader loader;
		public readonly string loaderURL;
		public readonly object parameters;
		public readonly bool parentAllowsChild;
		public object parentSandboxBridge;
		public readonly bool sameDomain;
		public readonly EventDispatcher sharedEvents;
		public readonly uint swfVersion;
		public readonly string url;
		public readonly int width;

		public LoaderInfo getLoaderInfoByDefinition(object obj) {
			return null;
		}

		/// <summary>
		/// Dispatched when data has loaded successfully.
		/// </summary>
		[As3Event(Event.COMPLETE)]
		public event EventDelegate complete;

		/// <summary>
		/// Dispatched when a network request is made over HTTP and an HTTP status code can be detected.
		/// </summary>
		[As3Event(HTTPStatusEvent.HTTP_STATUS)]
		public event HTTPStatusEventDelegate httpStatus;

		/// <summary>
		/// Dispatched when the properties and methods of a loaded SWF file are accessible.
		/// </summary>
		[As3Event(Event.INIT)]
		public event EventDelegate init;

		/// <summary>
		/// Dispatched when an input or output error occurs that causes a load operation to fail.
		/// </summary>
		[As3Event(IOErrorEvent.IO_ERROR)]
		public event IOErrorEventDelegate ioError;

		/// <summary>
		/// Dispatched when a load operation starts.
		/// </summary>
		[As3Event(Event.OPEN)]
		public event EventDelegate open;

		/// <summary>
		/// Dispatched when data is received as the download operation progresses.
		/// </summary>
		[As3Event(ProgressEvent.PROGRESS)]
		public event ProgressEventDelegate progress;

		/// <summary>
		/// Dispatched by a LoaderInfo object whenever a loaded object is removed by using the unload() method of the Loader object, or when a second load is performed by the same Loader object and the original content is removed prior to the load beginning.
		/// </summary>
		[As3Event(Event.UNLOAD)]
		public event EventDelegate unload;
	}
}
