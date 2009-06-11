namespace CStoFlash.AS3Writer {
	using System;
	using System.Collections.Generic;
	using System.Text;

	using Metaspec;

	using Utils;

	public class Expression {
		private delegate Expression parseFunc(CsExpression pStatement);
		static readonly Dictionary<Type, parseFunc> _parsers = new Dictionary<Type, parseFunc>();

		static Expression() {
			_parsers.Add(typeof(CsBinaryExpression), parseBinaryExpression);
			_parsers.Add(typeof(CsArrayInitializer), parseArrayInitializer);
			_parsers.Add(typeof(CsAsIsExpression), parseAsIsExpression);
			_parsers.Add(typeof(CsAssignmentExpression), parseAssignmentExpression);
			_parsers.Add(typeof(CsConditionalExpression), parseConditionalExpression);
			_parsers.Add(typeof(CsLambdaExpression), parseLambdaExpression);

			_parsers.Add(typeof(CsUncheckedExpression), parseUncheckedExpression);
			_parsers.Add(typeof(CsTypeofExpression), parseTypeofExpression);
			_parsers.Add(typeof(CsThisAccess), parseThisAccess);
			_parsers.Add(typeof(CsSizeofExpression), parseSizeofExpression);
			_parsers.Add(typeof(CsSimpleName), parseSimpleName);
			_parsers.Add(typeof(CsRefValueExpression), parseRefValueExpression);
			_parsers.Add(typeof(CsRefTypeExpression), parseRefTypeExpression);
			_parsers.Add(typeof(CsQueryExpression), parseQueryExpression);
			_parsers.Add(typeof(CsQualifiedAliasMemberAccess), parseQualifiedAliasMemberAccess);
			_parsers.Add(typeof(CsPrimaryExpressionMemberAccess), parsePrimaryExpressionMemberAccess);
			_parsers.Add(typeof(CsPredefinedTypeMemberAccess), parsePredefinedTypeMemberAccess);
			_parsers.Add(typeof(CsPostIncrementDecrementExpression), parsePostIncrementDecrementExpression);
			_parsers.Add(typeof(CsPointerMemberAccess), parsePointerMemberAccess);
			_parsers.Add(typeof(CsParenthesizedExpression), parseParenthesizedExpression);
			_parsers.Add(typeof(CsNewObjectExpression), parseNewObjectExpression);
			_parsers.Add(typeof(CsNewArrayExpression), parseNewArrayExpression);
			_parsers.Add(typeof(CsMakeRefExpression), parseMakeRefExpression);
			_parsers.Add(typeof(CsLiteral), parseLiteral);
			_parsers.Add(typeof(CsInvocationExpression), parseInvocationExpression);
			_parsers.Add(typeof(CsElementAccess), parseElementAccess);
			_parsers.Add(typeof(CsDefaultValueExpression), parseDefaultValueExpression);
			_parsers.Add(typeof(CsCheckedExpression), parseCheckedExpression);
			_parsers.Add(typeof(CsBaseMemberAccess), parseBaseMemberAccess);
			_parsers.Add(typeof(CsBaseIndexerAccess), parseBaseIndexerAccess);
			_parsers.Add(typeof(CsArgListExpression), parseArgListExpression);
			_parsers.Add(typeof(CsAnonymousObjectCreationExpression), parseAnonymousObjectCreationExpression);
			_parsers.Add(typeof(CsAnonymousMethodExpression), parseAnonymousMethodExpression);

			_parsers.Add(typeof(CsCastUnaryExpression), parseCastUnaryExpression);
			_parsers.Add(typeof(CsOperatorUnaryExpression), parseOperatorUnaryExpression);
			_parsers.Add(typeof(CsPreIncrementDecrementExpression), parsePreIncrementDecrementExpression);
		}

		private static Expression parseAnonymousMethodExpression(CsExpression pStatement) {
			//"delegate" (explicit-anonymous-function-signature)? block
			throw new NotImplementedException();
		}

		private static Expression parseAnonymousObjectCreationExpression(CsExpression pStatement) {
			//"new" anonymous-object-initializer
			// "{" member-declarator-list? "}"
			//"{" member-declarator-list "," "}"
			//
			throw new NotImplementedException();
		}

		private static Expression parseArgListExpression(CsExpression pStatement) {
			 //__arglist ( "(" expresion-list ")" )?
			throw new NotImplementedException();
		}

		private static Expression parseBaseMemberAccess(CsExpression pStatement) {
			// "base" "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}

		private static Expression parseCheckedExpression(CsExpression pStatement) {
			//"checked" "(" expression ")"
			throw new NotImplementedException();
		}

		private static Expression parseDefaultValueExpression(CsExpression pStatement) {
			// "default" ( type )
			throw new NotImplementedException();
		}

		private static Expression parseElementAccess(CsExpression pStatement) {
			return parseElementAccess(pStatement, false, false);
		}

		private static Expression parseBaseIndexerAccess(CsExpression pStatement) {
			// "base" "[" expression-list "]"
			CsBaseIndexerAccess indexerAccess = (CsBaseIndexerAccess)pStatement;

			return getIndexerExpression(
				indexerAccess, 
				indexerAccess.expression_list.list, null, 
				false, 
				false
			);
		}

		private static Expression parseElementAccess(CsExpression pStatement, bool pForce, bool pGetSetter) {
			//expression "[" expression-list "]"
			CsElementAccess stat = (CsElementAccess)pStatement;

			return getIndexerExpression(
				stat, 
				stat.expressions.list, 
				Parse(stat.expression), 
				pForce, 
				pGetSetter
			);
		}

		private static Expression getIndexerExpression(CsExpression pStatement, IEnumerable<CsExpression> pList, Expression pIndexer, bool pForce, bool pGetSetter) {
			TheClass k = TheClass.Get(pStatement);
			
			List<string> indexes = new List<string>();
			List<string> param = new List<string>();

			foreach (CsExpression ex in pList) {
				Expression te = Parse(ex);
				indexes.Add(te.Value);
				param.Add(te.Type);
			}

			string exp = pIndexer == null ? "super" : pIndexer.Value;
			bool isInternal = false;

			if (k == null || pIndexer == null || (pIndexer.Type != null && pIndexer.Type.Contains("["))) {//Array access or unknown accessor
				exp += "[" + indexes[0] + "]";

			} else {
				TheIndexers i = k.GetIndexer(pStatement);
				//TheIndexers i = k.GetIndexerBySignature(param);
				isInternal = true;

				CsAssignmentExpression parent = pStatement.parent as CsAssignmentExpression;

				if (!pForce)
					pGetSetter = parent != null && parent.lhs.Equals(pStatement);

				if (pGetSetter) {
					exp += "." + i.Setter.Name + "(" + string.Join(", ", indexes.ToArray()) + ", {0})";

				} else {
					exp += "." + i.Getter.Name + "(" + string.Join(", ", indexes.ToArray()) + ")";
				}
			}

			return new Expression(exp, ParserHelper.GetType(pStatement.entity_typeref), isInternal);
		}

		private static Expression parseInvocationExpression(CsExpression pStatement) {
			CsInvocationExpression ex = (CsInvocationExpression)pStatement;
			TheClass k = TheClass.Get(pStatement);

			List<string> indexes = new List<string>();

			foreach (CsArgument argument in ex.argument_list.list) {
				indexes.Add(Parse(argument.expression).Value);
			}

			string name = getRealName(ex, k == null ?
				Parse(ex.expression).Value :
				k.GetMethod((CsMethod)((CsEntityMethod)ex.entity).decl).Name);

			//patch
			if (name.Contains("{0}")) {
				string p = indexes[0];
				indexes.RemoveAt(0);
				name = string.Format(name, p, string.Join(", ", indexes.ToArray()));

			} else {
				name = name + "(" + string.Join(", ", indexes.ToArray()) + ")";
			}

			return new Expression(
				name, 
				ParserHelper.GetType(ex.entity_typeref)
			);
		}

		private static Expression parseMakeRefExpression(CsExpression pStatement) {
			// __makeref "(" expresion ")"
			throw new NotImplementedException();
		}

		private static Expression parseNewArrayExpression(CsExpression pStatement) {
			//"new" non-array-type "[" expression-list "]" ( rank-specifiers )? ( array-initializer )?
			//"new" non-array-type? rank-specifiers array-initializer
			throw new NotImplementedException();
		}

		private static Expression parseNewObjectExpression(CsExpression pExpression) {
			//object-creation-expression: 
			//"new" type "(" ( argument_list )? ")" object-or-collection-initializer? 
			//"new" type object-or-collection-initializer

			//delegate-creation-expression: 
			//"new" delegate-type "(" expression ")"
			CsNewObjectExpression node = (CsNewObjectExpression)pExpression;
			StringBuilder sb = new StringBuilder();
			sb.Append("new ");
			sb.Append(As3Helpers.Convert(ParserHelper.GetType(node.type)));
			sb.Append("(");

			if (node.argument_list != null) {
				foreach (CsArgument argument in node.argument_list.list) {
					Expression ex = Parse(argument.expression);
					sb.Append(ex.Value);
					sb.Append(", ");
				}

				sb.Remove(sb.Length - 2, 2);
			}

			sb.Append(")");

			return new Expression(
				sb.ToString(),
				ParserHelper.GetType(pExpression.entity_typeref)
			);
		}

		private static Expression parseParenthesizedExpression(CsExpression pStatement) {
			//"(" expression ")"
			throw new NotImplementedException();
		}

		private static Expression parsePointerMemberAccess(CsExpression pStatement) {
			// expression "->" identifier (type-argument-list?)
			throw new NotImplementedException();
		}

		private static Expression parsePredefinedTypeMemberAccess(CsExpression pExpression) {
			//embedded-type "." identifier
			throw new NotImplementedException();
		}

		private static Expression parsePrimaryExpressionMemberAccess(CsExpression pExpression) {
			//expression "." identifier (type-argument-list?)
			CsPrimaryExpressionMemberAccess ex = (CsPrimaryExpressionMemberAccess)pExpression;

			string name = ex.identifier.identifier;
			if (ex.parent is CsInvocationExpression) {
				name = getRealName(ex, name);
			}

			return new Expression(
				Parse(ex.expression).Value + "." + name,
				ParserHelper.GetType(pExpression.entity_typeref)
			);
		}

		private static Expression parseQualifiedAliasMemberAccess(CsExpression pExpression) {
			//identifier "::" identifier (type-argument-list)? "." identifier (type-argument-list)?
			throw new NotImplementedException();
		}

		private static Expression parseQueryExpression(CsExpression pExpression) {
			//from-clause query-body
			throw new NotImplementedException();
		}

		private static Expression parseRefTypeExpression(CsExpression pExpression) {
			//__reftype "(" expresion ")"
			throw new NotImplementedException();
		}

		private static Expression parseRefValueExpression(CsExpression pExpression) {
			//__refvalue "(" expresion "," type ")"
			throw new NotImplementedException();
		}

		private static Expression parseSizeofExpression(CsExpression pExpression) {
			//"sizeof" "(" type ")"
			throw new NotImplementedException();
		}

		private static Expression parseThisAccess(CsExpression pExpression) {
			//CsThisAccess ex = (CsThisAccess)pExpression;
			return new Expression("this", ParserHelper.GetType(pExpression.entity_typeref));
		}

		private static Expression parseTypeofExpression(CsExpression pExpression) {
			CsTypeofExpression ex = (CsTypeofExpression)pExpression;
			//"typeof" "(" type ")"
			throw new NotImplementedException();
		}

		private static Expression parseUncheckedExpression(CsExpression pExpression) {
			throw new NotImplementedException();
		}

		private static Expression parsePreIncrementDecrementExpression(CsExpression pExpression) {
			CsPreIncrementDecrementExpression ex = (CsPreIncrementDecrementExpression)pExpression;

			Expression exp = Parse(ex.unary_expression);

			return new Expression(
				ParserHelper.GetTokenType(ex.oper) + exp.Value,
				ParserHelper.GetType(pExpression.entity_typeref)
			);
		}

		private static Expression parsePostIncrementDecrementExpression(CsExpression pStatement) {
			CsPostIncrementDecrementExpression ex = (CsPostIncrementDecrementExpression)pStatement;

			Expression exp = Parse(ex.expression);
			if (exp.InternalType) {
				if (ex.expression is CsElementAccess) {
					string setter = parseElementAccess(ex.expression, true, true).Value;

					switch (ex.oper) {
						case CsTokenType.tkINC:
							return new Expression(string.Format(setter, exp.Value + "++"), exp.Type);

						case CsTokenType.tkDEC:
							return new Expression(string.Format(setter, exp.Value + "--"), exp.Type);

						default:
							throw new Exception();
					}

				}
			}

			switch (ex.oper) {
				case CsTokenType.tkINC:
					return new Expression(exp.Value + "++", exp.Type);

				case CsTokenType.tkDEC:
					return new Expression(exp.Value + "--", exp.Type);

				default:
					throw new NotImplementedException();
			}
		}

		private static Expression parseOperatorUnaryExpression(CsExpression pExpression) {
			CsOperatorUnaryExpression ex = (CsOperatorUnaryExpression)pExpression;

			return new Expression(
				ParserHelper.GetTokenType(ex.oper) + Parse(ex.unary_expression).Value,
				ParserHelper.GetType(pExpression.entity_typeref)
			);
		}

		private static Expression parseCastUnaryExpression(CsExpression pExpression) {
			CsCastUnaryExpression ex = (CsCastUnaryExpression)pExpression;

			return new Expression(
				As3Helpers.Convert(ParserHelper.GetType(ex.type)) + "(" + Parse(ex.unary_expression).Value + ")",
				ParserHelper.GetType(ex.type)
			);
		}

		private static Expression parseLambdaExpression(CsExpression pExpression) {
			CsLambdaExpression ex = (CsLambdaExpression)pExpression;

			throw new NotImplementedException();
		}

		private static Expression parseConditionalExpression(CsExpression pExpression) {
			CsConditionalExpression ex = (CsConditionalExpression)pExpression;

			return new Expression(
				Parse(ex.condition).Value + " ? "+
				Parse(ex.true_expression).Value + " : "+
				Parse(ex.false_expression).Value, 
				
				ParserHelper.GetType(pExpression.entity_typeref)
			);
		}

		private static Expression parseAssignmentExpression(CsExpression pExpression) {
			CsAssignmentExpression ex = (CsAssignmentExpression)pExpression;

			Expression left = Parse(ex.lhs);
			Expression right = Parse(ex.rhs);
			string type = ParserHelper.GetType(pExpression.entity_typeref);

			if ((ex.lhs is CsElementAccess) && left.InternalType) {
				switch (ex.oper){
					case CsTokenType.tkASSIGN:
						return new Expression(string.Format(left.Value, right.Value), type);

					case CsTokenType.tkPLUS_EQ:
					case CsTokenType.tkMINUS_EQ:
					case CsTokenType.tkDIV_EQ:
					case CsTokenType.tkMUL_EQ:
						string getter = parseElementAccess(ex.lhs, true, false).Value;
						return new Expression(string.Format(left.Value, getter + ParserHelper.GetTokenType(convertToken(ex.oper)) + right.Value), type);
				}
			}

			return new Expression(left.Value + ParserHelper.GetTokenType(ex.oper) + right.Value, type);
		}

		private static CsTokenType convertToken(CsTokenType pInToken) {
			switch (pInToken) {
				case CsTokenType.tkPLUS_EQ:
					return CsTokenType.tkPLUS;

				case CsTokenType.tkMINUS_EQ:
					return CsTokenType.tkMINUS;

				case CsTokenType.tkDIV_EQ:
					return CsTokenType.tkDIV;

				case CsTokenType.tkMUL_EQ:
					return CsTokenType.tkSTAR;

				case CsTokenType.tkMOD_EQ:
					return CsTokenType.tkMOD;

				default:
					throw new Exception();
			}
		}

		private static Expression parseAsIsExpression(CsExpression pExpression) {
			CsAsIsExpression ex = (CsAsIsExpression) pExpression;

			string asType = ParserHelper.GetType(ex.entity_typeref);

			return new Expression(
				Parse(ex.expression).Value + " " + ParserHelper.GetTokenType(ex.oper) + " " + asType,
				asType
			);
		}

		private static Expression parseArrayInitializer(CsExpression pExpression) {
			throw new NotImplementedException();
		}

		private static Expression parseSimpleName(CsExpression pExpression) {
			CsSimpleName ex = (CsSimpleName)pExpression;

			return new Expression(
				getRealName(ex, ex.identifier.identifier), 
				ParserHelper.GetType(ex.entity_typeref));
		}

		private static Expression parseLiteral(CsExpression pExpression) {
			CsLiteral li = (CsLiteral)pExpression;

			switch (li.type) {
				case CsTokenType.tkTRUE:
					return new Expression("true", "bool");

				case CsTokenType.tkFALSE:
					return new Expression("false", "bool");

				case CsTokenType.tkNULL:
					return new Expression("null", "null");

				default:
					switch (li.literal_type) {
						case CsLiteralType.literal_int:
							return new Expression(li.literal, "int");

						case CsLiteralType.literal_uint:
						case CsLiteralType.literal_uint_U:
							return new Expression(li.literal, "uint");

						case CsLiteralType.literal_long:
						case CsLiteralType.literal_long_L:
							return new Expression(li.literal, "long");

						case CsLiteralType.literal_decimal_M:
							return new Expression(li.literal, "decimal");

						case CsLiteralType.literal_ulong:
						case CsLiteralType.literal_ulong_L:
						case CsLiteralType.literal_ulong_UL:
							return new Expression(li.literal, "long");

						
						case CsLiteralType.literal_double_D:
						case CsLiteralType.literal_double:
							return new Expression(li.literal, "double");

						case CsLiteralType.literal_number:
							return new Expression(li.literal, "number");

						case CsLiteralType.literal_float_F:
							return new Expression(li.literal, "float");

						case CsLiteralType.literal_char:
							return new Expression("'" + li.literal + "'", "char");

						case CsLiteralType.literal_verbatim_string:
							string l = li.literal.Substring(2, li.literal.Length - 3);
							return new Expression(encodeString(l), "string");

						default:
							return new Expression(encodeString(li.literal), "string");
					}
			}
		}

		private static string getRealName(CsExpression pExpression, string pName) {
			object entity = pExpression.entity;
			IEnumerable<CsEntityAttribute> m;

			if (entity is CsEntityClass) {
				return getRealNameFromAttr(((CsEntityClass)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityVariable) {
				m = ((CsEntityVariable)pExpression.entity).attributes;
				addImports(m);
				return getRealNameFromAttr(m, pName);
			}

			if (entity is CsEntityEnum) {
				return getRealNameFromAttr(((CsEntityEnum)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityStruct) {
				return getRealNameFromAttr(((CsEntityStruct)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityConstant) {
				return getRealNameFromAttr(((CsEntityConstant)pExpression.entity).attributes, pName);
			}

			if (entity is CsEntityMethod) {
				m = ((CsEntityMethod) pExpression.entity).attributes;
				addImports(m);
				return getRealNameFromAttr(m, pName);
			}

			return pName;
		}

		private static void addImports(IEnumerable<CsEntityAttribute> pList) {
			if (pList == null)
				return;

			foreach (CsEntityAttribute attribute in pList) {
				if (!attribute.type.parent.name.Equals("As3NamespaceAttribute", StringComparison.Ordinal)) {
					continue;
				}

				ImportStatementList.AddImport(attribute.fixed_arguments[0].value.ToString());
			}
		}

		private static string getRealNameFromAttr(IEnumerable<CsEntityAttribute> pList, string pName) {
			if (pName.Equals("ToString", StringComparison.Ordinal))
				pName = "toString";

			if (pList == null)
				return pName;

			foreach (CsEntityAttribute attribute in pList) {
				if (!attribute.type.parent.name.Equals("As3NameAttribute", StringComparison.Ordinal)) {
					continue;
				}

				return (attribute.fixed_arguments[0]).value.ToString();
			}

			return pName;
		}

		private static string encodeString(string pIn) {
			return "\"" + pIn.Replace("\\","\\\\").Replace("\"", "\\\"") + "\"";
		}

		private static Expression parseBinaryExpression(CsExpression pExpression) {
			CsBinaryExpression li = (CsBinaryExpression)pExpression;

			Expression left = Parse(li.lhs);
			Expression right = Parse(li.rhs);

			return new Expression(left.Value + " " + ParserHelper.GetTokenType(li.oper) + " " + right.Value, ParserHelper.GetType(pExpression.entity_typeref));
		}

		public Expression() {
			Value = Type = "";
		}

		public Expression(string pValue, string pType) {
			Value = pValue;
			Type = pType;
		}

		public Expression(string pValue, string pType, bool pIsInternal) {
			Value = pValue;
			Type = pType;
			InternalType = pIsInternal;
		}

		public string Value {
			get;
			set;
		}

		public string Type {
			get;
			set;
		}

		public bool InternalType {
			get;
			set;
		}

		public override string ToString() {
			return Value;
		}

		public static Expression Parse(CsExpression pExpression) {
			if (pExpression != null) {
				Type type = pExpression.GetType();

				if (_parsers.ContainsKey(type)) {
					return _parsers[type](pExpression);
				}	
			}

			throw new NotImplementedException();
		}
	}
}
