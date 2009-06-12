namespace flash.system {
	public class LoaderContext {
		/// <summary>
		/// Specifies the application domain to use for the Loader.load() or Loader.loadBytes() method.
		/// </summary>
		public ApplicationDomain applicationDomain;

		/// <summary>
		/// Specifies whether Flash Player should attempt to download a cross-domain policy file from the loaded object's server before beginning to load the object itself.
		/// </summary>
		public bool checkPolicyFile;

		/// <summary>
		/// Specifies the security domain to use for a Loader.load() operation.
		/// </summary>
		public SecurityDomain securityDomain;

		/// <summary>
		/// Creates a new LoaderContext object, with the specified settings.
		/// </summary>
		public LoaderContext(bool checkPolicyFile, ApplicationDomain applicationDomain, SecurityDomain securityDomain) {}

		/// <summary>
		/// Creates a new LoaderContext object, with the specified settings.
		/// </summary>
		public LoaderContext(bool checkPolicyFile, ApplicationDomain applicationDomain) {}

		/// <summary>
		/// Creates a new LoaderContext object, with the specified settings.
		/// </summary>
		public LoaderContext(bool checkPolicyFile) {}

		/// <summary>
		/// Creates a new LoaderContext object, with the specified settings.
		/// </summary>
		public LoaderContext() {}
	}
}