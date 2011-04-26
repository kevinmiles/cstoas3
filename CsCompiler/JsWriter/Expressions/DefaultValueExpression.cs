namespace CsCompiler.JsWriter.Expressions {
	using Metaspec;
	using Tools;

	public class DefaultValueExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			// "default" ( type )
			return new Expression(
				null,
				pStatement.entity_typeref
			);
		}
	}
}
