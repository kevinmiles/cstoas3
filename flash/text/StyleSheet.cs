namespace flash.text {
	using events;

	public class StyleSheet : EventDispatcher {
		/// <summary>
		/// Removes all styles from the style sheet object.
		/// </summary>
		public void clear() {}

		/// <summary>
		/// Returns a copy of the style object associated with the style named <paramref name="styleName"/>.
		/// </summary>
		public object getStyle(string styleName) {
			return default(object);
		}

		/// <summary>
		/// Parses the CSS in <paramref name="CSSText"/> and loads the style sheet with it.
		/// </summary>
		public void parseCSS(string CSSText) {}

		/// <summary>
		/// Adds a new style with the specified name to the style sheet object.
		/// </summary>
		public void setStyle(string styleName, object styleObject) {}

		/// <summary>
		/// Extends the CSS parsing capability.
		/// </summary>
		public TextFormat transform(object formatObject) {
			return default(TextFormat);
		}
	}
}