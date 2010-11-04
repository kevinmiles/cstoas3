namespace CsCompiler.Tools {
	using Metaspec;

	public interface IExpressionParser {
		Expression Parse(CsExpression pStatement);
	}
}
