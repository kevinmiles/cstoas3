namespace Javascript.Global {
	using System;

	public class HtmlWindow {
		public HtmlWindowNavigator navigator {
			get;
			private set;
		}

		/// <summary>
		/// IE only. Use event handler's argument
		/// </summary>
		public HtmlDomEventArgs @event {
			get;
			set;
		}

		public void resizeBy(int x, int y) {
		}
		///<summary>
		///Causes the element to lose focus and fires the onblur event.
		///</summary>
		public void blur() {
		}
		///<summary>
		///Sets or retrieves the distance between the top of the object and the topmost portion of the content currently visible in the window.
		///</summary>
		public int scrollTop;
		///<summary>
		///Retrieves the x-coordinate of the upper left-hand corner of the browser's client area, relative to the upper left-hand corner of the screen.
		///</summary>
		public int screenLeft {
			get;
			private set;
		}
		///<summary>
		///Retrieves the y-coordinate of the top corner of the browser's client area, relative to the top corner of the screen.
		///</summary>
		public int screenTop {
			get;
			private set;
		}
		///<summary>
		///Retrieves the frame or iframe object that is hosting the window in the parent document.
		///</summary>
		public HtmlIFrame frameElement;
		///<summary>
		///Retrieves the HtmlDocument object that is contained in this window object.
		///</summary>
		public HtmlDocument document;
		///<summary>
		///Sets or retrieves a reference to the window that created the current window.
		///</summary>
		public HtmlWindow opener;
		///<summary>
		///Retrieves the topmost ancestor window.
		///</summary>
		public HtmlWindow top;
		///<summary>
		///Retrieves the parent of the window in the object hierarchy.
		///</summary>
		public HtmlWindow parent;
		///<summary>
		///Displays a dialog box that prompts the user with a message and an input field.
		///</summary>
		///<param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
		///<param name="defaultValue">Optional. String that specifies the default value of the input field. By default, this parameter is set to "undefined".</param>
		///<returns>String or Integer. Returns the value typed in by the user.</returns>
		public string prompt(string message, string defaultValue) {
			return null;
		}
		///<summary>
		///Displays a dialog box that prompts the user with a message and an input field.
		///</summary>
		///<param name="message">Optional. String that specifies the message to display in the dialog box. By default, this parameter is set to "".</param>
		///<returns>String or Integer. Returns the value typed in by the user.</returns>
		public string prompt(string message) {
			return null;
		}
		///<summary>
		///Displays a dialog box that prompts the user with a message and an input field.
		///</summary>
		///<returns>String or Integer. Returns the value typed in by the user.</returns>
		public string prompt() {
			return null;
		}
		///<summary>
		///Invokes a method after a specified number of milliseconds has elapsed.
		///</summary>
		///<param name="action">a JsFunction to invoke</param>
		///<param name="ms">Delay, in milliseconds, before invoking the method</param>
		///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		public int setTimeout(Action action, int ms) {
			return 0;
		}

		///<summary>
		///Invokes a method after a specified number of milliseconds has elapsed.
		///</summary>
		///<param name="code">a JsFunction to invoke</param>
		///<param name="ms">Delay, in milliseconds, before invoking the method</param>
		///<returns>Integer. Returns an identifier that cancels the evaluation with the clearTimeout method.</returns>
		public int setTimeout(string code, int ms) {
			return 0;
		}
		///<summary>
		///Cancels a time-out that was set with the setTimeout method.
		///</summary>
		///<param name="id">Required. Integer that specifies the time-out setting returned by a previous call to the setTimeout method.</param>
		public void clearTimeout(int id) {
		}
		///<summary>
		///Opens a new window and loads the document specified by a given URL.
		///</summary>
		///<returns></returns>
		public HtmlWindow open() {
			return null;
		}
		///<summary>
		///Opens a new window and loads the document specified by a given URL.
		///</summary>
		///<param name="sURL">
		///String that specifies the URL of the document to display.
		///If no URL is specified, a new window with about:blank is displayed.
		///</param>
		///<returns></returns>
		public HtmlWindow open(string sURL) {
			return null;
		}
		///<summary>
		///Opens a new window and loads the document specified by a given URL.
		///</summary>
		///<param name="sURL">
		///String that specifies the URL of the document to display.
		///If no URL is specified, a new window with about:blank is displayed.
		///</param>
		///<param name="sName">
		///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		///</param>
		///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		public HtmlWindow open(string sURL, string sName) {
			return null;
		}
		///<summary>
		///Opens a new window and loads the document specified by a given URL.
		///</summary>
		///<param name="sURL">
		///String that specifies the URL of the document to display.
		///If no URL is specified, a new window with about:blank is displayed.
		///</param>
		///<param name="sName">
		///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		///</param>
		///<param name="sFeatures">
		///Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes").
		///</param>
		///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		public HtmlWindow open(string sURL, string sName, string sFeatures) {
			return null;
		}
		///<summary>
		///Opens a new window and loads the document specified by a given URL.
		///</summary>
		///<param name="sURL">
		///String that specifies the URL of the document to display.
		///If no URL is specified, a new window with about:blank is displayed.
		///</param>
		///<param name="sName">
		///Optional. String that specifies the name of the window. This name is used as the value for the TARGET attribute on a form or an anchor element.
		///</param>
		///<param name="sFeatures">
		///Optional. String that contains a list of items separated by commas. Each item consists of an option and a value, separated by an equals sign (for example, "fullscreen=yes, toolbar=yes").
		///channelmode = { yes | no | 1 | 0 }Specifies whether to display the window in theater mode. The default is no. Internet Explorer 7. channelmode = { yes | 1 } overrides height, width, top, and left values. When active, the Navigation Bar is hidden and the Title Bar is visible. The Channel Band is no longer supported in Internet Explorer 7. Prior to Internet Explorer 7 channelmode = { yes | 1 } displays the Channel Band in theatre mode.
		///directories = { yes | no | 1 | 0 }Specifies whether to add directory buttons. The default is yes. Internet Explorer 7. This feature is no longer supported.
		///fullscreen = { yes | no | 1 | 0 }Specifies whether to display the browser in full-screen mode. The default is no. Use full-screen mode carefully. Because this mode hides the browser's title bar and menus, you should always provide a button or other visual clue to help the user close the window. ALT+F4 closes the new window. Internet Explorer 7. A window in full-screen mode does not need to be in theatre mode. Prior to Internet Explorer 7 a window in full-screen mode must also be in theater mode (channelmode).
		///height = numberInternet Explorer 7. Sets the height of the window in pixels. The minimum value is 150, and specifies the minimum height of the browser content area. Prior to Internet Explorer 7 the minimum height value is 100.
		///left = numberSpecifies the left position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0.
		///location = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the navigation bar. The default is yes. Prior to Internet Explorer 7 this feature specifies whether to display the address bar. The Back, Forward, and Stop commands are now located in the Navigation bar. Prior to Internet Explorer 7 navigation commands were located in the toolbar.
		///menubar = { yes | no | 1 | 0 } Specifies whether to display the menu bar. The default is yes. Internet Explorer 7. By default the menu bar is hidden unless revealed by the ALT key. menubar = { no | 0 } prohibits the menubar from appearing even when the Alt key is pressed. The combination of menubar = { no | 0 } and toolbar = { no | 0 } hides the toolbar and disables any additional third-party user interfaces.
		///resizable = { yes | no | 1 | 0 }Specifies whether to display resize handles at the corners of the window. The default is yes. Internet Explorer 7. resizable = { no | 0 } disables tabs in a new window.
		///scrollbars = { yes | no | 1 | 0 }Specifies whether to display horizontal and vertical scroll bars. The default is yes.
		///status = { yes | no | 1 | 0 }Specifies whether to add a Status Bar at the bottom of the window. The default is yes.
		///titlebar = { yes | no | 1 | 0 }Specifies whether to display a Title Bar for the window. The default is yes. Internet Explorer 5.5 and later. This feature is no longer supported. The Title Bar remains visible unless the fullscreen sFeature is active. This parameter is ignored prior to Internet Explorer 5.5. It applies only if the calling application is an HTML Application or a trusted dialog box.
		///toolbar = { yes | no | 1 | 0 }Internet Explorer 7. Specifies whether to display the browser command bar, making buttons such as Favorites Center, Add to Favorites, and Tools available. The default is yes. The combination of menubar = { no | 0 } and toolbar = { no | 0 } turn off the Toolbar and any additional third-party user interfaces. Prior to Internet Explorer 7 the toolbar sFeature specifies whether to display the browser toolbar, making buttons such as Back, Forward, and Stop available.
		///top = numberSpecifies the top position, in pixels. This value is relative to the upper-left corner of the screen. The value must be greater than or equal to 0.
		///width = numberInternet Explorer 7. Sets the width of the window in pixels. The minimum value is 250, and specifies the minimum width of the browsers content area. Prior to Internet Explorer 7 the minimum height value is 100.
		///</param>
		///<param name="bReplace">
		///Optional. Boolean that specifies whether the sURL creates a new entry or replaces the current entry in the window's history list. This parameter only takes effect if the sURL is loaded into the same window.
		///</param>
		///<returns>Returns a reference to the new <see cref="T:SharpKit.Web.UI.HtmlMode.HtmlWindow"/> object. Use this reference to access properties and methods on the new window.</returns>
		public HtmlWindow open(string sURL, string sName, string sFeatures, bool bReplace) {
			return null;
		}
		///<summary>
		///Retrieves whether the referenced window is closed.
		///</summary>
		public bool closed;
		///<summary>
		///Closes the current browser window.
		///</summary>
		public void close() {
		}
		///<summary>
		///Contains information about the current URL.
		///</summary>
		public HtmlWindowLocation location;
		///<summary>
		///Displays a dialog box containing an application-defined message.
		///</summary>
		///<param name="message">Optional. String that specifies the message to display in the dialog box.</param>
		///<remarks>You cannot change the title bar of the Alert dialog box.</remarks>
		public void alert(object message) {
		}
		/// <summary>
		/// Displays a confirmation dialog box that contains an optional message as well as OK and Cancel buttons.
		/// </summary>
		/// <param name="message">Optional. String that specifies the message to display in the confirmation dialog box. If no value is provided, the dialog box does not contain a message.</param>
		/// <returns>Boolean. Returns one of the following possible values:
		///	<list type="table">
		///	<item>
		///		<term>true</term>
		///		<description>The user clicked the OK button.</description>
		///	</item>
		///	<item>
		///		<term>false</term>
		///		<description>The user clicked Cancel button.</description>
		/// </item>
		/// </list>
		/// </returns>
		public bool confirm(string message) {
			return false;
		}
		///<summary>
		///Provides access to predefined clipboard formats for use in editing operations.
		///</summary>
		public HtmlClipboardData clipboardData {
			get;
			private set;
		}
		///<summary>
		///Scrolls the window to the specified x- and y-offset.
		///</summary>
		///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels.</param>
		///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels.</param>
		public void scrollTo(double x, double y) {
		}
		///<summary>
		///Causes the window to scroll relative to the current scrolled position by the specified x- and y-pixel offset.
		///</summary>
		///<param name="x">Required. Integer that specifies the horizontal scroll offset, in pixels. Positive values scroll the window right, and negative values scroll it left.</param>
		///<param name="y">Required. Integer that specifies the vertical scroll offset, in pixels. Positive values scroll the window down, and negative values scroll it up.</param>
		public void scrollBy(double x, double y) {
		}
		///<summary>
		///Causes the element to receive the focus and executes the code specified by the onfocus event.
		///</summary>
		public void focus() {
		}
		///<summary>
		///Contains information about the client's screen and rendering capabilities.
		///</summary>
		public HtmlScreen screen {
			get;
			set;
		}

		public int setInterval(Action func, int ms) {
			return 0;
		}

		public int clearInterval(int ms) {
			return 0;
		}
		///<summary>
		///Binds the specified function to an event, so that the function gets called whenever the event fires on the object. IE only.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		public void attachEvent(string eventName, Action<HtmlDomEventArgs> handler) {}
		///<summary>
		///Binds the specified function to an event, so that the function gets called whenever the event fires on the object.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		///<param name="useCapture"></param>
		public void addEventListener(string eventName, Action<HtmlDomEventArgs> handler, bool useCapture) {
		}
		///<summary>
		///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires. IE only.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		public void detachEvent(string eventName, Action<HtmlDomEventArgs> handler) {
		}
		///<summary>
		///Unbinds the specified function from the event, so that the function stops receiving notifications when the event fires.
		///</summary>
		///<param name="eventName"></param>
		///<param name="handler"></param>
		///<param name="useCapture"></param>
		public void removeEventListener(string eventName, Action<HtmlDomEventArgs> handler, bool useCapture) {
		}
		///<summary>
		///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
		///</summary>
		///<param name="el">an element</param>
		///<param name="pseudoElt">a string specifying the pseudo-element to match. Must be null for regular elements.</param>
		public HtmlElementStyle getComputedStyle(HtmlElement el, string pseudoElt) {
			return null;
		}
		///<summary>
		///Returns the computed style of an element. Computed style represents the final computed values of all CSS properties for the element.
		///</summary>
		///<param name="el">an element</param>
		public HtmlElementStyle getComputedStyle(HtmlElement el) {
			return null;
		}
		///<summary>
		///The dimensions of the viewport (interior of the browser window)
		///</summary>
		public int innerWidth {
			get;
			set;
		}
		///<summary>
		///The dimensions of the viewport (interior of the browser window)
		///</summary>
		public int innerHeight {
			get;
			set;
		}
		///<summary>
		///The dimensions of the entire browser window (including taskbars and such)
		///</summary>
		public int outerWidth {
			get;
			set;
		}
		///<summary>
		///The dimensions of the entire browser window (including taskbars and such)
		///</summary>
		public int outerHeight {
			get;
			set;
		}
		///<summary>
		///The amount of pixels the entire pages has been scrolled
		///</summary>
		public int pageXOffset {
			get;
			set;
		}
		///<summary>
		///The amount of pixels the entire pages has been scrolled
		///</summary>
		public int pageYOffset {
			get;
			set;
		}
		///<summary>
		///The position of the browser window on the screen
		///</summary>
		/// <remarks>Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.</remarks>
		public int screenX {
			get;
			set;
		}
		///<summary>
		///The position of the browser window on the screen
		///</summary>
		/// <remarks>Opera calculates the coordinates of the specific tab window relative to the encompassing browser window. This is understandable given its way of working with windows, but strictly speaking it's a bug. It should give the coordinates of the encompassing browser window relative to the screen.</remarks>
		public int screenY {
			get;
			set;
		}
		///<summary>
		///Fires on the object immediately after its associated document prints or previews for printing.
		///</summary>
		public Action<HtmlDomEventArgs> onafterprint;
		///<summary>
		///Fires on the object before its associated document prints or previews for printing.
		///</summary>
		public Action<HtmlDomEventArgs> onbeforeprint;
		///<summary>
		///Fires prior to a page being unloaded.
		///</summary>
		public Action<HtmlDomEventArgs> onbeforeunload;
		///<summary>
		///Fires when the object loses the input focus.
		///</summary>
		/// <remarks>Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
		/// Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
		/// Safari iPhone does not fire the event when the window loses the focus.
		/// Konqueror doesn’t support these events on the browser window.</remarks>
		public Action<HtmlDomEventArgs> onblur;
		///<summary>
		///Fires when an error occurs during object loading.
		///</summary>
		/// <remarks>IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
		/// Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.</remarks>
		public Action<HtmlDomEventArgs> onerror;
		///<summary>
		///Fires when the object receives focus.
		///</summary>
		/// <remarks>Konqueror doesn’t support these events on the browser window.
		/// Firefox 2 and Opera fire too many events in a variety of circumstances and also incorrectly bubble them.
		/// Firefox fires a focus event whenever you click on the document.
		/// Safari and Chrome don’t support these events on links and/or form fields in all circumstances.
		/// </remarks>
		public Action<HtmlDomEventArgs> onfocus;
		///<summary>
		///Raised when there are changes to the portion of a URL that follows the number sign (#).
		///</summary>
		public Action<HtmlDomEventArgs> onhashchange;
		///<summary>
		///Fires when the user presses the F1 key while the browser is the active window.
		///</summary>
		public Action<HtmlDomEventArgs> onhelp;
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
		///<summary>
		///Fires when the size of the object is about to change.
		///</summary>
		public Action<HtmlDomEventArgs> onresize;
		///<summary>
		///Fires when the user repositions the scroll box in the scroll bar on the object.
		///</summary>
		/// <remarks>Safari probably monitors scrollTop access in order to determine whether the user has scrolled an element with overflow: auto.</remarks>
		public Action<HtmlDomEventArgs> onscroll;
		///<summary>
		///Fires immediately before the object is unloaded.
		///</summary>
		public Action<HtmlDomEventArgs> onunload;
		public HtmlWindow self {
			get;
			set;
		}
		public string name {
			get;
			set;
		}
		public History history {
			get;
			set;
		}

		public new object this[string name] {
			get {
				return null;
			}
			set {
			}
		}

		public string appVersion {
			get;
			private set;
		}
		public string platform {
			get;
			private set;
		}
		public string userAgent {
			get;
			private set;
		}
		public object dialogArguments {
			get;
			private set;
		}
		public string returnValue {
			get;
			set;
		}
	}
}
