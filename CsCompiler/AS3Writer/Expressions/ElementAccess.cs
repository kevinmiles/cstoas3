namespace CsCompiler.AS3Writer.Expressions {
	using System.Collections.Generic;
	using CsParser;
	using Metaspec;
	using Tools;

	public class BaseIndexerAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			// "base" "[" expression-list "]"
			CsBaseIndexerAccess indexerAccess = (CsBaseIndexerAccess) pStatement;

			return ElementAccessHelper.getIndexerExpression(indexerAccess, indexerAccess.expression_list.list, null, false, false, pCreator);
		}
	}

	public class ElementAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			return ElementAccessHelper.parseElementAccess(pStatement, false, false, pCreator);
		}
	}

	internal static class ElementAccessHelper {
		internal static Expression parseElementAccess(CsExpression pStatement, bool pForce, bool pGetSetter, FactoryExpressionCreator pCreator) {
			//expression "[" expression-list "]"
			CsElementAccess stat = (CsElementAccess)pStatement;

			List<CsExpression> l = new List<CsExpression>();
			foreach (CsArgument csArgument in stat.argument_list.list) {
				l.Add(csArgument.expression);
			}

			return getIndexerExpression(stat, l,
															pCreator.Parse(stat.expression), pForce, pGetSetter, pCreator);
		}

		internal static Expression getIndexerExpression(CsExpression pStatement, IEnumerable<CsExpression> pList,
														Expression pIndexer, bool pForce, bool pGetSetter, FactoryExpressionCreator pCreator) {
			TheClass k = TheClassFactory.Get(pStatement, pCreator);

			List<string> indexes = new List<string>();
			List<CsEntityTypeRef> param = new List<CsEntityTypeRef>();

			foreach (CsExpression ex in pList) {
				Expression te = pCreator.Parse(ex);
				indexes.Add(te.Value);
				param.Add(te.Type);
			}

			string exp = pIndexer == null ? "super" : pIndexer.Value;
			bool isInternal = false;
			TheIndexer i = null;
			if (k != null)
				i = k.GetIndexer(pStatement);

			//TODO: Check array access...
			if (i == null || pIndexer == null || (pIndexer.Type != null && pIndexer.Type.type == cs_entity_type.et_array)) {
				//Array access or unknown accessor
				exp += "[" + indexes[0] + "]";

			} else {
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

			return new Expression(exp, pStatement.entity_typeref, isInternal);
		}
	}
}