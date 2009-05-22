namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;

	public class ScopeBlock {
		readonly List<Dictionary<string, string>> _scopes = new List<Dictionary<string, string>>();

		public void Indent() {
			_scopes.Add(new Dictionary<string, string>());
		}

		public void Insert(string pName, string pType) {
			_scopes[_scopes.Count-1].Add(pName, pType);
		}

		public void Unindent() {
			_scopes.RemoveAt(_scopes.Count - 1);
		}

		public string Search(string pName) {
			for (int c = _scopes.Count - 1; c > -1; c--) {
				if (_scopes[c].ContainsKey(pName))
					return _scopes[c][pName];
			}

			return null;
		}
	}
}
