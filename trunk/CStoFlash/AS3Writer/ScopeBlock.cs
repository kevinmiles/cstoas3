namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;

	using DDW;

	public class ScopeBlock {
		readonly List<Dictionary<string, IType>> _scopes = new List<Dictionary<string, IType>>();

		public void Indent() {
			_scopes.Add(new Dictionary<string, IType>());
		}

		public void Insert(string pName, IType pType) {
			_scopes[_scopes.Count-1].Add(pName, pType);
		}

		public void Unindent() {
			_scopes.RemoveAt(_scopes.Count - 1);
		}

		public IType Search(string pName) {
			for (int c = _scopes.Count - 1; c > -1; c--) {
				if (_scopes[c].ContainsKey(pName))
					return _scopes[c][pName];
			}

			return null;
		}
	}
}
