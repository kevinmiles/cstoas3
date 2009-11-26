namespace flash.Global {
	using System;

	public sealed class EmbedAttribute : Attribute {
		public string advancedAntiAliasing;
		public string fontFamily;
		public string fontName;
		public string fontStyle;
		public string fontWeight;

		/// <summary>
		/// Specifies the mime type of the asset.
		/// Supported values: 
		/// <example>
		/// *  application/octet-stream
		/// * application/x-font
		/// * application/x-font-truetype
		/// * application/x-shockwave-flash
		/// * audio/mpeg
		/// * image/gif
		/// * image/jpeg
		/// * image/png
		/// * image/svg
		/// * image/svg-xml
		/// </example>
		/// </summary>
		public string mimeType;

		/// <summary>
		/// Specifies the distance in pixels of the lower dividing line from the top of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public string scaleGridBottom;

		/// <summary>
		/// Specifies the distance in pixels of the left dividing line from the left side of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public string scaleGridLeft;

		/// <summary>
		/// Specifies the distance in pixels of the right dividing line from the left side of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public string scaleGridRight;

		/// <summary>
		/// Specifies the distance, in pixels, of the upper dividing line from the top of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public string scaleGridTop;

		/// <summary>
		/// Specifies the name and path of the asset to embed; either an absolute path or a path relative to the file containing the embed statement. The embedded asset must be a locally stored asset. Therefore, you cannot specify a URL for an asset to embed.
		/// </summary>
		public string source;

		public string systemFont;
		public string unicodeRange;
		public EmbedAttribute() {
			return;
		}

		public EmbedAttribute(string source) {
			return;
		}
	}
}