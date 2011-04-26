namespace CsCompiler.AS3Writer {
	using System;
	using System.Collections.Generic;
	using CsParser;
	using Tools;

	public static class PropertyParser {
		private static readonly Dictionary<string, string> _notValidPropertyMod =
			new Dictionary<string, string> {
				{ @"readonly", "" },
				{ @"new", "override" }
			};

		public static void Parse(TheProperty pProperty, CodeBuilder pBuilder) {
			if (pProperty == null) return;
			bool isInterface = pProperty.MyClass.IsInterface;
			string type = As3Helpers.Convert(pProperty.ReturnType);

			if (pProperty.IsEmpty && !isInterface) {
				pBuilder.AppendFormat("private var _{0}:{1};", pProperty.Name, type);
				pBuilder.AppendLine();
			}

			TheClass parent = pProperty.MyClass;
			bool isStandardGetSet = false;
			while (parent.Base != null) {
				isStandardGetSet |= parent.FullName.StartsWith("flash.");
				parent = parent.Base;
			}

			if (pProperty.Getter != null) {//Getter
				if (isStandardGetSet) {//base is flash, use standard setter/getter
					pBuilder.AppendFormat("{0}function get {1}():{2}{3}",
						As3Helpers.ConvertModifiers(pProperty.Getter.Modifiers, _notValidPropertyMod),
						pProperty.Name,
						type,
						isInterface ? ";" : " {"
					);	

				} else {
					bool isEnum = false;

					foreach (string s in pProperty.MyClass.Implements) {
						if (!s.StartsWith("IEnumerator", StringComparison.Ordinal)) {
							continue;
						}

						isEnum = true;
						break;
					}

					isEnum &= pProperty.Getter.Name.Equals("get_Current");

					//bool isEnum = 
					//    pProperty.Getter.Name.Equals("get_Current") && 
					//    pProperty.MyClass.Implements.Contains()

					pBuilder.AppendFormat("{0}function {1}():{2}{3}",
						As3Helpers.ConvertModifiers(pProperty.Getter.Modifiers, _notValidPropertyMod),
						pProperty.Getter.Name,
						isEnum ? "*" : type,
						isInterface ? ";" : " {"
					);	
				}

				pBuilder.AppendLine();

				if (!isInterface) {
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
			}

			if (pProperty.Setter == null) {
				return;
			}

			if (isStandardGetSet) {//Setter
//base is flash, use standard setter/getter
				pBuilder.AppendFormat("{0}function set {1}(value:{2}):void{3}",
				                      As3Helpers.ConvertModifiers(pProperty.Setter.Modifiers, _notValidPropertyMod),
				                      pProperty.Name,
				                      type,
									  isInterface ? ";" : " {"
					);
			} else {
				pBuilder.AppendFormat("{0}function {1}(value:{2}):{2}{3}",
				                      As3Helpers.ConvertModifiers(pProperty.Setter.Modifiers, _notValidPropertyMod),
				                      pProperty.Setter.Name,
				                      type,
									  isInterface ? ";" : " {"
					);
			}

			pBuilder.AppendLine();

			if (!isInterface) {
				if (pProperty.IsEmpty) {
					pBuilder.Indent();
					pBuilder.AppendFormat("_{0} = value;", pProperty.Name);
					pBuilder.AppendLine();
					pBuilder.Append("return value;");
					pBuilder.Unindent();

				} else {
					BlockParser.InsideSetter = !isStandardGetSet;
					BlockParser.Parse(pProperty.Setter.CodeBlock, pBuilder);
					BlockParser.InsideSetter = false;
					if (!isStandardGetSet)
						pBuilder.AppendLine("	return value;");
				}

				pBuilder.AppendLine();
				pBuilder.AppendLine("}");	
			}
			
			pBuilder.AppendLine();
		}
	}
}