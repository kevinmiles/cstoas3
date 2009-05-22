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
			pSb.AppendFormat("{0}function {1}({2}) {{",
				As3Helpers.GetModifiers(pConstructor.modifiers),
				pConstructor.identifier.identifier,
				As3Helpers.GetParams(pConstructor.parameters.parameters)
			);

			pSb.AppendLine();
			BlockParser.Parse(pConstructor.definition, pSb);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		public static void Parse(CsMethod pMethod, CodeBuilder pSb) {
			pSb.AppendFormat("{0}function {1}({2}):{3} {{",
				As3Helpers.GetModifiers(pMethod.modifiers),
				pMethod.identifier.identifier,
				As3Helpers.GetParams(pMethod.parameters.parameters),
				As3Helpers.Convert(ParserHelper.GetType(pMethod.return_type))
			);

			pSb.AppendLine();
			BlockParser.Parse(pMethod.definition, pSb);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();
		}
	}
}