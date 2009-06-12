namespace flash.system {
	public static class Security {
		/// <summary>
		/// [static] Loads a cross-domain policy file from a location specified by the url parameter.
		/// </summary>
		public static void loadPolicyFile(string url) {}

		/// <summary>
		/// Determines how Flash Player or AIR chooses the domain to use for certain content settings, including settings for camera and microphone permissions, storage quotas, and storage of persistent shared objects.
		/// </summary>
		public static bool exactSettings {
			get;
			private set;
		}

		/// <summary>
		/// Indicates the type of security sandbox in which the calling file is operating.
		/// </summary>
		public static string sandboxType {
			get;
			private set;
		}

		/// <summary>
		/// This method applies to cross-scripting of ActionScript 3.0 code (in SWF content).
		/// </summary>
		/// <param name="domains"></param>
		public static void allowDomain(string domains) {}

		/// <summary>
		/// This method applies to cross-scripting of ActionScript 3.0 code (in SWF content).
		/// </summary>
		/// <param name="domains"></param>
		public static void allowInsecureDomain(string domains) {}

		/// <summary>
		/// Displays the Security Settings panel in Flash Player.
		/// </summary>
		public static void showSettings() {}
	}
}