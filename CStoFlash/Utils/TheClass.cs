using System;
using System.Collections.Generic;


namespace CStoFlash.Utils {
	using Metaspec;

	public class TheClass {
		private static Dictionary<CsClass, TheClass> _classes;

		public static void Init() {
			_classes = new Dictionary<CsClass, TheClass>();
		}

		public static void Add(CsClass pClass) {
			_classes.Add(pClass, new TheClass(pClass));
		}

	
		public static TheClass Get(CsEntityClass pNode) {

			CsClass theClass = pNode.nodes.First.Value as CsClass;
			if (theClass != null && _classes.ContainsKey(theClass))
				return _classes[theClass];

			return null;
		}
		
		public static TheClass Get(CsNode pNode) {
			if (pNode == null)
				return null;

			CsElementAccess csea = pNode as CsElementAccess;
			if (csea != null) {
				if (csea.expression.entity_typeref == null)
					return null;

				switch (csea.expression.entity_typeref.type) {
					case cs_entity_type.et_array://Array access
						return null;

					case cs_entity_type.et_class:
						return Get(csea.expression.entity_typeref.u as CsEntityClass);

					default:
						throw new Exception();
				}
			}

			CsIndexer csi = pNode as CsIndexer;
			if (csi != null) {
				CsClass theClass;

				do {
					theClass = pNode.parent as CsClass;
					pNode = pNode.parent;

				} while (theClass == null && pNode.parent != null);


				if (theClass != null && _classes.ContainsKey(theClass))
					return _classes[theClass];

				return null;
			}

			CsBaseIndexerAccess csbia = pNode as CsBaseIndexerAccess;
			if (csbia != null) {
				return Get((CsEntityClass)csbia.entity_typeref.u);
			}


			throw new Exception();
		}
		
		public static TheIndexers Get(CsNode pNode, CsIndexer pIndexer) {
			TheClass k = Get(pNode);
			if (k == null)
				return null;

			return k.Indexers.ContainsKey(pIndexer) ? k.Indexers[pIndexer] : null;
		}

		/*
		public static TheMethod Get(CsNode pNode, CsMethod pIndexer) {
			TheClass k = Get(pNode);
			if (k == null)
				return null;

			return k.Methods.ContainsKey(pIndexer) ? k.Methods[pIndexer] : null;
		}
		*/
		private readonly Dictionary<CsMethod, TheMethod> _methods = new Dictionary<CsMethod, TheMethod>();
		private readonly Dictionary<CsIndexer, TheIndexers> _indexers = new Dictionary<CsIndexer, TheIndexers>();
		private readonly List<string> _implements = new List<string>();
		private readonly CsClass _theClass;

		public TheClass(CsClass pClass) {
			_theClass = pClass;

			CsQualifiedIdentifier list = ((CsNamespace) pClass.parent).qualified_identifier;
			List<string> name = new List<string>(list.Count);

			foreach (CsQualifiedIdentifierPart identifier in list) {
				name.Add(identifier.identifier.identifier);
			}

			NameSpace = string.Join(".", name.ToArray());

			if (pClass.type_base != null && pClass.type_base.base_list.Count != 0) {
				foreach (CsTypeRef typeRef in pClass.type_base.base_list) {
					Extends = ParserHelper.GetType(typeRef.type_name);
				}
			}

			foreach (CsNode memberDeclaration in pClass.member_declarations) {
				if (memberDeclaration is CsConstructor) {
					continue;
				}

				CsMethod m = memberDeclaration as CsMethod;
				if (m != null) {
					Methods.Add(m, new TheMethod(m));
					continue;
				}

				CsIndexer i = memberDeclaration as CsIndexer;

				if (i != null) {
					Indexers.Add(i, new TheIndexers(i));
					continue;
				} 

				throw new NotSupportedException();
			}
		}

		public string Name {
			get {
				return _theClass.identifier.identifier;
			}
		}

		public string NameSpace {
			get;
			private set;
		}

		public string Extends {
			get;
			set;
		}

		public Dictionary<CsMethod, TheMethod> Methods {
			get {
				return _methods;
			}
		}

		public List<string> Implements {
			get {
				return _implements;
			}
		}

		public Dictionary<CsIndexer, TheIndexers> Indexers {
			get {
				return _indexers;
			}
		}

		public TheIndexers GetIndexerBySignature(List<string> pParams) {
			string sig = string.Join(",", pParams.ToArray());

			foreach (KeyValuePair<CsIndexer, TheIndexers> indexer in Indexers) {
				if (sig.Equals(indexer.Value.Getter.Signature, StringComparison.OrdinalIgnoreCase))
					return indexer.Value;
			}

			return null;
		}
	}

	public class TheMethod {
		private readonly CsMethod _method;
		public TheMethod(CsMethod pMethod) {
			_method = pMethod;
		}

		public string Name {
			get {
				return _method.identifier.identifier;
			}
		}

		public string Signature {
			get {
				return ParserHelper.GetSignature(_method.parameters);
			}
		}

		public string ReturnType {
			get {
				return ParserHelper.GetType(_method.return_type);
			}
		}
	}

	public class GetIndexer {
		private readonly CsPropertyAccessor _method;
		public GetIndexer(CsPropertyAccessor pMethod) {
			_method = pMethod;
		}

		public string Name {
			get {
				return "__get" + Signature.Replace(',', '_').Replace("<", "").Replace(">", "");
			}
		}

		public string Signature {
			get {
				return ParserHelper.GetSignature(_method.entity.parameters);
			}
		}

		public string ReturnType {
			get {
				return ParserHelper.GetType(_method.entity.specifier.return_type);
			}
		}
	}

	public class SetIndexer {
		private readonly CsPropertyAccessor _method;
		public SetIndexer(CsPropertyAccessor pMethod) {
			_method = pMethod;
		}

		public string Name {
			get {
				return "__set" + Signature.Replace(',', '_').Replace("<", "").Replace(">", "");
			}
		}

		public string Signature {
			get {
				return ParserHelper.GetSignature(_method.entity.parameters);
			}
		}

		public string ReturnType {
			get {
				return ParserHelper.GetType(_method.entity.specifier.return_type);
			}
		}

	}

	public class TheIndexers {
		public TheIndexers(CsIndexer pIndexer) {
			if (pIndexer.getter != null) {
				Getter = new GetIndexer(pIndexer.getter);
			}

			if (pIndexer.setter != null) {
				Setter = new SetIndexer(pIndexer.setter);
			}
		}

		public GetIndexer Getter {
			get;
			private set;
		}

		public SetIndexer Setter {
			get;
			private set;
		}
	}
}
