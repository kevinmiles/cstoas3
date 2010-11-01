namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
	public sealed class As3EventAttribute : Attribute {
		public As3EventAttribute(string eventName) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class As3MainClassAttribute : Attribute {
		public As3MainClassAttribute(int pWidth, int pHeight, int pFrameRate, uint pBackgroundColor) {
			return;
		}
	}


	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = false)]
	internal sealed class As3NameAttribute : Attribute {
		public As3NameAttribute(string pAs3Name) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = false)]
	internal sealed class As3NamespaceAttribute : Attribute {
		public As3NamespaceAttribute(string pAs3Namespace) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
	internal sealed class As3IsGenericAttribute : Attribute {
		public As3IsGenericAttribute(bool pIsGeneric) {
			return;
		}
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal sealed class As3AsObjectAttribute : Attribute {
		
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
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

		// font
		public string systemFont;
		public string fontName;
		public string fontWeight;
		public string fontStyle;
		public string fontFamily;
		public string unicodeRange;
		public string advancedAntiAliasing;


		// image
		/// <summary>
		/// Specifies the distance, in pixels, of the upper dividing line from the top of the image in a scale-9 formatting system. The distance is relative to the original, unscaled size of the image.
		/// </summary>
		public string scaleGridTop;
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
	}
}

