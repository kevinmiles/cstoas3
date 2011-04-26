namespace Javascript.Global {
	using System;

	///<summary>
	///Tag: HTML. Represents the root element of a HTML document.
	///</summary>
	public class HtmlDocumentElement : HtmlElement {
		///<summary>
		///Gets the object that has the focus when the parent document has focus.
		///</summary>
		public object activeElement {
			get;
			set;
		}
		///<summary>
		///Sets or gets the color of all active links in the document.
		///</summary>
		public string alinkColor {
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
		///<summary>
		///Retrieves the collection of user agents and versions declared in the X-UA-Compatible
		///</summary>
		public object compatible {
			get;
			set;
		}
		/// <summary>
		/// Gets a value that indicates whether standards-compliant mode is switched on for the object.
		/// Possible values:
		///	BackCompat	Standards-compliant mode is not switched on.
		/// CSS1Compat	Standards-compliant mode is switched on.
		/// </summary>
		public object compatMode {
			get;
			set;
		}
		///<summary>
		///Sets or gets the string value of a cookie.
		///specifies or receives the name=value; pairs, plus any of the values listed in Possible Values.
		///Possible Values:
		///expires=date;
		///If you set no expiration date on a cookie, it expires when the browser closes. If you set an expiration date, the cookie is saved across browser sessions. If you set an expiration date in the past, the cookie is deleted. Use Greenwich Mean Time (GMT) format to specify the date.
		///domain=domainname;
		///If you set the domain of the cookie, pages on a domain made up of more than one server can share cookie information.
		///path=path;
		///If you set a path for the cookie, the current document can share cookie information with other pages within the same domain—that is, if the path is set to /thispathname, all pages in /thispathname and all pages in subfolders of /thispathname can access the same cookie information.
		///secure;
		///If you set a cookie as secure;, the stored cookie information can be accessed only from Secure Hypertext Transfer Protocol (HTTPS).
		///</summary>
		public object cookie {
			get;
			set;
		}
		///<summary>
		///Gets the default character set from the current regional language settings.
		///</summary>
		public string defaultCharset {
			get;
			set;
		}
		///<summary>
		///Sets or gets a value that indicates whether the document can be edited.
		///Possible Values:
		///On							Document can be edited.
		///Off | Inherit		Default. Document cannot be edited.
		///</summary>
		public string designMode {
			get;
			set;
		}
		///<summary>
		///Gets the document type declaration associated with the current document.
		///Possible values:
		///ltr		Default. Content flows from left to right.
		///rtl		Content flows from right to left.
		///</summary>
		public string doctype {
			get;
			set;
		}
		///<summary>
		///Gets a reference to the root node of the document.
		///</summary>
		public HtmlElement documentElement {
			get;
			set;
		}
		/// <summary>
		/// Retrieves the document compatibility mode of the document.
		/// Possible values:
		///	5		Microsoft Internet Explorer 5 mode (also known as "quirks mode").
		/// 7		Internet Explorer 7 Standards mode.
		/// 8   Internet Explorer 8 Standards mode.
		/// </summary>
		public Double documentMode {
			get;
			set;
		}
		///<summary>
		///Sets or gets the security domain of the document.
		///</summary>
		public object domain {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value indicating whether arbitrary variables can be created within the object.
		///Possible values:
		///true	Default. Creation of arbitrary variables is allowed.
		///false	Creation of arbitrary variables is not allowed.
		///</summary>
		public bool expando {
			get;
			set;
		}
		///<summary>
		///Sets or gets the foreground (text) color of the document.
		///</summary>
		public bool fgColor {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was created.
		///</summary>
		public string fileCreatedDate {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was last modified.
		///</summary>
		public string fileModifiedDate {
			get;
			set;
		}
		///<summary>
		///Retrieves the file size.
		///</summary>
		public string fileSize {
			get;
			set;
		}
		///<summary>
		///Retrieves the date the file was last updated.
		///</summary>
		public string fileUpdatedDate {
			get;
			set;
		}
		///<summary>
		///Gets the implementation object of the current document.
		///</summary>
		public HtmlDomImplementation implementation {
			get;
			set;
		}
		///<summary>
		///Gets the date that the page was last modified, if the page supplies one.
		///</summary>
		public string lastModified {
			get;
			set;
		}
		///<summary>
		///Sets or gets the color of the document links.
		///</summary>
		public string linkColor {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the media type.
		///Possible Values:
		///screen		Output is intended for computer screens.
		///print			Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
		///all				Default. Applies to all devices.
		///</summary>
		public string media {
			get;
			set;
		}
		///<summary>
		///Retrieves the file name specified in the href or src property of the object.
		///</summary>
		public string nameProp {
			get;
			set;
		}
		///<summary>
		///Gets a reference to the container object of the window.
		///</summary>
		public object parentWindow {
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
		///Retrieves a value that indicates the current state of the object.
		///Possible Values:
		///uninitialized		Object is not initialized with data.
		///loading					Object is loading its data.
		///loaded					Object has finished loading its data.
		///interactive			User can interact with the object even though it is not fully loaded.
		///complete				Object is completely initialized.
		///</summary>
		public string readyState {
			get;
			set;
		}
		///<summary>
		///Gets the URL of the location that referred the user to the current page.
		///</summary>
		public string referrer {
			get;
			set;
		}
		///<summary>
		///Sets or gets the URL for the current document.
		///</summary>
		public string URL {
			get;
			set;
		}
		///<summary>
		///Gets the URL for the document, stripped of any character encoding.
		///</summary>
		public string URLUnencoded {
			get;
			set;
		}
		///<summary>
		///Sets or gets the color of the links that the user has visited.
		///</summary>
		public string vLinkColor {
			get;
			set;
		}
	}
}
