namespace CStoFlash.Tools {
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using Metaspec;
	using VsProjectParser;

	public sealed class CsParser {
		private readonly string _output;
		private readonly INamespaceParser _parser;
		private static List<string> _errors;

		public CsParser(string pOutDir, INamespaceParser pParser) {
			_parser = pParser;
			_output = pOutDir.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
		}

		public void HandleAdditionalProjectFiles(VsProject pProject) {
			if (pProject == null) return;
			_parser.HandleAdditionalProjectFiles(pProject);
		}

		public List<string> Parse(string[] pFiles, bool pDebug) {
			_errors = new List<string>();

			ICsProject project = ICsProjectFactory.create(project_namespace.pn_project_namespace);
			project.setBuildEntityModel(true);
			project.setErrorMessageCallback(addError);
			project.addFiles();

			_parser.PreBuildEvents(project, pDebug);

			foreach (ICsFile file in from fileName in pFiles
			                         let buffer = File.ReadAllText(fileName).ToCharArray()
			                         select ICsFileFactory.create(buffer, fileName)) {
				project.addFiles(file);
			}

			project.parse(true, false);

			foreach (ICsFile file in project.getFiles()) {
				CsCompilationUnit cu = file.getCompilationUnit();

				foreach (CsNamespace declaration in cu.declarations) {
					_parser.Parse(declaration, cu.using_directives, _output);
				}
			}

			if (_errors.Count == 0) {
				_parser.PostBuildEvents(pDebug);
			}

			return _errors;
		}

		private static void addError(string pError) {
			_errors.Add(pError);
		}
	}
}