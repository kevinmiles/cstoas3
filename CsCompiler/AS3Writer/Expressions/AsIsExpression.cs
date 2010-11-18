namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public class AsIsExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAsIsExpression ex = (CsAsIsExpression)pStatement;
			
			return new Expression(
				FactoryExpressionCreator.Parse(ex.expression).Value 
				+ " "
				+ As3Helpers.ConvertTokens(Helpers.GetTokenType(ex.oper)) + " " + As3Helpers.Convert(Helpers.GetType(ex.type)),
				ex.entity_typeref
			);
		}
	}
}
