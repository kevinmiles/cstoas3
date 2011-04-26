namespace CsCompiler.JsWriter.Expressions {
	using System;
	using CsParser;
	using Metaspec;
	using Tools;

	public class PredefinedTypeMemberAccess : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//embedded-type "." identifier
			CsPredefinedTypeMemberAccess ex = pStatement as CsPredefinedTypeMemberAccess;
			string name;
			bool renamed = Helpers.GetRealName(ex, ex.identifier.identifier, out name);

			if (renamed) {
				return new Expression(name, pStatement.entity_typeref);
			}

			CsEntityProperty p = ex.entity as CsEntityProperty;
			if (p != null) {
				//getter, rename
				name = "get_" + name + "()";

			} else if (ex.ec == expression_classification.ec_event_access) {//remove eventhandler name
				name = string.Empty;
			}
			//FactoryExpressionCreator.Parse(ex.expression).Value
			return new Expression(
				 "nose" + "." + name,
				pStatement.entity_typeref
			);
		}
	}
}
