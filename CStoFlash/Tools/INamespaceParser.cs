namespace CStoFlash.Tools {
	using System.Collections.Generic;
	using Metaspec;
	using VsProjectParser;

	public interface INamespaceParser {
		void PreBuildEvents(ICsProject pProject, bool pDebug);
		void Parse(CsNamespace pNamespace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder);
		void PostBuildEvents(bool pDebug);
		void HandleAdditionalProjectFiles(VsProject pProject);
	}
}
