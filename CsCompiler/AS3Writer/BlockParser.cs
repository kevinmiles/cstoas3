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

		static readonly Dictionary<Type, Action<CsStatement, CodeBuilder, FactoryExpressionCreator>> _statementWritters = new Dictionary<Type, Action<CsStatement, CodeBuilder, FactoryExpressionCreator>>();
		public static bool InsideSetter;

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
			_statementWritters.Add(typeof(CsUsingStatement), parseUsingStatement);
		}

		private static void parseUsingStatement(CsStatement pArg1, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsUsingStatement statement = (CsUsingStatement)pArg1;
			CsLocalVariableDeclaration declaration = statement.resource as CsLocalVariableDeclaration;

			string varname;

			if (declaration == null) {
				varname = "$$using$$";
				Expression e = pCreator.Parse(statement.resource);

				pSb.AppendFormat("var {0}:{1} = {2};", 
					varname,
					As3Helpers.Convert(Helpers.GetType(e.Type)),
					e.Value
				);

				pSb.AppendLine();

			} else {
				CsLocalVariableDeclarator declarator = declaration.declarators.First.Value;
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("var {0}:{1}",
					declarator.identifier.identifier,
					As3Helpers.Convert(Helpers.GetType(declaration.type))
				);

				varname = declarator.identifier.identifier;

				if (declarator.initializer == null) {
					sb.Append(";");

				} else {
					sb.AppendFormat(" = {0};", parseNode(declarator.initializer, pCreator));
				}

				pSb.Append(sb.ToString());
				pSb.AppendLine();

			}

			pSb.Append("try {");
			pSb.AppendLine();

			ParseBlockOrStatementOrExpression(statement.statement, pSb, pCreator);

			pSb.Append("} finally {");
			pSb.AppendLine();
			pSb.AppendFormat("	if ({0} != null) {0}.Dispose();", varname);
			pSb.AppendLine();

			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseContinueStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			//CsContinueStatement continueStatement = (CsContinueStatement)pStatement;

			pSb.Append("continue");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseWhileStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsWhileStatement whileStatement = (CsWhileStatement)pStatement;

			pSb.AppendFormat("while ({0}){{", pCreator.Parse(whileStatement.condition));
			pSb.AppendLine();
			ParseBlockOrStatementOrExpression(whileStatement.statement, pSb, pCreator);
			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}


		private static void parseThrowStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsThrowStatement throwStatement = (CsThrowStatement)pStatement;
			pSb.AppendFormat("throw {0};", parseNode(throwStatement.expression, pCreator));
			pSb.AppendLine();
		}

		public static void Parse(CsBlock pCsBlock, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			if (pCsBlock == null) 
				return;

			pSb.Indent();

			if (pCsBlock.statements != null) {
				foreach (CsStatement statement in pCsBlock.statements) {
					parseStatement(statement, pSb, pCreator);
				}
			}

			pSb.Unindent();
		}

		public static void ParseNode(CsNode pNode, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsBlock block = pNode as CsBlock;
			if (block != null) {
				Parse(block, pSb, pCreator);
				return;
			}

			CsStatement statement = pNode as CsStatement;
			if (statement != null) {
				pSb.Indent();
				parseStatement(statement, pSb, pCreator);
				pSb.Unindent();
				return;
			}

			CsExpression expression = pNode as CsExpression;
			if (expression != null) {
				Expression ex = pCreator.Parse(pNode as CsExpression);
				pSb.Append(ex.Value + ";");
				pSb.AppendLine();
				return;
			}

			throw new Exception();
		}

		public static void ParseBlockOrStatementOrExpression(CsNode pNode, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsBlock block = pNode as CsBlock;
			if (block != null) {
				Parse(block, pSb, pCreator);
				return;
			}

			CsStatement statement = pNode as CsStatement;
			if (statement != null) {
				pSb.Indent();
				parseStatement(statement, pSb, pCreator);
				pSb.Unindent();
				return;
			}

			Expression ex = pCreator.Parse(pNode as CsExpression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static string parseNode(CsNode pNode, FactoryExpressionCreator pCreator) {
			Expression ex = pCreator.Parse(pNode as CsExpression);
			return ex.Value;
		}

		private static void parseLocalConstantDeclaration(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsDeclarationStatement declarationStatement = (CsDeclarationStatement)pStatement;

			CsLocalConstantDeclaration lcd = (CsLocalConstantDeclaration)declarationStatement.declaration;

			foreach (CsLocalConstantDeclarator declarator in lcd.declarators) {
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat(@"const {0}:{1} = {2};",
					declarator.identifier.identifier,
					As3Helpers.Convert(Helpers.GetType(lcd.type)),
					pCreator.Parse(declarator.expression).Value
				);

				pSb.Append(sb.ToString());
				pSb.AppendLine();
			}
		}

		private static void parseLocalVariable(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsDeclarationStatement declarationStatement = (CsDeclarationStatement)pStatement;

			CsLocalVariableDeclaration localVariableDeclaration = declarationStatement.declaration as CsLocalVariableDeclaration;
			if (localVariableDeclaration == null) {
				parseLocalConstantDeclaration(pStatement, pSb, pCreator);
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
					sb.AppendFormat(" = {0};", parseNode(declarator.initializer, pCreator));
				}

				pSb.Append(sb.ToString());
				pSb.AppendLine();
			}
		}

		private static void parseIfStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsIfStatement ifStatement = (CsIfStatement)pStatement;

			pSb.AppendFormat("if ({0}){{", pCreator.Parse(ifStatement.condition));
			pSb.AppendLine();

			ParseBlockOrStatementOrExpression(ifStatement.if_statement, pSb, pCreator);

			if (ifStatement.else_statement != null) {
				pSb.AppendLine();
				pSb.Append("} else {");
				pSb.AppendLine();
				pSb.AppendLine();
				ParseBlockOrStatementOrExpression(ifStatement.else_statement, pSb, pCreator);
			}

			pSb.Append("}");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseForStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsForStatement forStatement = (CsForStatement)pStatement;

			StringBuilder sb = new StringBuilder("for (");

			CsLocalVariableDeclaration localVariableDeclaration = forStatement.initializer as CsLocalVariableDeclaration;
			CsStatementExpressionList expressionList;

			if (localVariableDeclaration == null) {
				expressionList = forStatement.initializer as CsStatementExpressionList;
				foreach (CsExpression expression in expressionList.expressions) {
					Expression ex = pCreator.Parse(expression);
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
						sb.AppendFormat(" = {0}", parseNode(declarator.initializer, pCreator));
					} 

					if (now < count) {
						sb.Append(", ");
					}
				}

				sb.Append("; ");
			}

			sb.Append(pCreator.Parse(forStatement.condition).Value);
			sb.Append("; ");

			expressionList = (CsStatementExpressionList) forStatement.iterator;

			if (expressionList != null) {
				foreach (CsExpression expression in expressionList.expressions) {
					Expression ex = pCreator.Parse(expression);
					sb.Append(ex.Value);
					sb.Append(", ");
				}

				sb.Remove(sb.Length - 2, 2);
			}

			sb.Append("){");
			pSb.AppendLine(sb.ToString());
			ParseBlockOrStatementOrExpression(forStatement.statement, pSb, pCreator);
			pSb.AppendLine("}");
			pSb.AppendLine();

		}

		private static void parseForeachStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsForeachStatement fes = (CsForeachStatement)pStatement;

			Expression ex = pCreator.Parse(fes.expression);
			string type = As3Helpers.Convert(Helpers.GetType(fes.type));

			pSb.AppendLine();

			TheClass theClass = TheClassFactory.Get(ex.Type, pCreator);

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

				pSb.AppendLine();
			}

			ParseBlockOrStatementOrExpression(fes.statement, pSb, pCreator);
			pSb.AppendLine("}");
			pSb.AppendLine();
		}

		private static void parseSwitchStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsSwitchStatement switchStatement = (CsSwitchStatement)pStatement;

			pSb.AppendFormat("switch ({0}){{", pCreator.Parse(switchStatement.expression).Value);
			pSb.AppendLine();
			pSb.Indent();

			foreach (CsSwitchSection caseNode in switchStatement.sections) {
				LinkedList<CsSwitchLabel> labels = caseNode.labels;
				foreach (CsSwitchLabel label in labels){
					if (label.default_label) {
						pSb.Append("default:");
						pSb.AppendLine();

					} else {
						Expression txt = pCreator.Parse(label.expression);
						pSb.AppendFormat("case {0}:", txt.Value);
						pSb.AppendLine();
					}
				}

				foreach (CsStatement statementNode in caseNode.statements) {
					pSb.Indent();
					parseStatement(statementNode, pSb, pCreator);
					pSb.Unindent();
				}
			}

			pSb.Unindent();
			pSb.Append("}");
			pSb.AppendLine();
		}

		private static void parseBreakStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			pSb.Append("break;");
			pSb.AppendLine();
			pSb.AppendLine();
		}

		private static void parseExpressionStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			Expression ex = pCreator.Parse(((CsExpressionStatement)pStatement).expression);
			pSb.Append(ex.Value+";");
			pSb.AppendLine();
		}

		private static void parseReturnStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			CsReturnStatement returnStatement = (CsReturnStatement) pStatement;
			if (returnStatement.expression == null) {
				//pSb.AppendLine(InsideConstructor ? "return this" : InsideSetter ? "return value;" : "return;");
				pSb.AppendLine(InsideSetter ? "return value;" : "return;");

			} else {
				pSb.AppendFormat("return {0};", pCreator.Parse(returnStatement.expression).Value);
				pSb.AppendLine();
			}
		}


		private static void parseStatement(CsStatement pStatement, CodeBuilder pSb, FactoryExpressionCreator pCreator) {
			Type type = pStatement.GetType();

			if (_statementWritters.ContainsKey(type)) {
				_statementWritters[type](pStatement, pSb, pCreator);

			} else {
				throw new NotImplementedException("Statement of type: " + pStatement + " not implemented");
			}
		}
	}
}