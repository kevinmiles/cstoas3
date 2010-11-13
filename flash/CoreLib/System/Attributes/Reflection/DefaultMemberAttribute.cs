namespace System.Reflection {
	using ComponentModel;

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class DefaultMemberAttribute {
		// Fields
		private string _memberName;

		// Methods
		public DefaultMemberAttribute(string memberName) {
			this._memberName = memberName;
		}

		// Properties
		public string MemberName {
			get {
				return this._memberName;
			}
		}
	}
}