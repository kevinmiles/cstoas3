namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class PrimaryExpressionMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//expression "." identifier (type-argument-list?)
			CsPrimaryExpressionMemberAccess ex = (CsPrimaryExpressionMemberAccess)pStatement;
			string name = ex.identifier.identifier;
			if (ex.parent is CsInvocationExpression) {
				name = Helpers.GetRealName(ex, name);
			}

			if (ex.ec == expression_classification.ec_event_access) {//remove eventhandler name
				name = string.Empty;
			}

			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value + "." + name,
				pStatement.entity_typeref
			);
		}
	}
}
