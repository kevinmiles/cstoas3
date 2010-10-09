namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;
	using CsParser;

	public static class MethodParser {
		private static readonly Dictionary<string, string> _notValidConstructorMod =
			new Dictionary<string, string> {
				{ "private", "public" },
				{ "abstract", "public"}
			};

		public static void Parse(TheConstructor pConstructor, As3Builder pBuilder) {
			if (pConstructor.IsStaticConstructor) {
				pBuilder.Append("{");

			} else {
				pBuilder.AppendFormat("{4}{0}function {1}({2}):{3} {{",
								 As3Helpers.ConvertModifiers(pConstructor.Modifiers, _notValidConstructorMod),
								 pConstructor.Name,
								 As3Helpers.GetParameters(pConstructor.Arguments),
								 pConstructor.RealName,
								 pConstructor.OverridesBaseConstructor ? "override " : string.Empty
					);
			}

			pBuilder.AppendLine();

			//Si hay un constructor sin parámetros, usarlo como constructor de la clase.
			//De esta manera se va a respetar el super() sin tener que hacer hacks...
			TheConstructor constructor = pConstructor.BaseConstructor;
			TheConstructor parentConstructor = pConstructor.ParentConstructor;
			if (constructor != null) {
				if (!pConstructor.HasBaseCall && parentConstructor != null) {
					pBuilder.AppendFormat("\tsuper.{0}();",
						parentConstructor.Name
					);

					pBuilder.AppendLine();
				}

				pBuilder.AppendFormat("\t{0}{1}({2});",
					pConstructor.HasBaseCall ? "super." : string.Empty,
					constructor.Name,
					As3Helpers.GetCallingArguments(pConstructor.BaseArguments)
				);

				pBuilder.AppendLine();
				
			} else if (parentConstructor != null){
				pBuilder.AppendFormat("\tsuper.{0}();",
					parentConstructor.Name
				);
				pBuilder.AppendLine();
			}

			BlockParser.InsideConstructor = !pConstructor.IsStaticConstructor;
			BlockParser.Parse(pConstructor.CodeBlock, pBuilder);
			BlockParser.InsideConstructor = false;

			if (!pConstructor.IsStaticConstructor)
				pBuilder.AppendLine("\treturn this;");

			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}

		public static void Parse(TheMethod pMethod, As3Builder pBuilder) {
			pBuilder.AppendFormat("{0}function {1}({2}):{3} {{",
				As3Helpers.ConvertModifiers(pMethod.Modifiers, null),
				pMethod.Name,
				As3Helpers.GetParameters(pMethod.Arguments),
				As3Helpers.Convert(pMethod.ReturnType)
			);

			pBuilder.AppendLine();
			BlockParser.Parse(pMethod.CodeBlock, pBuilder);
			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}