namespace CStoFlash.Utils {
	public class Expression {
		public Expression() {
			Value = Type = "";
		}

		public Expression(string pValue, string pType) {
			Value = pValue;
			Type = pType;
		}

		public Expression(string pValue, string pType, bool pIsInternal) {
			Value = pValue;
			Type = pType;
			InternalType = pIsInternal;
		}

		public string Value {
			get;
			set;
		}

		public string Type {
			get;
			set;
		}

		public bool InternalType {
			get;
			set;
		}

		public override string ToString() {
			return Value;
		}
	}
}