namespace CStoFlash.AS3Writer {
	using CsParser;

	public static class IndexerParser {
		public static void Parse(TheIndexer pGetIndexer, As3Builder pBuilder) {

			if (pGetIndexer.Getter != null) {
				//CsPropertyAccessor getter = pGetIndexer.getter;
				pBuilder.AppendFormat("{0}function {1}({2}):{3} {{",
					As3Helpers.ConvertModifiers(pGetIndexer.Getter.Modifiers),
					pGetIndexer.Getter.Name,
					As3Helpers.GetParameters(pGetIndexer.Getter.Arguments),
					As3Helpers.Convert(pGetIndexer.ReturnType));

				pBuilder.AppendLine();
				BlockParser.Parse(pGetIndexer.Getter.CodeBlock, pBuilder);
				pBuilder.AppendLine();
				pBuilder.AppendLine("}");
				pBuilder.AppendLine();
			}

			if (pGetIndexer.Setter == null) {
				return;
			}

			//string keys = As3Helpers.GetParams(pIndexer.parameters.parameters);

			pBuilder.AppendFormat(
				"{0}function {1}({2}):void {{",
				  As3Helpers.ConvertModifiers(pGetIndexer.Setter.Modifiers),
				  pGetIndexer.Setter.Name,
				  As3Helpers.GetParameters(pGetIndexer.Setter.Arguments)
			);

			pBuilder.AppendLine();
			//BlockParser.InsideSetter = true;
			BlockParser.Parse(pGetIndexer.Setter.CodeBlock, pBuilder);
			//BlockParser.InsideSetter = false;
			pBuilder.AppendLine();
			//pBuilder.AppendLine("return value;");
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}
