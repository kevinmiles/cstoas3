namespace CStoFlash.AS3Writer.Expressions {
	using System.Collections.Generic;
	using System.Text;

	using Metaspec;

	using Utils;

	public class NewObjectExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//object-creation-expression: 
			//"new" type "(" ( argument_list )? ")" object-or-collection-initializer? 
			//"new" type object-or-collection-initializer

			//delegate-creation-expression: 
			//"new" delegate-type "(" expression ")"
			CsNewObjectExpression node = (CsNewObjectExpression)pStatement;

			StringBuilder sb = new StringBuilder();

			TheClass c = TheClass.Get(pStatement);

			sb.Append("new ");
			sb.Append(As3Helpers.Convert(ParserHelper.GetType(node.type)));
			sb.Append("(");

			if (node.argument_list != null) {
				foreach (CsArgument argument in node.argument_list.list) {
					Expression ex = FactoryExpressionCreator.Parse(argument.expression);
					sb.Append(ex.Value);
					sb.Append(", ");
				}

				sb.Remove(sb.Length - 2, 2);
			}

			sb.Append(")");	

			return new Expression(
				sb.ToString(),
				pStatement.entity_typeref
			);
		}
	}
}
