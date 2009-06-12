namespace flash.net {
	public class FileFilter {
		/// <summary>
		/// The description string for the filter.
		/// </summary>
		public string description {
			get;
			set;
		}

		/// <summary>
		/// A list of file extensions.
		/// </summary>
		public string extension {
			get;
			set;
		}

		/// <summary>
		/// A list of Macintosh file types.
		/// </summary>
		public string macType {
			get;
			set;
		}

		/// <summary>
		/// Creates a new FileFilter instance.
		/// </summary>
		public FileFilter(string description, string extension, string macType) {}

		/// <summary>
		/// Creates a new FileFilter instance.
		/// </summary>
		public FileFilter(string description, string extension) {}
	}
}