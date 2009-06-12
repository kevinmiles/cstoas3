namespace flash.text {
	using Global;

	public class Font {
		/// <summary>
		/// [read-only] The name of an embedded font.
		/// </summary>
		public string fontName {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] The style of the font.
		/// </summary>
		public string fontStyle {
			get;
			private set;
		}

		/// <summary>
		/// [read-only] The type of the font.
		/// </summary>
		public string fontType {
			get;
			private set;
		}

		/// <summary>
		/// [static] Specifies whether to provide a list of the currently available embedded fonts.
		/// </summary>
		public static Font[] enumerateFonts(bool enumerateDeviceFonts) {
			return default(Font[]);
		}

		/// <summary>
		/// [static] Specifies whether to provide a list of the currently available embedded fonts.
		/// </summary>
		public static Font[] enumerateFonts() {
			return default(Font[]);
		}

		/// <summary>
		/// Specifies whether a provided string can be displayed using the currently assigned font.
		/// </summary>
		public bool hasGlyphs(string str) {
			return default(bool);
		}

		/// <summary>
		/// [static] Registers a font class in the global font list.
		/// </summary>
		public static void registerFont(Class font) {}
	}
}