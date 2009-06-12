namespace flash.text {
	public class TextFormat {
		/// <summary>
		/// Indicates the alignment of the paragraph.
		/// <summary>
		public TextFormatAlign align {
			get;
			set;
		}

		/// <summary>
		/// Indicates the block indentation in pixels.
		/// <summary>
		public double blockIndent {
			get;
			set;
		}

		/// <summary>
		/// Specifies whether the text is boldface.
		/// <summary>
		public bool bold {
			get;
			set;
		}

		/// <summary>
		/// Indicates that the text is part of a bulleted list.
		/// <summary>
		public bool bullet {
			get;
			set;
		}

		/// <summary>
		/// Indicates the color of the text.
		/// <summary>
		public uint color {
			get;
			set;
		}

		/// <summary>
		/// The name of the font for text in this text format, as a string.
		/// <summary>
		public string font {
			get;
			set;
		}

		/// <summary>
		/// Indicates the indentation from the left margin to the first character in the paragraph.
		/// <summary>
		public double indent {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether text in this text format is italicized.
		/// <summary>
		public bool italic {
			get;
			set;
		}

		/// <summary>
		/// A Boolean value that indicates whether kerning is enabled (true) or disabled (false).
		/// <summary>
		public bool kerning {
			get;
			set;
		}

		/// <summary>
		/// An integer representing the amount of vertical space (called leading) between lines.
		/// <summary>
		public int leading {
			get;
			set;
		}

		/// <summary>
		/// The left margin of the paragraph, in pixels.
		/// <summary>
		public double leftMargin {
			get;
			set;
		}

		/// <summary>
		/// A number representing the amount of space that is uniformly distributed between all characters.
		/// <summary>
		public double letterSpacing {
			get;
			set;
		}

		/// <summary>
		/// The right margin of the paragraph, in pixels.
		/// <summary>
		public double rightMargin {
			get;
			set;
		}

		/// <summary>
		/// The point size of text in this text format.
		/// <summary>
		public double size {
			get;
			set;
		}

		/// <summary>
		/// Specifies custom tab stops as an array of non-negative integers.
		/// <summary>
		public uint[] tabStops {
			get;
			set;
		}

		/// <summary>
		/// Indicates the target window where the hyperlink is displayed.
		/// <summary>
		public string target {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the text that uses this text format is underlined (true) or not (false).
		/// <summary>
		public bool underline {
			get;
			set;
		}

		/// <summary>
		/// Indicates the target URL for the text in this text format.
		/// <summary>
		public string url {
			get;
			set;
		}

		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target, TextFormatAlign align, double leftMargin, double rightMargin, double indent, int leading){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target, TextFormatAlign align, double leftMargin, double rightMargin, double indent){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target, TextFormatAlign align, double leftMargin, double rightMargin){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target, TextFormatAlign align, double leftMargin){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target, TextFormatAlign align){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url, string target){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline, string url){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic, bool underline){}
		public TextFormat(string font, double size, uint color, bool bold, bool italic){}
		public TextFormat(string font, double size, uint color, bool bold){}
		public TextFormat(string font, double size, uint color){}
		public TextFormat(string font, double size){}
		public TextFormat(string font){}
		public TextFormat(){}
	}
}