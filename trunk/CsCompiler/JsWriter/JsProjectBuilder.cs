namespace CsCompiler.JsWriter {
	using System.Collections.Generic;
	using Tools;

	internal sealed class JsProjectBuilder {
		public JsProjectBuilder(string pFlexsdkPath) {
			
		
		}

		public ICollection<Error> Compile(string pWorkingdir, string pArguments, bool pConfigChanged, out string pOutput) {
			pOutput = null;
			return new List<Error>();
		}
	}
}
