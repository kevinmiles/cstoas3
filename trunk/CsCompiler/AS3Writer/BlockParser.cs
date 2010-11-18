namespace CsCompiler.AS3Writer {
	using System;
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class BlockParser {
		private static int _enumCount;
		//private static readonly char[] _trimEnd = new[] {',', ' ',';'};

		static readonly Dictionary<Type, Action<CsStatement, CodeBuilder>> _statementWritters = new Dictionary<Type, Action<CsStatement, CodeBuilder>>();
		public static bool InsideSetter;
		private static bool _insideEnumerator;

		static BlockParser() {
			_statementWritters.Add(typeof(CsDeclarationStatement), parseLocalVariable);
			_statementWritters.Add(typeof(CsIfStatement), parseIfStatement);
			_statementWritters.Add(typeof(CsExpressionStatement), parseExpressionStatement);
			_statementWritters.Add(typeof(CsForeachStatement), parseForeachStatement);
			_statementWritters.Add(typeof(CsForStatement), parseForStatement);
			_statementWritters.Add(typeof(CsSwitchStatement), parseSwitchStatement);
			_statementWritters.Add(typeof(CsBreakStatement), parseBreakStatement);
			_statementWritters.Add(typeof(CsReturnStatement), parseReturnStatement);
			_statementWritters.Add(typeof(CsThrowStatement), parseThrowStatement);
			_statementWritters.Add(typeof(CsWhileStatement), parseWhileStatement);
			_statementWritters.Add(typeof(CsContinueStatement), parseContinueStatement);
		}

		private static void parseContinueStatement(CsStatement pStatement, CodeBuilder pSb) {
			//CsContinueStatement continueStatement = (CsContinueStatement)pStatement;

			pSb.Append("continue");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseWhileStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsWhileStatement whileStatement = (CsWhileStatement)pStatement;

			pSb.AppendFormat("while ({0}){{", FactoryExpressionCreator.Parse(whileStatement.condition));
			pSb.AppendLine();
			ParseBlockOrStatementOrExpression(whileStatement.statement, pSb);
			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}


		private static void parseThrowStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsThrowStatement throwStatement = (CsThrowStatement)pStatement;
			pSb.AppendFormat("throw {0};", parseNode(throwStatement.expression));
		}

		public static void Parse(CsBlock pCsBlock, CodeBuilder pSb) {
			if (pCsBlock == null) 
				return;

			pSb.Indent();

			if (pCsBlock.statements != null) {
				foreach (CsStatement statement in pCsBlock.statements) {
					parseStatement(statement, pSb);
				}
			}

			pSb.Unindent();
		}

		public static void ParseNode(CsNode pNode, CodeBuilder pSb) {
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

			CsExpression expression = pNode as CsExpression;
			if (expression != null) {
				Expression ex = FactoryExpressionCreator.Parse(pNode as CsExpression);
				pSb.Append(ex.Value + ";");
				pSb.AppendLine();
				return;
			}

			throw new Exception();
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

			Expression ex = FactoryExpressionCreator.Parse(pNode as CsExpression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static string parseNode(CsNode pNode){
			Expression ex = FactoryExpressionCreator.Parse(pNode as CsExpression);
			return ex.Value;
		}

		private static void parseLocalConstantDeclaration(CsStatement pStatement, CodeBuilder pSb) {
			CsDeclarationStatement declarationStatement = (CsDeclarationStatement)pStatement;

			CsLocalConstantDeclaration lcd = (CsLocalConstantDeclaration)declarationStatement.declaration;

			foreach (CsLocalConstantDeclarator declarator in lcd.declarators) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat(@"const {0}:{1} = {2};",
					declarator.identifier.identifier,
					As3Helpers.Convert(Helpers.GetType(lcd.type)),
					FactoryExpressionCreator.Parse(declarator.expression).Value
				);

				pSb.Append(sb.ToString());
				pSb.AppendLine();
			}
		}

		private static void parseLocalVariable(CsStatement pStatement, CodeBuilder pSb) {
			CsDeclarationStatement declarationStatement = (CsDeclarationStatement)pStatement;

			CsLocalVariableDeclaration localVariableDeclaration = declarationStatement.declaration as CsLocalVariableDeclaration;
			if (localVariableDeclaration == null) {
				parseLocalConstantDeclaration(pStatement, pSb);
				return;
			}
			
			foreach (var declarator in localVariableDeclaration.declarators) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("var {0}:{1}",
					declarator.identifier.identifier,
					As3Helpers.Convert(Helpers.GetType(localVariableDeclaration.type))
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

			pSb.AppendFormat("if ({0}){{", FactoryExpressionCreator.Parse(ifStatement.condition));
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

			CsLocalVariableDeclaration localVariableDeclaration = forStatement.initializer as CsLocalVariableDeclaration;
			CsStatementExpressionList expressionList;

			if (localVariableDeclaration == null) {
				expressionList = forStatement.initializer as CsStatementExpressionList;
				foreach (CsExpression expression in expressionList.expressions) {
					Expression ex = FactoryExpressionCreator.Parse(expression);
					sb.Append(ex.Value);
					sb.Append(", ");
				}

				sb.Remove(sb.Length - 2, 2);
				sb.Append("; ");

			} else if (localVariableDeclaration.declarators.Count > 0) {
				sb.Append("var ");
				int count = localVariableDeclaration.declarators.Count;
				int now = 0;

				foreach (CsLocalVariableDeclarator declarator in localVariableDeclaration.declarators) {

					sb.AppendFormat("{0}:{1}",
						declarator.identifier.identifier,
						As3Helpers.Convert(Helpers.GetType(localVariableDeclaration.type))
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

			sb.Append(FactoryExpressionCreator.Parse(forStatement.condition).Value);
			sb.Append("; ");

			expressionList = (CsStatementExpressionList) forStatement.iterator;

			if (expressionList != null) {
				foreach (CsExpression expression in expressionList.expressions) {
					Expression ex = FactoryExpressionCreator.Parse(expression);
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

			Expression ex = FactoryExpressionCreator.Parse(fes.expression);
			string type = As3Helpers.Convert(Helpers.GetType(fes.type));

			pSb.AppendLine();

			TheClass theClass = TheClassFactory.Get(ex.Type);

			if (ex.Type.type == cs_entity_type.et_array || ex.IsAs3Generic) {//foreach
				pSb.AppendFormat("for each(var {0}:{1} in {2}){{",
					fes.identifier.identifier,
					type,
					ex.Value);
				pSb.AppendLine();

			} else if (ex.Type.type == cs_entity_type.et_object ||
						ex.Type.type == cs_entity_type.et_generic_param || 
					(theClass != null && @"flash.utils.Dictionary".Equals(theClass.FullName))) {

				pSb.AppendFormat("for (var {0}:{1} in {2}){{",
					fes.identifier.identifier,
					type,
					ex.Value);

				pSb.AppendLine();
				if (ex.Type.type == cs_entity_type.et_object) {
					pSb.AppendFormat("	if (!{1}.hasOwnProperty({0})) continue;",
						fes.identifier.identifier,
						ex.Value
					);
				}

				pSb.AppendLine();

			} else {
				_enumCount++;
				//TheClass theClass = TheClassFactory.Get(fes.expression.entity_typeref);

				string enumName = String.Format(@"__ie{0}", _enumCount);
				pSb.AppendFormat("var {0}:IEnumerator = {1}.GetEnumerator();",
				enumName, ex.Value);
				pSb.AppendLine();
				pSb.AppendFormat("while ({0}.MoveNext()){{", enumName);
				pSb.AppendLine();

				pSb.AppendFormat("\tvar {1}:{2} = {0}.get_Current() as {2};",
					enumName,
					fes.identifier.identifier,
					type
				);

				_insideEnumerator = true;
				pSb.AppendLine();
				_insideEnumerator = false;
			}
			
			ParseBlockOrStatementOrExpression(fes.statement, pSb);
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		private static void parseSwitchStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsSwitchStatement switchStatement = (CsSwitchStatement)pStatement;

			pSb.AppendFormat("switch ({0}){{", FactoryExpressionCreator.Parse(switchStatement.expression).Value);
			pSb.AppendLine();
			pSb.Indent();

			foreach (CsSwitchSection caseNode in switchStatement.sections) {
				LinkedList<CsSwitchLabel> labels = caseNode.labels;
				foreach (CsSwitchLabel label in labels){
					if (label.default_label) {
						pSb.Append("default:");
						pSb.AppendLine();

					} else {
						Expression txt = FactoryExpressionCreator.Parse(label.expression);
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
			Expression ex = FactoryExpressionCreator.Parse(((CsExpressionStatement)pStatement).expression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static void parseReturnStatement(CsStatement pStatement, CodeBuilder pSb) {
			CsReturnStatement returnStatement = (CsReturnStatement) pStatement;
			if (returnStatement.expression == null) {
				//pSb.AppendLine(InsideConstructor ? "return this" : InsideSetter ? "return value;" : "return;");
				pSb.AppendLine(InsideSetter ? "return value;" : "return;");

			} else {
				pSb.AppendFormat("return {0};", FactoryExpressionCreator.Parse(returnStatement.expression).Value);
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