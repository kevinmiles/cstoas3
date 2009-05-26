namespace flash {
	using System;

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = false)]
	internal sealed class As3NameAttribute : Attribute {
		public As3NameAttribute(string pAs3Name) {

		}
	}

	[AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
	internal sealed class As3IsGeneric : Attribute {
		public As3IsGeneric(bool pIsGeneric) {

		}
	}
}