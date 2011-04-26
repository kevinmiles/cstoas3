namespace Javascript.Global {
	///<summary>
	///Denotes a paragraph.
	///</summary>
	public class HtmlParagraph : HtmlDiv {
		protected HtmlParagraph() {
		}
		/// <summary>
		/// Sets or retrieves the side on which floating objects are not to be positioned when any IHTMLBlockElement is inserted into the document.
		/// Possible Values:
		/// all		Object is moved below any floating object.
		/// left	Object is moved below any floating object on the left side.
		///	right Object is moved below any floating object on the right side.
		///	none	Floating objects are allowed on all sides.
		/// </summary>
		public string clear {
			get;
			set;
		}
	}
}
