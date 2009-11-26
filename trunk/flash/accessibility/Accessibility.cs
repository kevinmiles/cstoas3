namespace flash.accessibility {
	using display;

	public class Accessibility {
		/// <summary>
		/// Indicates whether a screen reader is currently active and the player is communicating with it.
		/// </summary>
		public static readonly bool active;

		/// <summary>
		/// Tells Flash Player to apply any accessibility changes made by using the <see cref="DisplayObject"/>.accessibilityProperties property.
		/// </summary>
		public static void updateProperties() {
			return;
		}

	}
}
