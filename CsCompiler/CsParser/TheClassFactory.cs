namespace CsCompiler.CsParser {
	using System;
	using System.Collections.Generic;
	using Metaspec;

	public static class TheClassFactory {
		private static readonly Dictionary<CsClass, TheClass> _classes = new Dictionary<CsClass, TheClass>();
		private static readonly Dictionary<CsInterface, TheClass> _interfaces = new Dictionary<CsInterface, TheClass>();
		private static readonly Dictionary<CsEntity, TheClass> _entities = new Dictionary<CsEntity, TheClass>();

		public static TheClass Get(CsNode pNode) {
			if (pNode == null)
				return null;

			CsExpression csExpression = pNode as CsExpression;
			if (csExpression != null && csExpression.ec != expression_classification.ec_nothing) {
				return Get((CsEntity)csExpression.entity);
			}

			while (pNode != null) {
				if (pNode is CsTypeRef || pNode is CsClass || pNode is CsInterface) {
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
				return csTypeRef.entity_typeref == null ? null : Get((CsEntityClass)(csTypeRef.entity_typeref.u));
			}

			CsInterface csInterface = pNode as CsInterface;
			if (csInterface != null) {
				if (!_interfaces.ContainsKey(csInterface))
					_interfaces[csInterface] = new TheClass(csInterface);

				return _interfaces[csInterface];
			}

			throw new Exception();
		}

		public static TheClass Get(CsEntity pCsEntity) {
			if (pCsEntity == null)
				return null;

			while (pCsEntity != null) {
				if (pCsEntity is CsEntityClass || pCsEntity is CsEntityStruct || pCsEntity is CsEntityInterface) {
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

			CsEntityInterface entityInterface = pCsEntity as CsEntityInterface;
			if (entityInterface != null && entityInterface.nodes.Count != 0 && entityInterface.nodes.First.Value != null) {
				return Get(entityInterface.nodes.First.Value);
			}

			if (pCsEntity != null) {
				if (!_entities.ContainsKey(pCsEntity))
					_entities[pCsEntity] = new TheClass(pCsEntity);

				return _entities[pCsEntity];
			}

			throw new Exception();
		}

		//public static TheClass Get(CsEntity pEntity) {
		//    CsEntityClass typeRef = pEntity as CsEntityClass;
		//    if (typeRef != null) {
		//        CsClass theClass = typeRef.nodes.First.Value as CsClass;
		//        if (theClass == null) {
		//            return get(typeRef);
		//        }

		//        if (!_classes.ContainsKey(theClass))
		//            _classes[theClass] = new TheClass(theClass);

		//        return _classes[theClass];
		//    }

		//    CsEntityInterface entityInterface = pEntity as CsEntityInterface;


		//}

		public static TheClass Get(CsEntityTypeRef pEntityTyperef) {
			if (pEntityTyperef == null)
				return null;

			if (
				pEntityTyperef.u is CsEntityGenericParam ||
				pEntityTyperef.u is CsEntityArraySpecifier
			) return null;

			CsEntityInstanceSpecifier entityInstanceSpecifier = pEntityTyperef.u as CsEntityInstanceSpecifier;

			CsEntity entityClass = entityInstanceSpecifier == null
											? (CsEntity)pEntityTyperef.u
											: (CsEntity)entityInstanceSpecifier.type.u;

			return Get(entityClass);
			//return Get(entityClass.nodes.First.Value);
		}
	}
}
