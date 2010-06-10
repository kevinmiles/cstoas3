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

					default://Object access?
						return null;
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

			CsMethod csm = pNode as CsMethod;
			if (csm != null) {
				return csm.entity == null ? null : Get((CsEntityClass)csm.entity.parent);
			}

			CsInvocationExpression csie = pNode as CsInvocationExpression;
			if (csie != null) {
				if (csie.entity == null)
					return null;

				CsEntityMethod method = ((CsEntityMethod) csie.entity);
				if (method.parent is CsEntityClass) {
					return Get((CsEntityClass)method.parent);
				}

				if (method.parent is CsEntityDelegate) {
					return null;
				}
			}

			CsConstructor csc = pNode as CsConstructor;
			if (csc != null) {
				return csc.entity == null ? null : Get((CsEntityClass)(csc.entity).parent);
			}


			throw new Exception();
		}
		
		public static TheIndexers Get(CsNode pNode, CsIndexer pIndexer) {
			TheClass k = Get(pNode);
			if (k == null)
				return null;

			return k.Indexers.ContainsKey(pIndexer) ? k.Indexers[pIndexer] : null;
		}

		
		public static TheMethod Get(CsNode pNode, CsMethod pIndexer) {
			TheClass k = Get(pNode);
			if (k == null)
				return null;

			return k.Methods.ContainsKey(pIndexer) ? k.Methods[pIndexer] : null;
		}

		public static TheMethod Get(CsNode pNode, CsConstructor pIndexer) {
			TheClass k = Get(pNode);
			if (k == null)
				return null;

			return k.Constructors.ContainsKey(pIndexer) ? k.Constructors[pIndexer] : null;
		}

		private readonly Dictionary<CsMethod, TheMethod> _methods = new Dictionary<CsMethod, TheMethod>();
		private readonly Dictionary<CsConstructor, TheMethod> _constructors = new Dictionary<CsConstructor, TheMethod>();
		private readonly Dictionary<string, TheMethod> _methodNames = new Dictionary<string, TheMethod>();
		private readonly Dictionary<string, TheMethod> _constructorNames = new Dictionary<string, TheMethod>();
		private readonly Dictionary<CsIndexer, TheIndexers> _indexers = new Dictionary<CsIndexer, TheIndexers>();
		private readonly List<string> _implements = new List<string>();
		private readonly CsClassStruct _theClass;

		public TheClass(CsClassStruct pClass) {
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
				CsConstructor c = memberDeclaration as CsConstructor;
				if (c != null) {
					TheMethod tm = new TheMethod(c);

					if (_constructorNames.ContainsKey(tm.Name)) {
						if (_constructorNames[tm.Name].IsUnique)
							_constructorNames[tm.Name].IsUnique = false;
						tm.IsUnique = false;

					} else {
						_constructorNames[tm.Name] = tm;
					}

					Constructors.Add(c, tm);
					continue;
				}

				CsMethod m = memberDeclaration as CsMethod;
				if (m != null) {
					TheMethod tm = new TheMethod(m);
					if (_methodNames.ContainsKey(tm.Name)) {
						if (_methodNames[tm.Name].IsUnique) _methodNames[tm.Name].IsUnique = false;
						tm.IsUnique = false;

					} else {
						_methodNames[tm.Name] = tm;
					}

					Methods.Add(m, tm);
					continue;
				}

				CsIndexer i = memberDeclaration as CsIndexer;

				if (i == null) {
					continue;
				}

				Indexers.Add(i, new TheIndexers(i));
				continue;
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

		public Dictionary<CsConstructor, TheMethod> Constructors {
			get {
				return _constructors;
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

		public TheIndexers GetIndexer(CsExpression pIndexer) {
			CsBaseIndexerAccess csbia = pIndexer as CsBaseIndexerAccess;
			CsIndexer i;
			if (csbia != null) {
				i = (CsIndexer) ((CsEntityProperty) csbia.entity).decl;
				return _indexers.ContainsKey(i) ? _indexers[i] : null;	
			}

			CsElementAccess csea = pIndexer as CsElementAccess;

			if (csea != null) {
				i = (CsIndexer)((CsEntityProperty)csea.entity).decl;
				return _indexers.ContainsKey(i) ? _indexers[i] : null;	
			}

			throw new NotImplementedException();
		}

		public TheMethod GetMethod(CsMethod pMethod) {
			return _methods.ContainsKey(pMethod) ? _methods[pMethod] : null;
		}

	}

	public class TheMethod {
		private readonly CsMethod _method;
		private readonly CsConstructor _constructor;

		public TheMethod(CsMethod pMethod) {
			_method = pMethod;
			IsUnique = true;
		}

		public TheMethod(CsConstructor pMethod) {
			_constructor = pMethod;
			IsUnique = true;
		}

		public bool IsUnique {
			get;
			set;
		}

		public string Name {
			get {
				string name = (_method == null ? _constructor.identifier.identifier : _method.identifier.identifier);
				//if (_method != null) name = name.ToLowerInvariant()[0] + name.Substring(1);
				return IsUnique ? name : name + "_" + Signature.Replace(',', '_').Replace("<", "").Replace(">", "");
			}
		}

		public string Signature {
			get {
				return ParserHelper.GetSignature(_method == null ? _constructor.parameters : _method.parameters);
			}
		}

		public string ReturnType {
			get {
				return _method == null ? null : ParserHelper.GetType(_method.return_type);
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
