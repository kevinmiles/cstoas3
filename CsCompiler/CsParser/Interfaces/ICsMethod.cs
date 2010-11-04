namespace CsCompiler.CsParser.Interfaces {
	using System.Collections.Generic;

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
