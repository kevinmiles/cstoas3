namespace CsCompiler.Tools {
	using System.Collections.Generic;
	using System.Text;

	internal class ProcessArguments {
		private readonly Dictionary<string, List<string>> _arguments = new Dictionary<string, List<string>>();
		private readonly List<string> _defaultValues = new List<string>();

		public ProcessArguments() {
			ArgumentPrefix = "-";
			ArgumentSeparator = " ";
			ArgumentValueSeparator = "=";
			MultiValueSeparator = ",";
		}

		public string MultiValueSeparator { get; set; }
		public string ArgumentValueSeparator { get; set; }
		public string ArgumentSeparator { get; set; }
		public string ArgumentPrefix { get; set; }

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

		public new string ToString() {
			StringBuilder args = new StringBuilder();

			foreach (var argument in _arguments) {
				args.Append(ArgumentPrefix);
				args.Append(argument.Key);
				args.Append(ArgumentValueSeparator);	
				args.Append(string.Join(MultiValueSeparator, argument.Value));
				args.Append(ArgumentSeparator);
			}

			args.Append(string.Join(ArgumentSeparator, _defaultValues));
			return args.ToString().Trim();
		}
	}
}
