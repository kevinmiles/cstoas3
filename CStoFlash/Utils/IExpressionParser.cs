namespace CStoFlash.Utils {
	using AS3Writer;

	using Metaspec;

	public interface IExpressionParser {
		Expression Parse(CsExpression pStatement);
	}
}
