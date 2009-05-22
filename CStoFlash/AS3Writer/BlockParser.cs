
namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;
	using System.Text;

	using Metaspec;

	using Utils;

	public sealed class BlockParser {
		private static int _enumCount;
		//private static readonly char[] _trimEnd = new[] {',', ' ',';'};

		static readonly Dictionary<Type, parseFunc> _statementWritters = new Dictionary<Type, parseFunc>();
		//static readonly Dictionary<Type, parseNodeFunc> _nodeWritters = new Dictionary<Type, parseNodeFunc>();

		private delegate void parseFunc(CsStatement pStatement, CodeBuilder pSb);
		//private delegate string parseNodeFunc(CsNode pStatement);

		static BlockParser() {
			_statementWritters.Add(typeof(CsLocalVariableDeclaration), parseLocalVariable);
			_statementWritters.Add(typeof(CsIfStatement), parseIfStatement);
			_statementWritters.Add(typeof(CsExpressionStatement), parseExpressionStatement);
			_statementWritters.Add(typeof(CsForeachStatement), parseForeachStatement);
			_statementWritters.Add(typeof(CsForStatement), parseForStatement);
			_statementWritters.Add(typeof(CsSwitchStatement), parseSwitchStatement);
			_statementWritters.Add(typeof(CsBreakStatement), parseBreakStatement);
			_statementWritters.Add(typeof(CsReturnStatement), parseReturnStatement);
		}

		public static void Parse(CsBlock pCsBlock, CodeBuilder pSb) {
			pSb.Indent();

			if (pCsBlock.statements != null) {
				foreach (CsStatement statement in pCsBlock.statements) {
					parseStatement(statement, pSb);
				}
			}

			pSb.Unindent();
		}

		public static void ParseBlockOrStatementOrExpression(CsNode pNode, CodeBuilder pSb) {
			CsBlock block = pNode as CsBlock;
			if (block != null) {
				Parse(block, pSb);
				return;
			}

			CsStatement statement = pNode as CsStatement;
			if (statement != null) {
				pSb.Indent();
				parseStatement(statement, pSb);
				pSb.Unindent();
				return;
			}

			Expression ex = Expression.Parse(pNode as CsExpression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static string parseNode(CsNode pNode){
			Expression ex = Expression.Parse(pNode as CsExpression);
			return ex.Value;
		}

		private static void parseLocalVariable(CsStatement pStatement, CodeBuilder pSb) {
			CsLocalVariableDeclaration localVariableDeclaration = (CsLocalVariableDeclaration)pStatement;
			foreach (CsLocalVariableDeclarator declarator in localVariableDeclaration.declarators) {

				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("var {0}:{1}",
					declarator.identifier.identifier,
					As3Helpers.Convert(ParserHelper.GetType(localVariableDeclaration.type))
				);

				if (declarator.initializer == null) {
					sb.Append(";");

				} else {
					sb.AppendFormat(" = {0};", parseNode(declarator.initializer));
				}

				pSb.Append(sb.ToString());
				pSb.AppendLine();
			}
		}

		private static void parseIfStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsIfStatement ifStatement = (CsIfStatement)pStatement;

			pSb.AppendFormat("if ({0}){{", Expression.Parse(ifStatement.condition));
			pSb.AppendLine();

			ParseBlockOrStatementOrExpression(ifStatement.if_statement, pSb);

			if (ifStatement.else_statement != null) {
				pSb.AppendLine();
				pSb.Append("} else {");
				pSb.AppendLine();
				pSb.AppendLine();
				ParseBlockOrStatementOrExpression(ifStatement.else_statement, pSb);
			}

			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseForStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsForStatement forStatement = (CsForStatement)pStatement;

			StringBuilder sb = new StringBuilder("for (");

			CsLocalVariableDeclaration localVariableDeclaration = (CsLocalVariableDeclaration)forStatement.initializer;
			if (localVariableDeclaration != null && localVariableDeclaration.declarators.Count > 0) {
				sb.Append("var ");
				int count = localVariableDeclaration.declarators.Count;
				int now = 0;

				foreach (CsLocalVariableDeclarator declarator in localVariableDeclaration.declarators) {

					sb.AppendFormat("{0}:{1}",
						declarator.identifier.identifier,
						As3Helpers.Convert(ParserHelper.GetType(localVariableDeclaration.type))
					);

					now++;

					if (declarator.initializer != null) {
						sb.AppendFormat(" = {0}", parseNode(declarator.initializer));
					} 

					if (now < count) {
						sb.Append(", ");
					}
				}

				sb.Append("; ");
			}

			sb.Append(Expression.Parse(forStatement.condition).Value);
			sb.Append("; ");

			CsStatementExpressionList expressionList = (CsStatementExpressionList) forStatement.iterator;

			if (expressionList != null) {
				foreach (CsExpression expression in expressionList.expressions) {
					Expression ex = Expression.Parse(expression);
					sb.Append(ex.Value);
					sb.Append(", ");
				}

				sb.Remove(sb.Length - 2, 2);
			}

			sb.Append("){");
			pSb.AppendLine(sb.ToString());
			ParseBlockOrStatementOrExpression(forStatement.statement, pSb);
			pSb.AppendLine("}");
			pSb.AppendLine();

		}

		private static void parseForeachStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsForeachStatement fes = (CsForeachStatement)pStatement;

			_enumCount++;
			string enumName = String.Format("__ie{0}", _enumCount);
			pSb.AppendLine();
			pSb.AppendFormat("var {0}:IEnumerator = {1}.getEnumerator();",
				enumName, Expression.Parse(fes.expression).Value);
			pSb.AppendLine();

			pSb.AppendFormat("while ({0}.moveNext()){{", enumName);
			pSb.AppendLine();

			string type = As3Helpers.Convert(ParserHelper.GetType(fes.type));

			pSb.AppendFormat("\tvar {1}:{2} = {0}.current as {2};",
				enumName,
				fes.identifier.identifier,
				type
			);

			pSb.AppendLine();
			ParseBlockOrStatementOrExpression(fes.statement, pSb);
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		private static void parseSwitchStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsSwitchStatement switchStatement = (CsSwitchStatement)pStatement;

			pSb.AppendFormat("switch ({0}){{", Expression.Parse(switchStatement.expression).Value);
			pSb.AppendLine();
			pSb.Indent();

			foreach (CsSwitchSection caseNode in switchStatement.sections) {
				LinkedList<CsSwitchLabel> labels = caseNode.labels;
				foreach (CsSwitchLabel label in labels){
					if (label.bDefault) {
						pSb.Append("default:");
						pSb.AppendLine();

					} else {
						Expression txt = Expression.Parse(label.expression);
						pSb.AppendFormat("case {0}:", txt.Value);
						pSb.AppendLine();
					}
				}

				foreach (CsStatement statementNode in caseNode.statements) {
					pSb.Indent();
					parseStatement(statementNode, pSb);
					pSb.Unindent();
				}
			}

			pSb.Unindent();
			pSb.Append("}");
			pSb.AppendLine();
		}

		private static void parseBreakStatement(CsStatement pStatement, CodeBuilder pSb) {
			pSb.Append("break;");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseExpressionStatement(CsStatement pStatement, CodeBuilder pSb) {
			Expression ex = Expression.Parse(((CsExpressionStatement)pStatement).expression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static void parseReturnStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsReturnStatement returnStatement = (CsReturnStatement) pStatement;
			if (returnStatement.expression == null) {
				pSb.AppendLine("return;");

			} else {
				pSb.AppendFormat("return {0};", Expression.Parse(returnStatement.expression).Value);
				pSb.AppendLine();
			}
		}


		private static void parseStatement(CsStatement pStatement, CodeBuilder pSb) {
			Type type = pStatement.GetType();

			if (_statementWritters.ContainsKey(type)) {
				_statementWritters[type](pStatement, pSb);

			} else {
				throw new NotImplementedException("Statement of type: " + pStatement + " not implemented");
			}
		}
	}
}