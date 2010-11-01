namespace CStoFlash.Tools {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Text;

	internal class ExecuteProcess {
		private readonly Dictionary<string, List<string>> _arguments = new Dictionary<string, List<string>>();
		private readonly List<string> _defaultValues = new List<string>();

		private readonly string _fileName;
		private Process _process;

		public ExecuteProcess(string pFilename) {
			_fileName = pFilename;
			ArgumentPrefix = "-";
			ArgumentSeparator = " ";
			ArgumentValueSeparator = "=";
			MultiValueSeparator = ",";
		}

		public string MultiValueSeparator { get; set; }
		public string ArgumentValueSeparator { get; set; }
		public string ArgumentSeparator { get; set; }
		public string ArgumentPrefix { get; set; }

		public string Error { get; private set; }
		public string Output { get; private set; }

		private void addArgument(string pName, string pValue) {
			if (string.IsNullOrEmpty(pName)) {
				_defaultValues.Add(pValue);
				return;
			}
			
			if (_arguments.ContainsKey(pName)) {
				_arguments[pName].Add(pValue);

			} else {
				_arguments[pName] = new List<string> {
					pValue
				};
			}
		}

		public void AddArgument(string pArgument) {
			addArgument(null, pArgument);
		}

		public void AddArgument(string pArgument, string pValue) {
			addArgument(pArgument, pValue);
		}

		public bool Execute(string pWorkingDirectory) {
			StringBuilder args = new StringBuilder();

			foreach (var argument in _arguments) {
				args.Append(ArgumentPrefix);
				args.Append(argument.Key);
				args.Append(ArgumentValueSeparator);	
				args.Append(string.Join(MultiValueSeparator, argument.Value));
				args.Append(ArgumentSeparator);
			}

			args.Append(string.Join(ArgumentSeparator, _defaultValues));

			_process = new Process {
				StartInfo = {
					UseShellExecute = false,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					StandardOutputEncoding = Encoding.Default,
					StandardErrorEncoding = Encoding.Default,
					CreateNoWindow = true,
					FileName = _fileName,
					Arguments = args.ToString().Trim(),
					WorkingDirectory = pWorkingDirectory
				}
			};

			try {
				_process.Start();
			} catch (Exception ex) {
				_process = null;
				Error = string.Format(@"Unable to start {0}: {1}", _fileName, ex.Message);
				return true;
			}

			Output = _process.StandardOutput.ReadToEnd();
			Error = _process.StandardError.ReadToEnd();

			_process.WaitForExit();

			return !string.IsNullOrEmpty(Error);
		}
	}
}
