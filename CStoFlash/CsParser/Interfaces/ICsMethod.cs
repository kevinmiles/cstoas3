using System.Collections.Generic;

namespace CStoFlash.CsParser.Interfaces {
	interface ICsMethod : ICsNode, ICsHasCodeBlock{
		TheClass MyClass {
			get;
		}

		string Signature {
			get;
		}

		List<TheMethodArgument> Arguments {
			get;
		}
	}
}
