namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class SimpleName : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			return SimpleNameHelper.ParseSimpleName(pStatement, false, false);
		}
	}

	internal sealed class SimpleNameHelper {
		public static Expression ParseSimpleName(CsExpression pStatement, bool pForce, bool pGetSetter) {
			CsSimpleName ex = (CsSimpleName)pStatement;

			bool isInternal = false;
			string val;

			if (ex.ec == expression_classification.ec_property_access) {
				CsAssignmentExpression parent = pStatement.parent as CsAssignmentExpression;

				if (!pForce) {
					pGetSetter = parent != null && parent.lhs.Equals(pStatement);
				}

				isInternal = true;
				CsEntityProperty property = (CsEntityProperty)ex.entity;
				val = pGetSetter ? string.Format("{0}({{0}})", property.setter.name) : string.Format("{0}()", property.getter.name);


			} else {
				//val = ex.identifier.identifier;
				Helpers.GetRealName(ex, ex.identifier.identifier, out val);
			}

			return new Expression(
				val,
				ex.entity_typeref,
				isInternal);
		}
	}
}
