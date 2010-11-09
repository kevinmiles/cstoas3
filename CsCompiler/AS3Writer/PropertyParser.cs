namespace CsCompiler.AS3Writer {
	using CsParser;

	public static class PropertyParser {
		public static void Parse(TheProperty pProperty, As3Builder pBuilder) {
			if (pProperty == null) return;

			string type = As3Helpers.Convert(pProperty.ReturnType);

			if (pProperty.IsEmpty) {
				pBuilder.AppendFormat("private var _{0}:{1};", pProperty.Name, type);
				pBuilder.AppendLine();
			}

			if (pProperty.Getter != null) {
				//Getter
				bool isEnum = pProperty.Getter.Name.Equals("get_Current") && pProperty.MyClass.Implements.Contains("IEnumerator");

				pBuilder.AppendFormat("{0}function {1}():{2} {{",
					As3Helpers.ConvertModifiers(pProperty.Getter.Modifiers),
					pProperty.Getter.Name,
					isEnum ? "*" : type
				);

				pBuilder.AppendLine();

				if (pProperty.IsEmpty) {
					pBuilder.Indent();
					pBuilder.AppendFormat("return _{0};", pProperty.Name);
					pBuilder.Unindent();

				} else {
					BlockParser.Parse(pProperty.Getter.CodeBlock, pBuilder);
				}

				pBuilder.AppendLine();
				pBuilder.AppendLine("}");
				pBuilder.AppendLine();	
			}


			if (pProperty.Setter == null) {
				return;
			}

			//Setter
			pBuilder.AppendFormat("{0}function {1}(value:{2}):{2} {{",
			                      As3Helpers.ConvertModifiers(pProperty.Setter.Modifiers),
			                      pProperty.Setter.Name,
			                      type
				);

			pBuilder.AppendLine();

			if (pProperty.IsEmpty) {
				pBuilder.Indent();
				pBuilder.AppendFormat("_{0} = value;", pProperty.Name);
				pBuilder.AppendLine();
				pBuilder.Append("return value;");
				pBuilder.Unindent();

			} else {
				BlockParser.InsideSetter = true;
				BlockParser.Parse(pProperty.Setter.CodeBlock, pBuilder);
				BlockParser.InsideSetter = false;
				pBuilder.AppendLine("	return value;");
			}

			pBuilder.AppendLine();
			pBuilder.AppendLine("}");
			pBuilder.AppendLine();
		}
	}
}