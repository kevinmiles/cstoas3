namespace CStoFlash.AS3Writer {
	using Metaspec;

	using Utils;

	public static class IndexerParser {
		public static void Parse(CsIndexer pIndexer, CodeBuilder pBuilder) {
			TheIndexers klass = TheClass.Get(pIndexer, pIndexer);

			if (pIndexer.getter != null) {
				CsPropertyAccessor getter = pIndexer.getter;
				
				pBuilder.AppendFormat("{0}function {1}({2}):{3} {{",
					As3Helpers.GetModifiers(getter.modifiers),
					klass.Getter.Name,
					As3Helpers.GetParams(getter.entity.parameters),
					As3Helpers.Convert(klass.Getter.ReturnType));

				pBuilder.AppendLine();
				BlockParser.Parse(getter.definition, pBuilder);
				pBuilder.AppendLine();
				pBuilder.AppendLine("}");
				pBuilder.AppendLine();
			}

			if (pIndexer.setter == null) {
				return;
			}

			CsPropertyAccessor setter = pIndexer.setter;
				
			//string keys = As3Helpers.GetParams(pIndexer.parameters.parameters);

			pBuilder.AppendFormat(
				"{0}function {1}({2}):void {{",
				  As3Helpers.GetModifiers(setter.modifiers),
				  klass.Setter.Name,
                  As3Helpers.GetParams(setter.entity.parameters)
			);

			pBuilder.AppendLine();
			BlockParser.Parse(setter.definition, pBuilder);
			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}
