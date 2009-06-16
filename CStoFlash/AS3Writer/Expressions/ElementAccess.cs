namespace CStoFlash.AS3Writer.Expressions {
	using System.Collections.Generic;

	using Metaspec;

	using Utils;

	public class BaseIndexerAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			// "base" "[" expression-list "]"
			CsBaseIndexerAccess indexerAccess = (CsBaseIndexerAccess) pStatement;

			return ElementAccessHelper.getIndexerExpression(indexerAccess, indexerAccess.expression_list.list, null, false, false);
		}
	}

	public class ElementAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			return ElementAccessHelper.parseElementAccess(pStatement, false, false);
		}
	}

	internal static class ElementAccessHelper {
		internal static Expression parseElementAccess(CsExpression pStatement, bool pForce, bool pGetSetter) {
			//expression "[" expression-list "]"
			CsElementAccess stat = (CsElementAccess)pStatement;

			return getIndexerExpression(stat, stat.expressions.list,
															FactoryExpressionCreator.Parse(stat.expression), pForce, pGetSetter);
		}

		internal static Expression getIndexerExpression(CsExpression pStatement, IEnumerable<CsExpression> pList,
		                                                Expression pIndexer, bool pForce, bool pGetSetter) {
			TheClass k = TheClass.Get(pStatement);

			List<string> indexes = new List<string>();
			List<string> param = new List<string>();

			foreach (CsExpression ex in pList) {
				Expression te = FactoryExpressionCreator.Parse(ex);
				indexes.Add(te.Value);
				param.Add(te.Type);
			}

			string exp = pIndexer == null ? "super" : pIndexer.Value;
			bool isInternal = false;

			if (k == null || pIndexer == null || (pIndexer.Type != null && pIndexer.Type.Contains("["))) {
				//Array access or unknown accessor
				exp += "[" + indexes[0] + "]";

			} else {
				TheIndexers i = k.GetIndexer(pStatement);
				//TheIndexers i = k.GetIndexerBySignature(param);
				isInternal = true;

				CsAssignmentExpression parent = pStatement.parent as CsAssignmentExpression;

				if (!pForce) {
					pGetSetter = parent != null && parent.lhs.Equals(pStatement);
				}

				if (pGetSetter) {
					exp += "." + i.Setter.Name + "(" + string.Join(", ", indexes.ToArray()) + ", {0})";

				} else {
					exp += "." + i.Getter.Name + "(" + string.Join(", ", indexes.ToArray()) + ")";
				}
			}

			return new Expression(exp, ParserHelper.GetType(pStatement.entity_typeref), isInternal);
		}
	}
}