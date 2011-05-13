namespace CsCompiler.AS3Writer.Expressions {
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class LambdaExpression : IExpressionParser {
		#region IExpressionParser Members
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsLambdaExpression ex = (CsLambdaExpression)pStatement;

			LambdaMethodExpression lambda = new LambdaMethodExpression((CsLambdaExpression)pStatement, pCreator);

			CodeBuilder b = new CodeBuilder();
			b.AppendFormat("function ({0}):{1} {{",
			               As3Helpers.GetParameters(lambda.Arguments),
			               (lambda.ReturnType == null) ? "void" : As3Helpers.Convert(lambda.ReturnType)
				);

			b.Indent();
			b.Indent();
			b.Indent();
			b.AppendLine();

			if (!(lambda.CodeBlock is CsBlock)) {
				b.Append("return ");
			}

			BlockParser.ParseNode(lambda.CodeBlock, b, pCreator);

			b.AppendLine("}");
			b.AppendLine();
			b.Unindent();
			b.Unindent();
			b.Unindent();
			return new Expression(b.ToString(), ex.entity_typeref);
		}
		#endregion
	}
}
