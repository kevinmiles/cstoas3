namespace System.Reflection {
	using ComponentModel;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class DefaultMemberAttribute {
		// Fields

		// Methods
		public DefaultMemberAttribute(string memberName) {
			MemberName = memberName;
		}

		public DefaultMemberAttribute() {}

		// Properties
		public string MemberName {
			get;
			private set;
		}
	}
}