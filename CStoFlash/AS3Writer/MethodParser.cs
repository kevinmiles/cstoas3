namespace CStoFlash.AS3Writer {
	using DDW;
	using Utils;

	public static class MethodParser {
		public static void Parse(NamespaceNode pNn, ClassNode pCn, MethodNode pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendFormat("{0}function {1}({2}):{3} {{", 
				Helpers.GetModifiers(pNode.Modifiers), 
				pNode.Names[0].GenericIndependentIdentifier,
				Helpers.GetParams(pNode.Params),
			    Helpers.ConvertType(pNode.Type)
			);

			pSb.AppendLine();
			BlockParser.ParseStatementBlock(pNn, pCn, pNode.StatementBlock, pSb, pScope);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		public static void ParseConstructor(NamespaceNode pNn, ClassNode pCn, ConstructorNode pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendFormat("{0}function {1}({2}) {{",
				Helpers.GetModifiers(pNode.Modifiers),
				pNode.Names[0].GenericIndependentIdentifier,
				Helpers.GetParams(pNode.Params)
			);

			pSb.AppendLine();
			BlockParser.ParseStatementBlock(pNn, pCn, pNode.StatementBlock, pSb, pScope);
			pSb.AppendLine();
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		
	}
}