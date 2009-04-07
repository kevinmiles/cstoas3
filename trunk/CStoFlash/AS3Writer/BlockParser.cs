using System;

namespace CStoFlash.AS3Writer {
	using System.Text;
	using DDW;
	using CodeBuilder= Utils.CodeBuilder;

	internal static class BlockParser {
		private static int _enumCount;

		internal static void ParseStatementBlock(BlockStatement blockStatement, CodeBuilder sb) {
			sb.Indent();
			foreach (StatementNode statement in blockStatement.Statements) {

				if (statement is LocalDeclarationStatement) {//local variable
					LocalDeclarationStatement lds = (LocalDeclarationStatement) statement;
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
						sb.AppendLine();
					}

				} else if (statement is IfStatement) {
					IfStatement ifs = (IfStatement) statement;

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
					sb.AppendLine();
					 
				} else if (statement is ExpressionStatement) {
					sb.AppendLine(parseExpressionNode(((ExpressionStatement)statement).Expression)+";");
					
				} else if (statement is ForEachStatement) {
					ForEachStatement fes = (ForEachStatement) statement;
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
					sb.AppendLine();
					
				} else if (statement is ForStatement) {


				} else if (statement is SwitchStatement) {


				} else if (statement is ReturnStatement) {
					ReturnStatement rs = (ReturnStatement)statement;
					sb.AppendFormat("return{0};", rs.ReturnValue == null ? "" : parseExpressionNode(rs.ReturnValue));

				} else {
					throw new Exception("Unhandled Statement:"+ statement);
				}
			}

			sb.Unindent();
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