namespace Javascript.Global {
	public class HtmlScript : HtmlElement {
		///<summary>
		///Retrieves the URL to an external file that contains the source code or data.
		///</summary>
		public string src {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the MIME type for the associated scripting engine.
		///</summary>
		public string type {
			get;
			set;
		}
		public string language {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the character set used to encode the object.
		///</summary>
		public string charset {
			get;
			set;
		}
		/// <summary>
		/// Sets or retrieves the status of the script.
		/// Possible values:
		///	false		Default. Inline executable function is not deferred.
		/// true		Inline executable function is deferred.
		/// </summary>
		public bool defer {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the event for which the script is written.
		///</summary>
		public string @event {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the object that is bound to the event script.
		///</summary>
		public string htmlFor {
			get;
			set;
		}
		///<summary>
		///Retrieves or sets the text of the object as a string.
		///</summary>
		public string text {
			get;
			set;
		}
	}
}
