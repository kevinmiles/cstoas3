namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(AttributeTargets.Field | AttributeTargets.Property), ComVisible(true)]	
	public sealed class DebuggerBrowsableAttribute : Attribute {
		private readonly DebuggerBrowsableState state;

		public DebuggerBrowsableAttribute(DebuggerBrowsableState state) {
			this.state = state;
		}

		public DebuggerBrowsableState State {
			get {
				return state;
			}
		}
	}

	// XXX make sure this matches MS's enum
	[ComVisible(true)]
	public enum DebuggerBrowsableState {
		Never = 0,
		Collapsed = 2,
		RootHidden = 3
	} 
}