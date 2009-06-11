namespace flash.display {
	public enum BlendMode {
		/// <summary>
		/// Adds the values of the constituent colors of the display object to the colors of its background, applying a ceiling of 0xFF.
		/// </summary>
		ADD,
		/// <summary>
		/// Applies the alpha value of each pixel of the display object to the background.
		/// </summary>
		ALPHA,
		/// <summary>
		/// Selects the darker of the constituent colors of the display object and the colors of the background (the colors with the smaller values).
		/// </summary>
		DARKEN,
		/// <summary>
		/// Compares the constituent colors of the display object with the colors of its background, and subtracts the darker of the values of the two constituent colors from the lighter value.
		/// </summary>
		DIFFERENCE,
		/// <summary>
		/// Erases the background based on the alpha value of the display object.
		/// </summary>
		ERASE,
		/// <summary>
		/// Adjusts the color of each pixel based on the darkness of the display object.
		/// </summary>
		HARDLIGHT,
		/// <summary>
		/// Inverts the background.
		/// </summary>
		INVERT,
		/// <summary>
		/// Forces the creation of a transparency group for the display object.
		/// </summary>
		LAYER,
		/// <summary>
		/// Selects the lighter of the constituent colors of the display object and the colors of the background (the colors with the larger values).
		/// </summary>
		LIGHTEN,
		/// <summary>
		/// Multiplies the values of the display object constituent colors by the constituent colors of the background color, and normalizes by dividing by 0xFF, resulting in darker colors.
		/// </summary>
		MULTIPLY,
		/// <summary>
		/// The display object appears in front of the background.
		/// </summary>
		NORMAL,
		/// <summary>
		/// Adjusts the color of each pixel based on the darkness of the background.
		/// </summary>
		OVERLAY,
		/// <summary>
		/// Multiplies the complement (inverse) of the display object color by the complement of the background color, resulting in a bleaching effect.
		/// </summary>
		SCREEN,
		/// <summary>
		/// Uses a shader to define the blend between objects.
		/// </summary>
		SHADER,
		/// <summary>
		/// Subtracts the values of the constituent colors in the display object from the values of the background color, applying a floor of 0.
		/// </summary>
		SUBTRACT
	}
}
