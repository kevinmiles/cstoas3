namespace System.ComponentModel {
	public enum EditorBrowsableState {
		/// <summary>
		/// 	The property or method is always browsable from within an editor.
		/// </summary>
		Always = 0,
		/// <summary>
		/// 	The property or method is never browsable from within an editor.
		/// </summary>
		Never = 1,
		/// <summary>
		/// 	The property or method is a feature that only advanced users should see. An editor can either show or hide such properties.
		/// </summary>
		Advanced = 2
	}

	[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Enum |
		AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method |
		AttributeTargets.Property | AttributeTargets.Struct)]
	public sealed class EditorBrowsableAttribute : Attribute {
		private readonly EditorBrowsableState state;

		public EditorBrowsableAttribute() {
			state = EditorBrowsableState.Always;
		}

		public EditorBrowsableAttribute(EditorBrowsableState state) {
			this.state = state;
		}

		public EditorBrowsableState State {
			get {
				return state;
			}
		}
	}
}