using System;

namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;
	using System.Text;
	using DDW;

	using Utils;

	public static class BlockParser {
		private static int _enumCount;
		private static readonly char[] _trimEnd = new[] {',', ' ',';'};

		public static void ParseStatementBlock(NamespaceNode pNn, ClassNode pCn, BlockStatement pBlockStatement, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.Indent();
			pScope.Indent();
			
			foreach (StatementNode statement in pBlockStatement.Statements) {
				ParseStatementNode(pNn, pCn, statement, pSb, pScope);
				pSb.AppendLine();
			}

			pScope.Unindent();
			pSb.Unindent();
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, LocalDeclarationStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			string kind = pNode.IsConstant ? "const" : "var";
			foreach (Declarator declarator in pNode.Declarators) {
				string initializer;

				if (declarator.Initializer == null) {
					initializer = ";";

				} else {
					initializer = " = " + parseExpressionNode(pNn, pCn, declarator.Initializer, pScope) + ";";
				}

				pScope.Insert(declarator.Identifier.Identifier, pNode.Type);

				pSb.AppendFormat("{0} {1}:{2}{3}",
					kind,
					declarator.Identifier.Identifier,
					Helpers.ConvertType(pNode.Type),
					initializer);
			}
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, IfStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendFormat("if ({0}){{", parseExpressionNode(pNn, pCn, pNode.Test, pScope));
			pSb.AppendLine();

			ParseStatementBlock(pNn, pCn, pNode.Statements, pSb, pScope);

			if (pNode.ElseStatements.Statements.Count != 0) {
				pSb.AppendLine();
				pSb.AppendLine("} else {");
				ParseStatementBlock(pNn, pCn, pNode.ElseStatements, pSb, pScope);
			}

			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, ExpressionStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendLine(parseExpressionNode(pNn, pCn, pNode.Expression, pScope) + ";");
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, ForEachStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			_enumCount++;
			string enumName = String.Format("ie{0}", _enumCount);
			pSb.AppendLine();
			pSb.AppendFormat("var {0}:IEnumerator = {1}.getEnumerator();",
				enumName, parseExpressionNode(pNn, pCn, pNode.Collection, pScope));
			pSb.AppendLine();

			pSb.AppendFormat("while ({0}.moveNext()){{", enumName);
			pSb.AppendLine();
			pSb.AppendFormat("\tvar {1}:{2} = {0}.current as {2};",
				enumName,
				pNode.Iterator.Name,
				Helpers.ConvertType(pNode.Iterator.Type)
			);

			pScope.Insert(pNode.Iterator.Name, pNode.Iterator.Type);

			pSb.AppendLine();
			ParseStatementBlock(pNn, pCn, pNode.Statements, pSb, pScope);
			pSb.AppendLine("}");
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, ForStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			if (pCn == null) {
				throw new ArgumentNullException("pCn");
			}
			pSb.AppendFormat("for ({0}; {1}; {2}){{",
					getExpressions(pNn, pCn, pNode.Init, pScope), parseExpressionNode(pNn, pCn, pNode.Test, pScope), getExpressions(pNn, pCn, pNode.Inc, pScope));

			pSb.AppendLine();
			ParseStatementBlock(pNn, pCn, pNode.Statements, pSb, pScope);
			pSb.AppendLine("}");
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, SwitchStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendFormat("switch ({0}){{", parseExpressionNode(pNn, pCn, pNode.Test, pScope));
			pSb.AppendLine();
			pSb.Indent();

			foreach (CaseNode caseNode in pNode.Cases) {
				string txt;
				if (caseNode.IsDefaultCase) {
					txt = "default";

				} else {
					//TODO: Ranges??
					if (caseNode.Ranges.Count != 1)
						throw new Exception();

					txt = parseExpressionNode(pNn, pCn, caseNode.Ranges[0], pScope);
				}

				pSb.AppendFormat("case {0}:", txt);
				pSb.AppendLine();

				foreach (StatementNode statementNode in caseNode.Statements) {
					ParseStatementNode(pNn, pCn, statementNode, pSb, pScope);
				}
			}

			pSb.Unindent();
			pSb.AppendLine("}");
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, ReturnStatement pNode, CodeBuilder pSb, ScopeBlock pScope) {
			pSb.AppendFormat("return{0};", pNode.ReturnValue == null ? "" : parseExpressionNode(pNn, pCn, pNode.ReturnValue, pScope));
		}

		public static void ParseStatementNode(NamespaceNode pNn, ClassNode pCn, StatementNode pNode, CodeBuilder pSb, ScopeBlock pScope) {
			if (pNode is LocalDeclarationStatement) {//local variable
				ParseStatementNode(pNn, pCn, (LocalDeclarationStatement)pNode, pSb, pScope);

			} else if (pNode is IfStatement) {
				ParseStatementNode(pNn, pCn, (IfStatement)pNode, pSb, pScope);

			} else if (pNode is ExpressionStatement) {
				ParseStatementNode(pNn, pCn, (ExpressionStatement)pNode, pSb, pScope);

			} else if (pNode is ForEachStatement) {
				ParseStatementNode(pNn, pCn, (ForEachStatement)pNode, pSb, pScope);

			} else if (pNode is ForStatement) {
				ParseStatementNode(pNn, pCn, (ForStatement)pNode, pSb, pScope);

			} else if (pNode is SwitchStatement) {
				ParseStatementNode(pNn, pCn, (SwitchStatement)pNode, pSb, pScope);

			} else if (pNode is ReturnStatement) {
				ParseStatementNode(pNn, pCn, (ReturnStatement)pNode, pSb, pScope);

			} else if (pNode is BreakStatement) {
				pSb.AppendLine("break;");

			} else {
				throw new Exception("Unhandled Statement:" + pNode);
			}
		}

		private static string getExpressions(NamespaceNode pNn, ClassNode pCn, IEnumerable<ExpressionNode> pNodes, ScopeBlock pScope) {
			string init = String.Empty;

			foreach (ExpressionNode expressionNode in pNodes) {
				init += parseExpressionNode(pNn, pCn, expressionNode, pScope) + ", ";
			}

			return init.TrimEnd(_trimEnd);
		}

		private static string parseExpressionNode(NamespaceNode pNn, ClassNode pCn, ExpressionNode pNode, ScopeBlock pScope) {
			if (pNode is ObjectCreationExpression) {
				return makeObjectCreation(pNn, pCn, (ObjectCreationExpression)pNode, pScope);
			}

			if (pNode is StringPrimitive) {
				return "\"" + ((StringPrimitive)pNode).Value + "\"";
			}

			if (pNode is BinaryExpression) {
				BinaryExpression be = (BinaryExpression)pNode;
				return parseExpressionNode(pNn, pCn, be.Left, pScope) + " " + Helpers.ConvertTokenId(be.Op) + " " + parseExpressionNode(pNn, pCn, be.Right, pScope);
			}

			if (pNode is MemberAccessExpression) {
				MemberAccessExpression mac = (MemberAccessExpression)pNode;
				return parseExpressionNode(pNn, pCn, mac.Left, pScope) + Helpers.ConvertTokenId(mac.QualifierKind) + parseExpressionNode(pNn, pCn, mac.Right, pScope);
			}

			if (pNode is IdentifierExpression) {
				IdentifierExpression ie = (IdentifierExpression) pNode;
				if (ie.StartsWithPredefinedType) {
					throw new Exception("Not Implemented");
				}

				return ie.Identifier.Equals("base") ? "super" : ie.Identifier;
			}

			if (pNode is NullPrimitive) {
				return "null";
			}

			if (pNode is InvocationExpression) {
				return makeInvocation(pNn, pCn, (InvocationExpression)pNode, pScope);
			}

			if (pNode is ElementAccessExpression) {
				return makeElementAccess(pNn, pCn, (ElementAccessExpression) pNode, pScope);
			}

			if (pNode is BooleanPrimitive) {
				return ((BooleanPrimitive)pNode).Value ? "true" : "false";
			}

			if (pNode is IntegralPrimitive) {
				return ((IntegralPrimitive)pNode).Value.ToString();
			}

			if (pNode is UnaryExpression) {
				UnaryExpression ue = ((UnaryExpression)pNode);

				return Helpers.ConvertTokenId(ue.Op) + parseExpressionNode(pNn, pCn, ue.Child, pScope);
			}

			if (pNode is LocalDeclaration) {
				LocalDeclaration ue = ((LocalDeclaration)pNode);

				string kind = ue.IsConstant ? "const" : "var";
				StringBuilder sb = new StringBuilder();

				foreach (Declarator declarator in ue.Declarators) {

					string initializer;
					if (declarator.Initializer == null) {
						initializer = ";";
					} else {
						initializer = " = " + parseExpressionNode(pNn, pCn, declarator.Initializer, pScope) + ";";
					}

					sb.AppendFormat("{0} {1}:{2}{3}",
						kind,
						declarator.Identifier.Identifier,
						Helpers.ConvertType(ue.Type),
						initializer);
				}

				return sb.ToString();
			}

			if (pNode is PostIncrementExpression) {
				PostIncrementExpression pie = ((PostIncrementExpression)pNode);
				return parseExpressionNode(pNn, pCn, pie.Expression, pScope) + "++";
			}

			if (pNode is ConditionalExpression) {
				ConditionalExpression ce = ((ConditionalExpression)pNode);
				return "(" + parseExpressionNode(pNn, pCn, ce.Test, pScope) + ") ? " + parseExpressionNode(pNn, pCn, ce.Left, pScope) + " : " + parseExpressionNode(pNn, pCn, ce.Right, pScope);
			}

			throw new Exception("Expression node not implemented:" + pNode);
		}


		/// <summary>
		/// Creates a new Object <c>new Constructor(param1, param2, ..., paramN)</c>
		/// </summary>
		private static string makeObjectCreation(NamespaceNode pNn, ClassNode pCn, ObjectCreationExpression pOce, ScopeBlock pScope) {
			StringBuilder sb = new StringBuilder("new "+Helpers.ConvertType(pOce.Type));
			sb.Append("(");
			foreach (ArgumentNode argumentNode in pOce.ArgumentList) {
				sb.Append(parseExpressionNode(pNn, pCn, argumentNode.Expression, pScope));
				sb.Append(", ");
			}

			if (pOce.ArgumentList.Count != 0)
				sb.Remove(sb.Length - 2, 2);

			sb.Append(")");
			return sb.ToString();
		}

		/// <summary>
		/// Access an element by accessors  ([]);
		/// </summary>
		private static string makeElementAccess(NamespaceNode pNn, ClassNode pCn, ElementAccessExpression pEae, ScopeBlock pScope) {
			string baseIndexer = parseExpressionNode(pNn, pCn, pEae.LeftSide, pScope);

			StringBuilder sb = new StringBuilder(baseIndexer);

			string name = IndexerParser.GetGetterName(pNn, pCn, pScope.Search(baseIndexer));

			if (String.IsNullOrEmpty(name)) {
				sb.Append('[');

			} else {
				sb.Append(".");
				sb.Append(name);
				sb.Append('(');
			}

			foreach (ExpressionNode node in pEae.Expressions) {
				sb.Append(parseExpressionNode(pNn, pCn, node, pScope));
			}

			if (String.IsNullOrEmpty(name)) {
				sb.Append(']');

			} else {
				sb.Append(")");
			}

			return sb.ToString();
		}
		/// <summary>
		/// Makes an invocation call <c>MethodName(param1, param2..., paramN)</c>
		/// </summary>
		private static string makeInvocation(NamespaceNode pNn, ClassNode pCn, InvocationExpression pIe, ScopeBlock pScope) {
			StringBuilder sb = new StringBuilder(parseExpressionNode(pNn, pCn, pIe.LeftSide, pScope));
			sb.Append("(");
			
			foreach (ArgumentNode argumentNode in pIe.ArgumentList) {
				sb.Append(parseExpressionNode(pNn, pCn, argumentNode.Expression, pScope));
				sb.Append(", ");
			}

			if (pIe.ArgumentList.Count != 0) 
				sb.Remove(sb.Length - 2, 2);

			sb.Append(")");
			return sb.ToString();
		}
	}
}