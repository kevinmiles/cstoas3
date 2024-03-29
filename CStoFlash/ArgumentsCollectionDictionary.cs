﻿namespace CStoFlash {
	using System.Collections.Generic;
	using System.Text.RegularExpressions;

	sealed class ArgumentsCollection : Dictionary<string, string> {
		// Constructor
		public ArgumentsCollection(IEnumerable<string> pArgs) {
			Regex splitter = new Regex(@"^-{1,2}|^/|=|:", RegexOptions.IgnoreCase | RegexOptions.Compiled);
			Regex remover = new Regex(@"^['""]?(.*?)['""]?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

			string parameter = null;
			string[] parts;

			// Valid parameters forms:
			// {-,/,--}param{ ,=,:}((",')value(",'))
			// Examples: 
			// -param1 value1 --param2 /param3:"Test-:-work" /param4=happy -param5 '--=nice=--'
			foreach (string txt in pArgs) {
				// Look for new parameters (-,/ or --) and a
				// possible enclosed value (=,
				parts = splitter.Split(txt, 3);

				switch (parts.Length) {
					// Found a value (for the last parameter 
					// found (space separator))
					case 1:
						if (parameter != null) {
							if (!ContainsKey(parameter)) {
								parts[0] = remover.Replace(parts[0], "$1");
								Add(parameter, parts[0]);
							}
							parameter = null;
						}
						// else Error: no parameter waiting for a value (skipped)
						break;
					// Found just a parameter
					case 2:
						// The last parameter is still waiting. 
						// With no value, set it to true.
						if (parameter != null) {
							if (!ContainsKey(parameter)) {
								Add(parameter, "true");
							}
						}
						parameter = parts[1];
						break;

					// Parameter with enclosed value
					case 3:
						// The last parameter is still waiting. 
						// With no value, set it to true.
						if (parameter != null) {
							if (!ContainsKey(parameter))
								Add(parameter, "true");
						}

						parameter = parts[1];

						// Remove possible enclosing characters (",')
						if (!ContainsKey(parameter)) {
							parts[2] = remover.Replace(parts[2], "$1");
							Add(parameter, parts[2]);
						}
						parameter = null;
						break;
				}
			}
			// In case a parameter is still waiting
			if (parameter == null)
				return;
			if (!ContainsKey(parameter)) {
				Add(parameter, "true");
			}
		}

		new public string this[string pParam] {
			get {
				return ContainsKey(pParam) ? base[pParam] : null;
			}
		}
	}
}
