using System;
using System.Collections.Generic;


namespace CStoFlash.Utils {
	using System.Diagnostics;

	using Metaspec;

	public static class ParserHelper {
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

			_entityTypeRef.Add(cs_entity_type.et_unknown, "?*?*?*");
		}

		public static string GetSignature(IEnumerable<CsFormalParameter> pLinkedList) {
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

			if (pDirective.namespace_or_type_name == null)
				return pDirective.identifier.identifier + g;

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
	}
}
