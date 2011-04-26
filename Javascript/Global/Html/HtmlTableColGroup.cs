namespace Javascript.Global {
	///<summary>
	///Specifies property defaults for a column or group of columns in a table.
	///</summary>
	public class HtmlTableColGroup : HtmlElement {
		protected HtmlTableColGroup() {
		}
		///<summary>
		///String that specifies or receives one of the following values.
		///</summary>
		///<remarks>
		///<list type="table">
		///<item><term>middle</term><description>Default. Aligns the text in the middle of the object.</description></item>
		///<item><term>baseline</term><description>Aligns the base line of the first line of text with the base lines in adjacent objects.</description></item>
		///<item><term>bottom</term><description>Aligns the text at the bottom of the object.</description></item>
		///<item><term>top</term><description>Aligns the text at the top of the object.</description></item>
		///</list>
		///</remarks>
		public string vAlign {
			get;
			set;
		}
	}
}
