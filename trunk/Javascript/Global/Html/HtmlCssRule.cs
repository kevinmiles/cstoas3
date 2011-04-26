namespace Javascript.Global {
	///<summary>
	///Represents a style within a Cascading Style Sheets (CSS) that consists of a selector and one or more declarations.
	///</summary>
	public partial class HtmlCssRule {
		///<summary>
		///Retrieves whether the rule or style sheet is defined on the page or is imported.
		///</summary>
		public bool readOnly {
			get;
			set;
		}
		///<summary>
		///Retrieves a string that identifies which elements the corresponding style sheet rule applies to.
		///</summary>
		public string selectorText {
			get;
			set;
		}
		///<summary>
		///Represents the current settings of all possible inline styles for a given element.
		///</summary>
		public HtmlElementStyle style {
			get;
			set;
		}
		///<summary>
		///Sets or retrieves the persisted representation of the style rule.
		///</summary>
		public string cssText {
			get;
			set;
		}
		///<summary>
		///Returns the stylesheet object in which the current rule is defined.
		///</summary>
		public HtmlStyleElement parentStyleSheet {
			get;
			set;
		}
	}
}
