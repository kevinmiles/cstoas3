namespace CsCompiler.AS3Writer {
	using System.Collections.Generic;
	using CsParser;
	using Tools;

	public static class IndexerParser {
		private static readonly Dictionary<string, string> _notValidMod =
			new Dictionary<string, string> {
				{"new", null},
				{"abstract", null}
			};

		public static void Parse(TheIndexer pGetIndexer, CodeBuilder pBuilder) {
			bool isInterface = pGetIndexer.MyClass.IsInterface;

			if (pGetIndexer.Getter != null) {
				pBuilder.AppendFormat("{0}function {1}({2}):{3}{4}",
					As3Helpers.ConvertModifiers(pGetIndexer.Getter.Modifiers, _notValidMod),
					pGetIndexer.Getter.Name,
					As3Helpers.GetParameters(pGetIndexer.Getter.Arguments),
					As3Helpers.Convert(pGetIndexer.ReturnType),
					isInterface ? ";":" {"
				);
				pBuilder.AppendLine();

				if (!isInterface) {
					BlockParser.Parse(pGetIndexer.Getter.CodeBlock, pBuilder);
					pBuilder.AppendLine();
					pBuilder.AppendLine("}");
					pBuilder.AppendLine();	
				}
			}

			if (pGetIndexer.Setter == null) {
				return;
			}

			pBuilder.AppendFormat(
				"{0}function {1}({2}):void{3}",
				  As3Helpers.ConvertModifiers(pGetIndexer.Setter.Modifiers, _notValidMod),
				  pGetIndexer.Setter.Name,
				  As3Helpers.GetParameters(pGetIndexer.Setter.Arguments),
				  isInterface ? ";" : " {"
			);

			pBuilder.AppendLine();
			if (isInterface)
				return;
			//BlockParser.InsideSetter = true;
			BlockParser.Parse(pGetIndexer.Setter.CodeBlock, pBuilder);
			//BlockParser.InsideSetter = false;
			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}
