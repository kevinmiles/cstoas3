namespace CsCompiler.AS3Writer.Expressions {
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public class NewArrayExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//"new" non-array-type "[" expression-list "]" ( rank-specifiers )? ( array-initializer )?
			//"new" non-array-type? rank-specifiers array-initializer
			CsNewArrayExpression ex = (CsNewArrayExpression) pStatement;

			StringBuilder builder = new StringBuilder();
			
			if (ex.initializer != null) {
				//builder.AppendFormat("Vector.<{0}>([", Helpers.GetType(((CsEntityArraySpecifier)ex.entity_typeref.u).type));
				builder.AppendFormat("new <{0}>[", Helpers.GetType(((CsEntityArraySpecifier)ex.entity_typeref.u).type));
				List<string> initializers = new List<string>();

				foreach (CsNode node in ex.initializer.initializers) {
					Expression expression = FactoryExpressionCreator.Parse(node as CsExpression);
					initializers.Add(expression.Value);
				}

				if (initializers.Count != 0) {
					builder.Append(string.Join(", ", initializers.ToArray()));
				}

				builder.Append("]");

			} else if (ex.expressions != null && ex.expressions.list != null && ex.expressions.list.Count == 1) {
				builder.Append("new Array(");
				Expression expression = FactoryExpressionCreator.Parse(ex.expressions.list.First.Value);
				builder.Append(expression.Value);
				builder.Append(")");
			}

			return new Expression(builder.ToString(), pStatement.entity_typeref);
		}
	}
}
