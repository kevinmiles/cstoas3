namespace System.Diagnostics.CodeAnalysis {
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	internal sealed class SuppressMessageAttribute : Attribute {
		public SuppressMessageAttribute(string category, string checkId) {
			Category = category;
			CheckId = checkId;
		}

		public string Category {
			get;
			private set;

		}

		public string CheckId {
			get;
			private set;
		}

		public string Justification {
			get;
			set;
		}

		public string MessageId {
			get;
			set;
		}

		public string Scope {
			get;
			set;
		}

		public string Target {
			get;
			set;
		}
	}
}