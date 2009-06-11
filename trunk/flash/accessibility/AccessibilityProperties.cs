namespace flash.accessibility {
	public class AccessibilityProperties {
		/// <summary>
		/// Provides a description for this display object in the accessible presentation.
		/// </summary>
		public string description;

		/// <summary>
		/// If true, causes Flash Player to exclude child objects within this display object from the accessible presentation.
		/// </summary>
		public bool forceSimple;

		/// <summary>
		/// Provides a name for this display object in the accessible presentation.
		/// </summary>
		public string name;

		/// <summary>
		/// If true, disables the Flash Player default auto-labeling system.
		/// </summary>
		public bool noAutoLabeling;

		/// <summary>
		/// Indicates a keyboard shortcut associated with this display object.
		/// </summary>
		public string shortcut;

		/// <summary>
		/// If true, excludes this display object from accessible presentation.
		/// </summary>
		public bool silent;
	}
}
