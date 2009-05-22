namespace CStoFlash.Utils {
	using System.Collections.Generic;
	using System.IO;
	using System.Reflection;

	using Metaspec;

	public sealed class CsParser {
		private readonly string _output;
		private readonly INamespaceParser _parser;
		private static List<string> _errors;

		public CsParser(string pOutDir, INamespaceParser pParser) {
			_parser = pParser;
			_output = pOutDir.TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
		}

		public List<string> Parse(string[] pFiles) {
			_errors = new List<string>();
			_parser.Init();

			ICsProject project = ICsProjectFactory.create(project_namespace.pn_project_namespace);
			project.setBuildEntityModel(true);
			project.setErrorMessageCallback(addError);
			project.addFiles();

			string assemblyPath = Assembly.GetAssembly(typeof(object)).Location;
			byte[] assemblyBuffer = File.ReadAllBytes(assemblyPath);

			IExternalAssemblyModule module = IExternalAssemblyModuleFactory.create(assemblyBuffer, assemblyPath);
			project.addExternalAssemblyModules(new[] { module }, false, null);

			foreach (string fileName in pFiles) {
				char[] buffer = File.ReadAllText(fileName).ToCharArray();
				ICsFile file = ICsFileFactory.create(buffer, fileName);
				project.addFiles(file);
			}

			project.parse(true, false);

			foreach (ICsFile file in project.getFiles()) {
				CsCompilationUnit cu = file.getCompilationUnit();

				foreach (CsNamespace declaration in cu.declarations) {
					_parser.PreParse(declaration, cu.using_directives);
				}
			}

			foreach (ICsFile file in project.getFiles()) {
				CsCompilationUnit cu = file.getCompilationUnit();

				foreach (CsNamespace declaration in cu.declarations) {
					_parser.Parse(declaration, cu.using_directives, _output);
				}
			}

			return _errors;
		}


		private static void addError(string pError) {
			_errors.Add(pError);
		}
	}
}