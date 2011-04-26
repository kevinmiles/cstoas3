namespace Javascript.Global {
	using System;

	///<summary>
	///Creates a scrolling text marquee.
	///</summary>
	public class HtmlMarqueeElement : HtmlElement {
		///<summary>
		///Fires when the behavior property of the marquee object is set to "alternate" and the contents of the marquee reach one side of the window.
		///</summary>
		public Action<HtmlDomEventArgs> onbounce;
		///<summary>
		///Fires when marquee looping is complete.
		///</summary>
		public Action<HtmlDomEventArgs> onfinish;
		///<summary>
		///Fires at the beginning of every loop of the marquee object.
		///</summary>
		public Action<HtmlDomEventArgs> onstart;
		public void start() {
		}
	}
}
