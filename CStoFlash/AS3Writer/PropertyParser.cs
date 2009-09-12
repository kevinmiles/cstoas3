namespace CStoFlash.AS3Writer {
	using Metaspec;

	using Utils;

	public static class PropertyParser {
		public static void Parse(CsProperty pCsProperty, AS3Builder pBuilder) {
			CsPropertyAccessor getter = pCsProperty.getter;
			CsPropertyAccessor setter = pCsProperty.setter;
			string identifier = pCsProperty.identifier.identifier;
			string type = As3Helpers.Convert(ParserHelper.GetType(pCsProperty.type));
			string defModifier = As3Helpers.GetModifiers(pCsProperty.modifiers);

			bool empty = getter.definition == null && setter.definition == null;

			if (empty) {
				pBuilder.AppendFormat("private var _{0}:{1};", identifier, type);
				pBuilder.AppendLine();
			}

			//Getter
			string gModifiers = As3Helpers.GetModifiers(getter.modifiers);
			pBuilder.AppendFormat("{0}function {1}():{2} {{",
				string.IsNullOrEmpty(gModifiers) ? defModifier : gModifiers,
				getter.entity.name,
				type
			);

			pBuilder.AppendLine();

			if (empty) {
				pBuilder.Indent();
				pBuilder.AppendFormat("return _{0};", identifier);
				pBuilder.Unindent();

			} else {
				BlockParser.Parse(getter.definition, pBuilder);
			}

			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();


			//Setter
			string sModifiers = As3Helpers.GetModifiers(setter.modifiers);
			pBuilder.AppendFormat("{0}function {1}(value:{2}):void {{",
				string.IsNullOrEmpty(sModifiers) ? defModifier : sModifiers,
				setter.entity.name,
				type
			);

			pBuilder.AppendLine();

			if (empty) {
				pBuilder.Indent();
				pBuilder.AppendFormat("_{0} = value;", identifier);
				pBuilder.Unindent();

			} else {
				BlockParser.Parse(setter.definition, pBuilder);
			}

			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}