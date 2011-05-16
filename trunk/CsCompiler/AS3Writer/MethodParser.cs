namespace CsCompiler.AS3Writer {
	using System.Collections.Generic;
	using CsParser;
	using Tools;

	public static class MethodParser {
		private static readonly Dictionary<string, string> _notValidConstructorMod =
			new Dictionary<string, string> {
				{ "private", "public" },
				{ "abstract", "public"}
			};

		private static readonly Dictionary<string, string> _notValidMethodMod =
			new Dictionary<string, string> {
				{ "abstract", ""},
				{ "new", ""}
			};

		public static void Parse(TheConstructor pConstructor, CodeBuilder pBuilder, FactoryExpressionCreator pCreator) {
			if (pConstructor.IsStaticConstructor) {
				pBuilder.Append("{");

			} else {
				pBuilder.AppendFormat("{4}{0}function {1}({2}){3} {{",
								ClassParser.IsMainClass ? "private " : As3Helpers.ConvertModifiers(pConstructor.Modifiers, _notValidConstructorMod),
								ClassParser.IsMainClass ? @"$ctor" : pConstructor.Name,
								As3Helpers.GetParameters(pConstructor.Arguments),
								ClassParser.IsMainClass ? ":void" : string.Empty,// pConstructor.MyClass.Name,
								pConstructor.OverridesBaseConstructor ? "override " : string.Empty
					);
			}

			pBuilder.AppendLine();

			if (pConstructor.HasBaseCall) {
				pBuilder.AppendFormat("\tsuper({0});", As3Helpers.GetCallingArguments(pConstructor.BaseArguments));
				pBuilder.AppendLine();
			}
		
			BlockParser.Parse(pConstructor.CodeBlock, pBuilder, pCreator);

			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}

		public static void Parse(TheMethod pMethod, CodeBuilder pBuilder, FactoryExpressionCreator pCreator) {
			if (pMethod == null) return;
			bool isInterface = pMethod.MyClass.IsInterface;

			Dictionary<string,string> nonValidMethod = new Dictionary<string, string>(_notValidMethodMod);
			if (ClassParser.IsExtension) {
				nonValidMethod.Add("static",string.Empty);
			}

			pBuilder.AppendFormat("{0}function {1}({2}):{3}{4}",
				As3Helpers.ConvertModifiers(pMethod.Modifiers, nonValidMethod),
				pMethod.Name,
				As3Helpers.GetParameters(pMethod.Arguments),
				As3Helpers.Convert(pMethod.ReturnType),
				isInterface ? ";":" {"
			);

			pBuilder.AppendLine();

			if (isInterface)
				return;

			pBuilder.AppendLine();
			BlockParser.Parse(pMethod.CodeBlock, pBuilder, pCreator);
			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}