namespace Javascript.Global {
	using System;

	///<summary>
	///Represents a STYLE html node
	///</summary>
	public class HtmlStyleElement : HtmlElement {
		protected HtmlStyleElement() {
		}
		///<summary>
		///Sets or retrieves the MIME type of the object. e.g. 'text/css'
		///</summary>
		public string type {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the media type.
		///</summary>
		///<remarks>Possible values:
		///screen - Output is intended for computer screens.
		///print - Output is intended for printed material and for on-screen documents viewed in Print Preview mode.
		///all - Default. Applies to all devices.</remarks>
		public string media {
			get;
			set;
		}
		///<summary>
		///Retrieves the next object in the HTML hierarchy.
		///</summary>
		public HtmlElement owningElement {
			get;
			set;
		}
		///<summary>
		///Retrieves the style sheet that imported the current style sheets.
		///</summary>
		public HtmlStyleElement parentStyleSheet {
			get;
			set;
		}
		///<summary>
		///Retrieves whether the rule or style sheet is defined on the page or is imported.
		///</summary>
		public bool readOnly {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the title of the style sheet.
		///</summary>
		public new string title {
			get;
			set;
		}
		///<summary>
		///Retrieves a collection of all the imported style sheets defined for the respective styleSheet object. IE only.
		///</summary>
		public HtmlNodeCollection<HtmlStyleElement> imports {
			get;
			set;
		}
		///<summary>
		///Retrieves a collection of page objects, which represent @page rules in a styleSheet.
		///</summary>
		public HtmlGenericCollection<HtmlStyleSheetPage> pages {
			get;
			set;
		}
		///<summary>
		///Retrieves a collection of rules defined in a style sheet.
		///</summary>
		/// <remarks>IE doesn't count @imports as rules, but splits up selectors like p#test, ul into two rules.</remarks>
		public HtmlGenericCollection<HtmlCssRule> rules {
			get;
			set;
		}
		///<summary>
		///Retrieves a collection of rules defined in a style sheet.
		///</summary>
		/// <remarks>Use rules in IE</remarks>
		public HtmlGenericCollection<HtmlCssRule> cssRules {
			get;
			set;
		}
		///<summary>
		///Creates a new rule for a style sheet.
		///</summary>
		///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
		///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
		///<param name="iIndex">Integer that specifies the zero-based position in the rules collection where the new style rule should be placed.
		///-1 by Default. The rule is added to the end of the collection.</param>
		///<returns>-1 (Reserved value)</returns>
		public int addRule(string cSelector, string cStyle, int iIndex) {
			return 0;
		}
		///<summary>
		///Creates a new rule for a style sheet.
		///</summary>
		///<param name="cSelector">String that specifies the selector for the new rule. Single contextual selectors are valid. For example, "div p b" is a valid contextual selector.</param>
		///<param name="cStyle">String that specifies the style assignments for this style rule. This style takes the same form as an inline style specification. For example, "color:blue" is a valid style parameter.</param>
		///<returns>-1 (Reserved value)</returns>
		public int addRule(string cSelector, string cStyle) {
			return 0;
		}
		///<summary>
		///Inserts a new style rule into the current style sheet.
		///</summary>
		///<param name="rule">a string containing the rule to be inserted (selector and declaration).</param>
		///<param name="index">a number representing the position to be inserted.</param>
		///<returns>The index within the style sheet's rule collection of the newly inserted rule.</returns>
		public int insertRule(string rule, int index) {
			return 0;
		}
		///<summary>
		///Used to delete a rule from the style sheet.
		///</summary>
		///<param name="index">The index within the style sheet's rule list of the rule to remove.</param>
		public void deleteRule(ulong index) {
		}
		///<summary>
		///Deletes an existing style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
		///</summary>
		///<param name="iIndex">Integer that specifies the index value of the rule to be deleted from the style sheet.</param>
		public void removeRule(int iIndex) {
		}
		///<summary>
		///Deletes the first style rule for the styleSheet object, and adjusts the index of the rules collection accordingly.
		///</summary>
		public void removeRule() {
		}
		///<summary>
		///Sets or retrieves the persisted representation of the style rule. IE Only.
		///</summary>
		public string cssText {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves a value that indicates whether the user can interact with the object.
		///</summary>
		public new bool disabled {
			get;
			set;
		}
		///<summary>
		///The URL of the linked style sheet.
		///</summary>
		public string href {
			get;
			set;
		}
		///<summary>
		///Returns the node that associates this style sheet with the document. Usually a &lt;link&gt; or a &lt;style&gt; tag.
		///</summary>
		public HtmlNode ownerNode {
			get;
			set;
		}
		///<summary>
		///Fires when an error occurs during object loading.
		///</summary>
		/// <remarks>IE and Firefox have trouble with JavaScript errors in the traditional event registration model.
		/// Safari, Chrome, Opera and Konqueror do not support this event on JavaScript errors.</remarks>
		public Action<HtmlDomEventArgs> onerror;
		///<summary>
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
	}
}
