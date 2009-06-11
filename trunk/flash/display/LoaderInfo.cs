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


	}
}
