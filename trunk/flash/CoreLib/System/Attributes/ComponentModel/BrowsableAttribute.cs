namespace System.ComponentModel {
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute {
		public static readonly BrowsableAttribute Default = new BrowsableAttribute(true);
		public static readonly BrowsableAttribute No = new BrowsableAttribute(false);
		public static readonly BrowsableAttribute Yes = new BrowsableAttribute(true);
		private readonly bool browsable;

		public BrowsableAttribute(bool browsable) {
			this.browsable = browsable;
		}

		public bool Browsable {
			get {
				return browsable;
			}
		}
	}
}