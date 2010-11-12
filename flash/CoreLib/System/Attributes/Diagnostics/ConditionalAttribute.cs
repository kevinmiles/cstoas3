namespace System.Diagnostics {
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ConditionalAttribute : Attribute {
		public ConditionalAttribute(string conditionString) {
			ConditionString = conditionString;
		}

		public string ConditionString {
			get;
			private set;
		}
	}
}