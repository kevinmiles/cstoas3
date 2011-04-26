namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;

			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value
				+ " "
				+ JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + " " + JsHelpers.Convert(Helpers.GetType(ex.type)),
				ex.entity_typeref
			);
		}
	}
}
