namespace Javascript.Global {
	using System;

	///<summary>
	///Specifies a frameset, which is used to organize multiple frames and nested framesets.
	///</summary>
	public class HtmlFrameSetElement : HtmlElement {
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
		///Fires immediately after the browser loads the object.
		///</summary>
		public Action<HtmlDomEventArgs> onload;
		///<summary>
		///Fires immediately before the object is unloaded.
		///</summary>
		public Action<HtmlDomEventArgs> onunload;
	}
}
