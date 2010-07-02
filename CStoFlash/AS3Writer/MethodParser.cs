namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;
	using Metaspec;

	using Utils;

	public static class MethodParser {
		private static readonly Dictionary<CsModifierEnum, string> _notValidConstructorMod =
			new Dictionary<CsModifierEnum, string> {
				{ CsModifierEnum.mPRIVATE, "public" },
				{ CsModifierEnum.mABSTRACT, "public"},
				{ CsModifierEnum.mPROTECTED, "public"}
			};

		//>CsConstructor
		//	>argument_list
		//	>definition CsBlock
		//	>identifier
		//	>parameters
		//	>modifiers

		public static void Parse(CsConstructor pConstructor, CodeBuilder pSb) {
			//string baseClassName = TheClass.Get(pConstructor).BaseClassName;
			//bool flashDefault = baseClassName.StartsWith("flash.",StringComparison.Ordinal);
			//flashDefault |= c != null && c.Extends.Count == 0;

			TheMethod klass = TheClass.Get(pConstructor, pConstructor);
			bool defaultConstructor = klass.Name.Equals("_init_", StringComparison.Ordinal);
			string constructorName = defaultConstructor ? klass.SimpleName : klass.Name;
				//flashDefault ? klass.SimpleName : klass.Name;
			string modifiers = As3Helpers.GetModifiers(pConstructor.modifiers, defaultConstructor ? _notValidConstructorMod : null);

			pSb.AppendFormat("{0}function {1}({2}){3} {{",
							 modifiers,
							 constructorName,
			                 As3Helpers.GetParams(pConstructor.parameters.parameters),
							 defaultConstructor ? string.Empty : ":" + klass.SimpleName
				);

			pSb.AppendLine();

			//Si hay un constructor sin parámetros, usarlo como constructor de la clase.
			//De esta manera se va a respetar el super() sin tener que hacer hacks...

			if (pConstructor.basethis == CsTokenType.tkBASE || pConstructor.basethis == CsTokenType.tkTHIS) {
				CsEntityClass basec = pConstructor.basethis == CsTokenType.tkBASE
				                      	? (CsEntityClass) ((CsEntityClass) pConstructor.entity.parent).base_type.u
				                      	: ((CsEntityClass) pConstructor.entity.parent);

				TheClass baseClass = TheClass.Get(basec);
				TheMethod constructor = baseClass.GetConstructorBySignature(ParserHelper.GetSignature(pConstructor.argument_list));

				pSb.AppendFormat("\t{0}{1}({2});",
					pConstructor.basethis == CsTokenType.tkBASE ? "super." : string.Empty,
					constructor.Name,                    
				    As3Helpers.GetParams(pConstructor.argument_list)
				);
				pSb.AppendLine();

			} 
			//else {
			//    if (!flashDefault && !string.IsNullOrEmpty(baseClassName)) {
			//        pSb.AppendLine("\tsuper();");	
			//    }
			//}

			BlockParser.Parse(pConstructor.definition, pSb);
			pSb.AppendLine();
			if (!defaultConstructor)
				pSb.AppendLine("\treturn this;");

			pSb.AppendLine("}");
			pSb.AppendLine();

			//call same class constructor
			//pConstructor.argument_list.list

			//pConstructor.basethis
		}

		//private static string getNamespace(CsEntity pNamespace) {
		//    while (!pNamespace.isNamespace()) {
		//        pNamespace = pNamespace.parent;
		//    }

		//    List<string> l = new List<string>();
		//    while (pNamespace.parent != null && pNamespace.isNamespace()) {
		//        l.Insert(0, pNamespace.name);
		//        pNamespace = pNamespace.parent;
		//    }

		//    return string.Join(".", l.ToArray());
		//}

		public static void Parse(CsMethod pMethod, CodeBuilder pSb) {
			TheMethod klass = TheClass.Get(pMethod, pMethod);

			pSb.AppendFormat("{0}function {1}({2}):{3} {{",
				As3Helpers.GetModifiers(pMethod.modifiers, null),
				klass.Name,
				As3Helpers.GetParams(pMethod.parameters.parameters),
				As3Helpers.Convert(klass.ReturnType)
			);

			pSb.AppendLine();
			BlockParser.Parse(pMethod.definition, pSb);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();
		}
	}
}