namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class PrimaryExpressionMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//expression "." identifier (type-argument-list?)
			CsPrimaryExpressionMemberAccess ex = (CsPrimaryExpressionMemberAccess)pStatement;
			string name;
			bool renamed = Helpers.GetRealName(ex, ex.identifier.identifier, out name);

			//if (ex.parent is CsInvocationExpression) {
				
			//}

			if (renamed) {
				return new Expression(name, pStatement.entity_typeref);
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
