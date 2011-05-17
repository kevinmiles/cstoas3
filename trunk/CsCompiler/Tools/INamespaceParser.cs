namespace CsCompiler.Tools {
	using System.Collections.Generic;
	using Metaspec;

	public interface INamespaceParser {
		void PreBuildEvents(ICsProject pProject, string pPathToCompiler, bool pDebug);
		void Parse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder);
		void PostBuildEvents(bool pDebug, Dictionary<string, string> pArguments, out string pOutput, out ICollection<Error> pErrors);
	}
}
