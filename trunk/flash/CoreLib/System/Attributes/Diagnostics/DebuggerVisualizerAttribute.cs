namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Assembly,
		AllowMultiple = true), ComVisible(true)]
	
	public sealed class DebuggerVisualizerAttribute : Attribute {
		private readonly string visualizerName;
		private readonly string visualizerSourceName;
		private string description;
		private Type target;
		private string targetTypeName;

		public DebuggerVisualizerAttribute(string visualizerTypeName) {
			visualizerName = visualizerTypeName;
		}

		public DebuggerVisualizerAttribute(Type visualizer) {
			if (visualizer == null) {
				throw new Exception();
			}


		}

		public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName) {
			visualizerName = visualizerTypeName;
			visualizerSourceName = visualizerObjectSourceTypeName;
		}

		public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource) {
			if (visualizerObjectSource == null) {
				throw new Exception();
			}

			visualizerName = visualizerTypeName;
		}

		public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName) {
			if (visualizer == null) {
				throw new Exception();
			}

			visualizerSourceName = visualizerObjectSourceTypeName;
		}

		public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource) {
			if (visualizer == null) {
				throw new Exception();
			}
			if (visualizerObjectSource == null) {
				throw new Exception();
			}

			
		}

		public string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		public Type Target {
			get {
				return target;
			}
			set {
				target = value;
			}
		}

		public string TargetTypeName {
			get {
				return targetTypeName;
			}
			set {
				targetTypeName = value;
			}
		}

		// Debugged program-side type
		public string VisualizerObjectSourceTypeName {
			get {
				return visualizerSourceName;
			}
		}

		// Debugger-side type
		public string VisualizerTypeName {
			get {
				return visualizerName;
			}
		}
	}
}