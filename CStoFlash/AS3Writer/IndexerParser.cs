namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;

	using DDW;
	using Utils;

	public sealed class IndexerType {
		public string GetName;
		public string SetName;

		public IndexerType(string pG, string pS) {
			GetName = pG;
			SetName = pS;
		}
	}

	public static class IndexerParser {
		private static readonly Dictionary<string, IndexerType> _indexers = new Dictionary<string, IndexerType>();

		public static string GetGetterName(NamespaceNode pNn, ClassNode pCn, IType pType) {
			if (pType == null)
				return null;

			string key = getName(pNn, pCn, pType);
			return _indexers.ContainsKey(key) ? _indexers[key].GetName : null;
		}

		public static string GetSetterName(NamespaceNode pNn, ClassNode pCn, IType pType) {
			if (pType == null)
				return null;

			string key = getName(pNn, pCn, pType);
			return _indexers.ContainsKey(key) ? _indexers[key].SetName : null;
		}

		private static string getName(NamespaceNode pNn, ConstructedTypeNode pCn, IType pType) {
			return pNn.Name.QualifiedIdentifier + "." + pCn.Name.Identifier + "::" + Helpers.ConvertType(pType);
		}

		public static void Parse(NamespaceNode pNn, ClassNode pCn, IndexerNode pNode, CodeBuilder pBuilder, ScopeBlock pScope) {
			string p = Helpers.GetParams(pNode.Params);

			string type = Helpers.ConvertType(pNode.Type);

			string getterName = null;
			string setterName = null;
			string mod = Helpers.GetModifiers(pNode.Modifiers);
			if (pNode.Getter != null) {
				getterName = "__get" + type;
				pBuilder.AppendLine(mod+" function " + getterName + "(" + p + "):" + type + " {");
				BlockParser.ParseStatementBlock(pNn, pCn, pNode.Getter.StatementBlock, pBuilder, pScope);
				pBuilder.AppendLine("}");
			}

			if (pNode.Setter != null) {
				setterName = "__set" + type;
				pBuilder.AppendLine(mod+" function " + setterName + "(" + p + ", value:" + type + "):void {");
				BlockParser.ParseStatementBlock(pNn, pCn, pNode.Setter.StatementBlock, pBuilder, pScope);
				pBuilder.AppendLine("}");
			}

			_indexers.Add(getName(pNn, pCn, pNode.Type), new IndexerType(getterName, setterName));
		}
	}
}
