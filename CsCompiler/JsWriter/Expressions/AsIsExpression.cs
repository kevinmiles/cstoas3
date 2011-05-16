namespace CsCompiler.JsWriter.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;

			return new Expression(
				pCreator.Parse(ex.expression).Value
				+ " "
				+ JsHelpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + " " + JsHelpers.Convert(Helpers.GetType(ex.type)),
				ex.entity_typeref
			);
		}
	}
}
