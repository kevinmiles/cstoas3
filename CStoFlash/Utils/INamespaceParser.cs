namespace CStoFlash.Utils {
	using System.Collections.Generic;

	using Metaspec;

	public interface INamespaceParser {
		void Init();
		void Parse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder);
		void PreParse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing);
	}
}
