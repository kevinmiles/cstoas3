namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module), ComVisible(true)]
	
	public sealed class DebuggableAttribute : Attribute {
		#region DebuggingModes enum
		[Flags, ComVisible(true)]
		
		public enum DebuggingModes {
			// Fields
			None = 0,
			Default = 1,
			IgnoreSymbolStoreSequencePoints = 2,
			EnableEditAndContinue = 4,
			DisableOptimizations = 256
		}
		#endregion

		private readonly bool JITOptimizerDisabledFlag;
		private readonly bool JITTrackingEnabledFlag;

		private readonly DebuggingModes debuggingModes = DebuggingModes.None;

		// Public Instance Constructors
		public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled) {
			JITTrackingEnabledFlag = isJITTrackingEnabled;
			JITOptimizerDisabledFlag = isJITOptimizerDisabled;

			if (isJITTrackingEnabled) {
				debuggingModes |= DebuggingModes.Default;
			}

			if (isJITOptimizerDisabled) {
				debuggingModes |= DebuggingModes.DisableOptimizations;
			}
		}

		public DebuggableAttribute(DebuggingModes modes) {
			debuggingModes = modes;
			JITTrackingEnabledFlag = (debuggingModes & DebuggingModes.Default) != 0;
			JITOptimizerDisabledFlag = (debuggingModes & DebuggingModes.DisableOptimizations) != 0;
		}

		public DebuggingModes DebuggingFlags {
			get {
				return debuggingModes;
			}
		}

		// Public Instance Properties
		public bool IsJITTrackingEnabled {
			get {
				return JITTrackingEnabledFlag;
			}
		}

		public bool IsJITOptimizerDisabled {
			get {
				return JITOptimizerDisabledFlag;
			}
		}
	}
}