namespace CsCompiler.Tools {
	using CsCompiler.CsParser;
	using Metaspec;

	public class Expression {
		public Expression() {
			Value = "";
			Type = null;
		}

		public Expression(string pValue, CsEntityTypeRef pType) {
			Value = pValue;
			Type = pType;
		}

		public Expression(string pValue, CsEntityTypeRef pType, bool pIsInternal) {
			Value = pValue;
			Type = pType;
			InternalType = pIsInternal;
		}

		public string Value {
			get;
			set;
		}

		public CsEntityTypeRef Type {
			get;
			set;
		}

		public bool IsAs3Generic {
			get {
				CsEntityType t = Type.getType();
				return t != null && Helpers.HasAttribute(t.attributes, "As3IsGenericAttribute");
			}
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