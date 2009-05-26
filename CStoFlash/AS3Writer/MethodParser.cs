namespace CStoFlash.AS3Writer {
	using Metaspec;

	using Utils;

	public static class MethodParser {
		//>CsConstructor
		//	>argument_list
		//	>definition CsBlock
		//	>identifier
		//	>parameters
		//	>modifiers

		public static void Parse(CsConstructor pConstructor, CodeBuilder pSb) {
			TheMethod klass = TheClass.Get(pConstructor, pConstructor);

			if (!klass.IsUnique) {
				return;
			}


			pSb.AppendFormat("{0}function {1}({2}) {{",
			                 As3Helpers.GetModifiers(pConstructor.modifiers),
			                 klass.Name,
			                 As3Helpers.GetParams(pConstructor.parameters.parameters)
				);

			pSb.AppendLine();
			BlockParser.Parse(pConstructor.definition, pSb);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();

			//call same class constructor
			//pConstructor.argument_list.list

			//pConstructor.basethis
		}

		public static void Parse(CsMethod pMethod, CodeBuilder pSb) {
			TheMethod klass = TheClass.Get(pMethod, pMethod);

			pSb.AppendFormat("{0}function {1}({2}):{3} {{",
				As3Helpers.GetModifiers(pMethod.modifiers),
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