namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using Interfaces;
	using Metaspec;

	public class TheIndexer : BaseMethod, ICsMethod {
		internal TheIndexer(CsIndexer pIndexer, TheClass pMyClass) {
			MyClass = pMyClass;
			Arguments = getArguments(pIndexer.parameters.parameters);
			Signature = getSignature(Arguments);
			ReturnType = Helpers.GetType(pIndexer.entity.specifier.return_type);
			Modifiers.AddRange(Helpers.GetModifiers(pIndexer.modifiers));

			//Name = Helpers.GetRealName(pIndexer, pIndexer.entity.name);
			Name = pIndexer.entity.name;

			FullName = MyClass.FullName + "." + Name;
			//FullRealName = MyClass.FullRealName + "." + RealName;

			string sig = Signature.Replace(',', '_').Replace("<", "").Replace(">", "");

			if (pIndexer.getter != null) {
				Getter = processIndexer(pIndexer.getter, false, sig);
			}

			if (pIndexer.setter != null) {
				Setter = processIndexer(pIndexer.setter, true, sig);
			}
		}

		private Indexer processIndexer(CsPropertyAccessor pCsPropertyAccessor, bool pIsSetter, string pSignature) {
			string start = pIsSetter ? "__set" : "__get";
			
			Indexer i = new Indexer {
				Name = start + pSignature,
				Signature = pSignature,
				CodeBlock = pCsPropertyAccessor.definition
			};

			List<string> mods = Helpers.GetModifiers(pCsPropertyAccessor.modifiers);
			i.Modifiers.AddRange(mods.Count < 1 ? Modifiers : mods);
			i.Arguments.AddRange(getArguments(pCsPropertyAccessor.entity.parameters));
			return i;
		}

		public Indexer Getter {
			get;
			private set;
		}

		public Indexer Setter {
			get;
			private set;
		}

		public string ReturnType {
			get;
			internal set;
		}
	}

	public class Indexer : BaseNode, ICsHasCodeBlock {
		public string Signature {
			get; internal set; }

		public CsBlock CodeBlock {
			get;
			internal set;
		}

		public readonly List<TheMethodArgument> Arguments = new List<TheMethodArgument>();
	}
}
