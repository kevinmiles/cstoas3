using System;
using System.Collections.Generic;


namespace CStoFlash.Utils {
	using System.Diagnostics;

	using Metaspec;

	public static class ParserHelper {
		const string AS3_AS_OBJECT = "As3AsObject";
		const string AS3_EVENT_ATTRIBUTE = "As3EventAttribute";
		const string AS3_NAME_ATTRIBUTE = "As3NameAttribute";
		const string AS3_NAMESPACE_ATTRIBUTE = "As3NamespaceAttribute";

		private static readonly char[] _paramTrim = new[] { ',', ' ' };
		private static readonly Dictionary<CsTokenType, string> _typeRef = new Dictionary<CsTokenType, string>();
		private static readonly Dictionary<cs_entity_type, string> _entityTypeRef = new Dictionary<cs_entity_type, string>();

		static ParserHelper() {
			_typeRef.Add(CsTokenType.tkASSIGN, "=");
			_typeRef.Add(CsTokenType.tkSTAR, "*");
			_typeRef.Add(CsTokenType.tkMUL_EQ, "*=");
			_typeRef.Add(CsTokenType.tkDIV, "/");
			_typeRef.Add(CsTokenType.tkDIV_EQ, "/=");
			_typeRef.Add(CsTokenType.tkMOD, "%");
			_typeRef.Add(CsTokenType.tkMOD_EQ, "%=");
			_typeRef.Add(CsTokenType.tkPLUS, "+");
			//_typeRef.Add(CsTokenType.tkINC, "++");
			_typeRef.Add(CsTokenType.tkDEC, "--");
			_typeRef.Add(CsTokenType.tkPLUS_EQ, "+=");
			_typeRef.Add(CsTokenType.tkMINUS, "-");
			_typeRef.Add(CsTokenType.tkMINUS_EQ, "-=");
			_typeRef.Add(CsTokenType.tkSHIFT_LEFT, "<<");
			_typeRef.Add(CsTokenType.tkSHIFT_RIGHT, ">>");
			_typeRef.Add(CsTokenType.tkLESS, "<");
			_typeRef.Add(CsTokenType.tkGREATER, ">");
			_typeRef.Add(CsTokenType.tkLESS_OR_EQUAL, "<=");
			_typeRef.Add(CsTokenType.tkGREATER_OR_EQUAL, ">=");
			_typeRef.Add(CsTokenType.tkEQUAL, "==");
			_typeRef.Add(CsTokenType.tkNOT_EQ, "!=");
			_typeRef.Add(CsTokenType.tkBITAND, "&");
			_typeRef.Add(CsTokenType.tkXOR, "^");
			_typeRef.Add(CsTokenType.tkBITOR, "|");
			_typeRef.Add(CsTokenType.tkAND, "&&");
			_typeRef.Add(CsTokenType.tkOR, "||");
			_typeRef.Add(CsTokenType.tkQUESTION2, "??");
			_typeRef.Add(CsTokenType.tkCOMPL, "~");
			_typeRef.Add(CsTokenType.tkNOT, "!");

			_typeRef.Add(CsTokenType.tkAS, "as");
			_typeRef.Add(CsTokenType.tkIS, "is");

			_typeRef.Add(CsTokenType.tkVOID, "void");
			_typeRef.Add(CsTokenType.tkSTRING, "string");
			_typeRef.Add(CsTokenType.tkBOOL, "bool");

			_typeRef.Add(CsTokenType.tkINT, "int");
			_typeRef.Add(CsTokenType.tkSHORT, "short");

			_typeRef.Add(CsTokenType.tkUINT, "uint");
			_typeRef.Add(CsTokenType.tkUSHORT, "ushort");

			_typeRef.Add(CsTokenType.tkULONG, "ulong");
			_typeRef.Add(CsTokenType.tkLONG, "long");
			_typeRef.Add(CsTokenType.tkFLOAT, "float");
			_typeRef.Add(CsTokenType.tkDOUBLE, "double");
			_typeRef.Add(CsTokenType.tkDECIMAL, "decimal");

			//_entityTypeRef.Add(cs_entity_type.et_array, "array");
			_entityTypeRef.Add(cs_entity_type.et_string, "string");
			_entityTypeRef.Add(cs_entity_type.et_boolean, "bool");
			_entityTypeRef.Add(cs_entity_type.et_void, "void");
			_entityTypeRef.Add(cs_entity_type.et_object, "object");

			_entityTypeRef.Add(cs_entity_type.et_uint8, "uint");
			_entityTypeRef.Add(cs_entity_type.et_uint16, "uint");
			_entityTypeRef.Add(cs_entity_type.et_uint32, "uint");
			_entityTypeRef.Add(cs_entity_type.et_uint64, "uint");

			_entityTypeRef.Add(cs_entity_type.et_int8, "int");
			_entityTypeRef.Add(cs_entity_type.et_int16, "int");
			_entityTypeRef.Add(cs_entity_type.et_int32, "int");
			_entityTypeRef.Add(cs_entity_type.et_int64, "int");

			_entityTypeRef.Add(cs_entity_type.et_float32, "float");
			_entityTypeRef.Add(cs_entity_type.et_float64, "float");
			_entityTypeRef.Add(cs_entity_type.et_decimal, "decimal");

			_entityTypeRef.Add(cs_entity_type.et_unknown, "*UnknownEntityRef*");
		}

		public static string EscapeString(string pIn) {
			return "\"" + pIn.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
		}

		public static string GetSignature(IEnumerable<CsFormalParameter> pLinkedList) {
			if (pLinkedList == null)
				return string.Empty;

			List<string> list = new List<string>();
			foreach (CsFormalParameter param in pLinkedList) {
				list.Add(GetType(param.type));
			}

			return string.Join("_", list.ToArray());
		}

		public static string GetSignature(CsFormalParameterList pList) {
			return GetSignature(pList.parameters);
		}

		public static string GetSignature(CsEntityFormalParameter[] pLinkedList) {
			List<string> list = new List<string>();
			foreach (CsEntityFormalParameter param in pLinkedList) {
				list.Add(GetType(param.type));
			}

			return string.Join(",", list.ToArray());
		}

		public static string GetTokenType(CsTokenType pTokenType) {
			if (_typeRef.ContainsKey(pTokenType)) {
				return _typeRef[pTokenType];
			}

			Debug.Fail("Unknown Typeref: " + pTokenType);

			return "?*?*?*";
		}

		public static string GetType(CsEntityTypeRef pDirective) {
			if (pDirective == null)
				return null;

			if (_entityTypeRef.ContainsKey(pDirective.type)) {
				return _entityTypeRef[pDirective.type];
			}

			switch (pDirective.type) {
				case cs_entity_type.et_array:
					CsEntityArraySpecifier eas = pDirective.u as CsEntityArraySpecifier;
					return GetType(eas.type)+"[]";

				case cs_entity_type.et_enum:
					CsEntityEnum ee = pDirective.u as CsEntityEnum;
					return ee.name;

				case cs_entity_type.et_generic_param:
					CsEntityGenericParam egp = pDirective.u as CsEntityGenericParam;

					return egp.name;

				case cs_entity_type.et_genericinst:
					CsEntityInstanceSpecifier eis = pDirective.u as CsEntityInstanceSpecifier;
					if (eis != null) {
						string ret = GetType(eis.type);

						if (eis.arguments != null) {
							List<string> val = new List<string> {"<"};

							foreach (CsEntityTypeRef argument in eis.arguments) {
								val.Add(GetType(argument));
								val.Add(", ");
							}
							val.RemoveAt(val.Count - 1);
							val.Add(">");
							ret += string.Join("", val.ToArray());
						}

						return ret;
					}

					throw new Exception();

				case cs_entity_type.et_class:
					CsEntityInterface itf = pDirective.u as CsEntityInterface;
					if (itf != null) {
						if (itf.interfaces != null && itf.interfaces.Count > 0) {
							List<string> val = new List<string>(itf.interfaces.Count);
							foreach (CsEntityTypeRef typeRef in itf.interfaces) {
								val.Add(GetType(typeRef));
							}

							return string.Join(", ", val.ToArray());
						}

						if (!string.IsNullOrEmpty(itf.name)) {
							return itf.name;
						}
					}

					CsEntityClass cls = pDirective.u as CsEntityClass;
					if (cls != null) {
						if (cls.indexers != null) {
							foreach (CsEntityProperty indexer in cls.indexers) {
								return GetType(indexer.type);
							}
						}

						return cls.name;
					}

					return "IHaveNOIdeaWhatShouldBeHere";
			}

			throw new Exception("Unknown EntityTypeRef: " + pDirective.type);
		}

		public static string GetType(CsTypeRef pDirective) {
			switch (pDirective.entity_typeref.type) {
				case cs_entity_type.et_array:
					return GetTokenType(pDirective.predefined_type) + "[]";

				case cs_entity_type.et_genericinst:
					return GetType(pDirective.type_name);

				default:
					return pDirective.predefined_type == CsTokenType.tkEOF ? GetType(pDirective.type_name) : GetTokenType(pDirective.predefined_type);
			}
		}

		public static string GetType(CsUsingNamespaceDirective pDirective) {
			if (pDirective.namespace_or_type_name == null)
				return "";

			string ret = GetType(pDirective.namespace_or_type_name.namespace_or_type_name);
			if (!string.IsNullOrEmpty(ret))
				ret += ".";

			return ret + pDirective.namespace_or_type_name.identifier.identifier;
		}

		public static string GetType(CsNamespaceOrTypeName pDirective) {
			string g = "";
			//generics
			if (pDirective.type_argument_list != null && pDirective.type_argument_list.list.Count != 0) {
				g += "<";
				foreach (CsTypeRef typeRef in pDirective.type_argument_list.list) {
					g += GetType(typeRef);
					g += ", ";

				}

				g = g.TrimEnd(_paramTrim) + ">";
			}

			if (pDirective.namespace_or_type_name == null) {
				if (pDirective.parent is CsTypeRef) {
					

					CsTypeRef parent = ((CsTypeRef) pDirective.parent);

					if (parent.entity_typeref.u is CsEntityClass) {
						if (IsClassDefinedAsObject(((CsEntityClass)parent.entity_typeref.u).attributes))
						return "Object";
					}

					if (parent.entity_typeref.u is CsEntityInstanceSpecifier) {
						//if (IsClassDefinedAsObject(((CsEntityInstanceSpecifier)parent.entity_typeref.u)))
						//return "Object";
					}
				}

				return pDirective.identifier.identifier + g;
			}
			

			string ret = GetType(pDirective.namespace_or_type_name);
			if (!string.IsNullOrEmpty(ret))
				ret += ".";

			return ret + pDirective.identifier.identifier + g;
		}

		public static string GetType(CsNode pDirective) {
			if (pDirective == null)
				return "";

			if (pDirective is CsNamespaceOrTypeName)
				return GetType((CsNamespaceOrTypeName)pDirective);

			if (pDirective is CsUsingNamespaceDirective)
				return GetType((CsUsingNamespaceDirective)pDirective);

			if (pDirective is CsTypeRef)
				return GetType((CsTypeRef)pDirective);

			throw new Exception("Unsupported node type");
		}

		public static string GetRealName(CsExpression pExpression, string pName) {
			object entity = pExpression.entity;
			IEnumerable<CsEntityAttribute> m;

			if (entity is CsEntityClass) {
				return getRealNameFromAttr(((CsEntityClass)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityVariable) {
				m = ((CsEntityVariable)pExpression.entity).attributes;
				addImports(m);
				return getRealNameFromAttr(m, pName);
			}

			if (entity is CsEntityEnum) {
				return getRealNameFromAttr(((CsEntityEnum)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityStruct) {
				return getRealNameFromAttr(((CsEntityStruct)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityConstant) {
				return getRealNameFromAttr(((CsEntityConstant)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityMethod) {
				m = ((CsEntityMethod)pExpression.entity).attributes;
				addImports(m);
				return getRealNameFromAttr(m, pName);
			}

			return pName;
		}

		private static string getRealNameFromAttr(IEnumerable<CsEntityAttribute> pList, string pName) {
			if (pName.Equals("ToString", StringComparison.Ordinal))
				pName = "toString";

			if (pList == null)
				return pName;

			string n = GetAttributeValue<string>(pList, AS3_NAME_ATTRIBUTE);
			return string.IsNullOrEmpty(n) ? pName : n;
		}


		public static bool IsClassDefinedAsObject(CsAttributes pList) {
			return HasAttribute(pList, AS3_AS_OBJECT);
		}

		public static bool IsClassDefinedAsObject(IEnumerable<CsEntityAttribute> pList) {
			return HasAttribute(pList, AS3_AS_OBJECT);
		}

		public static string GetEventFromAttr(CsAttributes pList) {
			addImports(pList);
			return GetAttributeValue<string>(pList, AS3_EVENT_ATTRIBUTE);
		}

		public static string GetEventFromAttr(IEnumerable<CsEntityAttribute> pList) {
			addImports(pList);
			return GetAttributeValue<string>(pList, AS3_EVENT_ATTRIBUTE);
		}

		private static void addImports(IEnumerable<CsEntityAttribute> pList) {
			if (pList == null)
				return;

			ImportStatementList.AddImport(GetAttributeValue<string>(pList, AS3_NAMESPACE_ATTRIBUTE));
		}

		private static void addImports(CsAttributes pList) {
			if (pList == null)
				return;

			ImportStatementList.AddImport(GetAttributeValue<string>(pList, AS3_NAMESPACE_ATTRIBUTE));
		}

		public static T GetAttributeValue<T>(CsAttributes pList, string pAttrName) where T:class {
			T def = default(T);

			if (pList == null)
				return def;

			if (pList.sections == null || pList.sections.Count == 0)
				return def;

			foreach (CsAttributeSection section in pList.sections) {
				foreach (CsAttribute attribute in section.attribute_list) {
					T val = GetAttributeValue<T>(attribute.entities, pAttrName);

					if (val != null && !val.Equals(def))
						return val;
				}
			}

			return def;
		}

		public static T GetAttributeValue<T>(IEnumerable<CsEntityAttribute> pList, string pAttrName) where T:class{
			if (pList == null)
				return default(T);

			foreach (CsEntityAttribute attribute in pList) {
				if (!attribute.type.parent.name.Equals(pAttrName, StringComparison.Ordinal)) {
					continue;
				}

				return (attribute.fixed_arguments[0]).value as T;
			}

			return default(T);
		}

		public static bool HasAttribute(CsAttributes pList, string pAttrName) {
			if (pList == null)
				return false;

			if (pList.sections == null || pList.sections.Count == 0)
				return false;

			foreach (CsAttributeSection section in pList.sections) {
				foreach (CsAttribute attribute in section.attribute_list) {
					bool val = HasAttribute(attribute.entities, pAttrName);
					if (val)
						return true;
				}
			}

			return false;
		}

		public static bool HasAttribute(IEnumerable<CsEntityAttribute> pList, string pAttrName) {
			if (pList == null)
				return false;

			foreach (CsEntityAttribute attribute in pList) {
				if (attribute.type.parent.name.Equals(pAttrName, StringComparison.Ordinal)) {
					return true;
				}
			}

			return false;
		}
	}
}
