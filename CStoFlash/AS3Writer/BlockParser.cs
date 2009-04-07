using System;

namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;
	using System.Text;
	using DDW;
	using DDW.Collections;

	using CodeBuilder= Utils.CodeBuilder;

	public static class BlockParser {
		private static int _enumCount;
		private static readonly char[] _trimEnd = new[] {',', ' ',';'};

		public static void ParseStatementBlock(BlockStatement blockStatement, CodeBuilder sb) {
			sb.Indent();
			foreach (StatementNode statement in blockStatement.Statements) {
				parseStatementNode(statement, sb);
				sb.AppendLine();
			}

			sb.Unindent();
		}

		private static void parseStatementNode(StatementNode pNode, CodeBuilder sb) {
			if (pNode is LocalDeclarationStatement) {//local variable
				LocalDeclarationStatement lds = (LocalDeclarationStatement)pNode;
				string kind = lds.IsConstant ? "const" : "var";
				foreach (Declarator declarator in lds.Declarators) {

					string initializer;
					if (declarator.Initializer == null) {
						initializer = ";";
					} else {
						initializer = " = " + parseExpressionNode(declarator.Initializer) + ";";
					}

					sb.AppendFormat("{0} {1}:{2}{3}",
						kind,
						declarator.Identifier.Identifier,
						Helpers.ConvertType(lds.Type),
						initializer);
				}

			} else if (pNode is IfStatement) {
				IfStatement ifs = (IfStatement)pNode;

				sb.AppendFormat("if ({0}){{", parseExpressionNode(ifs.Test));
				sb.AppendLine();

				ParseStatementBlock(ifs.Statements, sb);
				sb.AppendLine();

				if (ifs.ElseStatements.Statements.Count != 0) {
					sb.AppendLine();
					sb.AppendLine("} else {");
					ParseStatementBlock(ifs.ElseStatements, sb);
				}

				sb.AppendLine("}");

			} else if (pNode is ExpressionStatement) {
				sb.AppendLine(parseExpressionNode(((ExpressionStatement)pNode).Expression) + ";");

			} else if (pNode is ForEachStatement) {
				ForEachStatement fes = (ForEachStatement)pNode;
				_enumCount++;
				string enumName = String.Format("ie{0}", _enumCount);
				sb.AppendLine();
				sb.AppendFormat("var {0}:IEnumerator = {1}.getEnumerator();",
					enumName, parseExpressionNode(fes.Collection));
				sb.AppendLine();

				sb.AppendFormat("while ({0}.moveNext()){{", enumName);
				sb.AppendLine();
				sb.AppendFormat("\tvar {1}:{2} = {0}.current as {2};",
					enumName,
					fes.Iterator.Name,
					Helpers.ConvertType(fes.Iterator.Type)
				);

				sb.AppendLine();

				ParseStatementBlock(fes.Statements, sb);

				sb.AppendLine("}");

			} else if (pNode is ForStatement) {
				ForStatement fs = (ForStatement)pNode;

				sb.AppendFormat("for ({0}; {1}; {2}){{",
					getExpressions(fs.Init), parseExpressionNode(fs.Test), getExpressions(fs.Inc));

				sb.AppendLine();

				ParseStatementBlock(fs.Statements, sb);

				sb.AppendLine("}");

			} else if (pNode is SwitchStatement) {
				SwitchStatement ss = (SwitchStatement)pNode;

				sb.AppendFormat("switch ({0}){{", parseExpressionNode(ss.Test));
				sb.AppendLine();
				sb.Indent();

				foreach (CaseNode caseNode in ss.Cases) {
					string txt;
					if (caseNode.IsDefaultCase) {
						txt = "default";

					} else {
						//TODO: Ranges??
						if (caseNode.Ranges.Count != 1)
							throw new Exception();

						txt = parseExpressionNode(caseNode.Ranges[0]);
					}

					sb.AppendFormat("case {0}:", txt);
					sb.AppendLine();

					foreach (StatementNode statementNode in caseNode.Statements) {
						parseStatementNode(statementNode, sb);
					}
				}

				sb.Unindent();
				sb.AppendLine("}");

			} else if (pNode is ReturnStatement) {
				ReturnStatement rs = (ReturnStatement)pNode;
				sb.AppendFormat("return{0};", rs.ReturnValue == null ? "" : parseExpressionNode(rs.ReturnValue));

			} else if (pNode is BreakStatement) {
				sb.AppendLine("break;");

			} else {
				throw new Exception("Unhandled Statement:" + pNode);
			}
		}

		private static string getExpressions(IEnumerable<ExpressionNode> pNodes) {
			string init = String.Empty;

			foreach (ExpressionNode expressionNode in pNodes) {
				init += parseExpressionNode(expressionNode) + ", ";
			}

			return init.TrimEnd(_trimEnd);
		}

		private static string parseExpressionNode(ExpressionNode pNode) {
			if (pNode is ObjectCreationExpression) {
				return makeObjectCreation((ObjectCreationExpression) pNode);
			}

			if (pNode is StringPrimitive) {
				return "\"" + ((StringPrimitive)pNode).Value + "\"";
			}

			if (pNode is BinaryExpression) {
				BinaryExpression be = (BinaryExpression)pNode;
				return parseExpressionNode(be.Left) + " " + Helpers.ConvertTokenId(be.Op) + " " + parseExpressionNode(be.Right);
			}

			if (pNode is MemberAccessExpression) {
				MemberAccessExpression mac = (MemberAccessExpression)pNode;
				return parseExpressionNode(mac.Left) + Helpers.ConvertTokenId(mac.QualifierKind) + parseExpressionNode(mac.Right);
			}

			if (pNode is IdentifierExpression) {
				IdentifierExpression ie = (IdentifierExpression) pNode;
				if (ie.StartsWithPredefinedType) {
					throw new Exception("Not Implemented");
				}
				return ie.Identifier;
			}

			if (pNode is NullPrimitive) {
				return "null";
			}

			if (pNode is InvocationExpression) {
				return makeInvocation((InvocationExpression)pNode);
			}

			if (pNode is ElementAccessExpression) {
				return makeElementAccess((ElementAccessExpression) pNode);
			}

			if (pNode is BooleanPrimitive) {
				return ((BooleanPrimitive)pNode).Value ? "true" : "false";
			}

			if (pNode is IntegralPrimitive) {
				return ((IntegralPrimitive)pNode).Value.ToString();
			}

			if (pNode is UnaryExpression) {
				UnaryExpression ue = ((UnaryExpression)pNode);

				return Helpers.ConvertTokenId(ue.Op) + parseExpressionNode(ue.Child);
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
						initializer = " = " + parseExpressionNode(declarator.Initializer) + ";";
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
				return parseExpressionNode(pie.Expression)+"++";
			}

			if (pNode is ConditionalExpression) {
				ConditionalExpression ce = ((ConditionalExpression)pNode);
				return "(" + parseExpressionNode(ce.Test) + ") ? " + parseExpressionNode(ce.Left) + " : " + parseExpressionNode(ce.Right);
			}

			throw new Exception("Expression node not implemented:" + pNode);
		}


		/// <summary>
		/// Creates a new Object <c>new Constructor(param1, param2, ..., paramN)</c>
		/// </summary>
		/// <param name="oce"></param>
		/// <returns></returns>
		private static string makeObjectCreation(ObjectCreationExpression oce) {
			StringBuilder sb = new StringBuilder("new "+Helpers.ConvertType(oce.Type));
			sb.Append("(");
			foreach (ArgumentNode argumentNode in oce.ArgumentList) {
				sb.Append(parseExpressionNode(argumentNode.Expression));
				sb.Append(", ");
			}

			if (oce.ArgumentList.Count != 0)
				sb.Remove(sb.Length - 2, 2);

			sb.Append(")");
			return sb.ToString();
		}

		/// <summary>
		/// Access an element by accessors  ([]);
		/// </summary>
		/// <param name="eae"></param>
		/// <returns></returns>
		private static string makeElementAccess(ElementAccessExpression eae) {
			StringBuilder sb = new StringBuilder(parseExpressionNode(eae.LeftSide));
			sb.Append('[');

			foreach (ExpressionNode node in eae.Expressions) {
				sb.Append(parseExpressionNode(node));
			}

			sb.Append(']');

			return sb.ToString();
		}
		/// <summary>
		/// Makes an invocation call <c>MethodName(param1, param2..., paramN)</c>
		/// </summary>
		/// <param name="ie"></param>
		/// <returns></returns>
		private static string makeInvocation(InvocationExpression ie) {
			StringBuilder sb = new StringBuilder(parseExpressionNode(ie.LeftSide));
			sb.Append("(");
			
			foreach (ArgumentNode argumentNode in ie.ArgumentList) {
				sb.Append(parseExpressionNode(argumentNode.Expression));
				sb.Append(", ");
			}

			if (ie.ArgumentList.Count != 0) 
				sb.Remove(sb.Length - 2, 2);

			sb.Append(")");
			return sb.ToString();
		}
	}
}