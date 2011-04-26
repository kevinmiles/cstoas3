namespace Javascript.Global {
	///<summary>
	///Contains information about the current URL.
	///</summary>
	public class HtmlWindowLocation {
		///<summary>
		///Sets or retrieves the entire URL as a string.
		///</summary>
		public string href {
			get;
			set;
		}
		///<summary>
		///reloads the current page.
		///</summary>
		public void reload() {
		}
		///<summary>
		///Sets or retrieves the subsection of the href property that follows the number sign (#).
		///</summary>
		public string hash {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the hostname and port number of the location or URL.
		///</summary>
		public string host {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the host name part of the location or URL.
		///</summary>
		public string hostname {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the file name or path specified by the object.
		///</summary>
		public string pathname {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the port number associated with a URL.
		///</summary>
		public string port {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the protocol portion of a URL.
		///</summary>
		public string protocol {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the substring of the href property that follows the question mark.
		///</summary>
		public string search {
			get;
			set;
		}
		///<summary>
		///Replaces the current document by loading another document at the specified URL.
		///</summary>
		public void assign(string url) {
		}
		/// <summary>
		///Replaces the current document by loading another document at the specified URL.
		/// </summary>
		public void replace(string url) {
		}
		public string resolveURL(string url) {
			return null;
		}
	}
}
