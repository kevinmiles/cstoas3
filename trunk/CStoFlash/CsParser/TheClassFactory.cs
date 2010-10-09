using System;
using System.Collections.Generic;

namespace CStoFlash.CsParser {
	using Metaspec;

	public static class TheClassFactory {
		private static readonly Dictionary<CsClass, TheClass> _classes = new Dictionary<CsClass, TheClass>();
		private static readonly Dictionary<CsEntity, TheClass> _entities = new Dictionary<CsEntity, TheClass>();

		public static TheClass Get(CsNode pNode) {
			if (pNode == null)
				return null;

			CsExpression csExpression = pNode as CsExpression;
			if (csExpression != null && csExpression.ec != expression_classification.ec_nothing) {
				return get((CsEntity)csExpression.entity);
			}

			while (pNode != null) {
				if (pNode is CsTypeRef || pNode is CsClass) {
					break;
				}

				pNode = pNode.parent;
			}

			CsClass klass = pNode as CsClass;
			if (klass != null) {
				if (!_classes.ContainsKey(klass))
					_classes[klass] = new TheClass(klass);

				return _classes[klass];
			}

			CsTypeRef csTypeRef = pNode as CsTypeRef;
			if (csTypeRef != null) {
				return csTypeRef.entity_typeref == null ? null : get((CsEntityClass)(csTypeRef.entity_typeref.u));
			}

			throw new Exception();
		}

		private static TheClass get(CsEntity pCsEntity) {
			if (pCsEntity == null)
				return null;

			while (pCsEntity != null) {
				if (pCsEntity is CsEntityClass || pCsEntity is CsEntityStruct) {
					break;
				}

				pCsEntity = pCsEntity.parent;
			}

			CsEntityClass entityKlass = pCsEntity as CsEntityClass;
			if (entityKlass != null && entityKlass.nodes.Count != 0 && entityKlass.nodes.First.Value != null) {
				return Get(entityKlass.nodes.First.Value);
			}

			CsEntityStruct entityStruct = pCsEntity as CsEntityStruct;
			if (entityStruct != null && entityStruct.nodes.Count != 0 && entityStruct.nodes.First.Value != null) {
				return Get(entityStruct.nodes.First.Value);
			}

			if (pCsEntity != null) {
				if (!_entities.ContainsKey(pCsEntity))
					_entities[pCsEntity] = new TheClass(pCsEntity);

				return _entities[pCsEntity];
			}

			throw new Exception();
		}

		public static TheClass Get(CsEntityTypeRef pEntityTyperef) {
			CsEntityInstanceSpecifier entityInstanceSpecifier = pEntityTyperef.u as CsEntityInstanceSpecifier;
			CsEntityClass entityClass = entityInstanceSpecifier == null
											? (CsEntityClass)pEntityTyperef.u
											: (CsEntityClass)entityInstanceSpecifier.type.u;

			return Get(entityClass);
			//return Get(entityClass.nodes.First.Value);
		}

		public static TheClass Get(CsEntityClass pNode) {
			CsClass theClass = pNode.nodes.First.Value as CsClass;
			if (theClass == null)
				return null;

			if (!_classes.ContainsKey(theClass))
				_classes[theClass] = new TheClass(theClass);

			return _classes[theClass];
		}
	}
}
