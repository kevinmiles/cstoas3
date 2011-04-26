namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	public sealed class EventAttribute : Attribute {
		public EventAttribute(string eventName) {
		}
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
	public sealed class NameAttribute : Attribute {
		public NameAttribute(string pAs3Name, string pAs3Imports) {
		}
		public NameAttribute(string pAs3Name, string pAs3RealName, string pAs3Imports) {
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class IsGenericAttribute : Attribute {
		public IsGenericAttribute(bool pIsGeneric) {
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class AsObjectAttribute : Attribute {
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class As3ExtensionAttribute : Attribute {
		public As3ExtensionAttribute() {}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class As3MainClassAttribute : Attribute {
		public As3MainClassAttribute(int pWidth, int pHeight, int pFrameRate, uint pBackgroundColor) {}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class As3EmbedAttribute : Attribute {
		/// <summary>
		/// Specifies the name and path of the asset to embed; either an absolute path or a path relative to the file containing the embed statement. The embedded asset must be a locally stored asset. Therefore, you cannot specify a URL for an asset to embed.
		/// </summary>
		public As3EmbedAttribute(string pFilePath) {

		}

		/// <summary>
		/// Specifies the mime type of the asset.
		/// Supported values: 
		/// <example>
		/// * application/octet-stream
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
		/// Sets the font weight. Available values are normal, bold, heavy
		/// </summary>
		public string fontWeight;

		/// <summary>
		/// Sets the font style. Available values are normal, italic, oblique
		/// </summary>
		public string fontStyle;

		/// <summary>
		/// String used to identify font further in code and at runtime.
		/// </summary>
		public string fontName;

		/// <summary>
		/// Lets you specify a subset of the font's character range, in the format "U+XXXX-U+XXXX"
		/// </summary>
		public string unicodeRange;

		///<summary>
		/// The advancedAntiAliasing property determines whether to include the advanced anti-aliasing information when embedding the font. This property is optional. The default value is <see langword="true"/>.
		///</summary>
		public bool advancedAntiAliasing;

		/// <summary>
		/// New Flash Text Engine (FTE) uses Compact Font Format (CFF) fonts. Since Flex 4 embedAsCFF is set to true by default. Classic TextFormat objects are unable to use CFF fonts.
		/// </summary>
		public bool embedAsCFF;

		// image
		/// <summary>
		/// Specifies the distance, in pixels, of the upper dividing line from the top of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public int scaleGridTop;
		/// <summary>
		/// Specifies the distance in pixels of the lower dividing line from the top of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public int scaleGridBottom;
		/// <summary>
		/// Specifies the distance in pixels of the left dividing line from the left side of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public int scaleGridLeft;
		/// <summary>
		/// Specifies the distance in pixels of the right dividing line from the left side of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public int scaleGridRight;
	}
}

