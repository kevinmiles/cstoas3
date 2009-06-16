namespace CStoFlash.AS3Writer.Expressions {
	using Metaspec;

	using Utils;

	public class CastUnaryExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsCastUnaryExpression ex = (CsCastUnaryExpression)pStatement;

			return new Expression(
				As3Helpers.Convert(ParserHelper.GetType(ex.type)) + "(" + FactoryExpressionCreator.Parse(ex.unary_expression).Value + ")",
				ParserHelper.GetType(ex.type)
			);
		}
	}
}
