namespace CStoFlash.AS3Writer.Expressions {
	using System;
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public class NewObjectExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			//object-creation-expression: 
			//"new" type "(" ( argument_list )? ")" object-or-collection-initializer? 
			//"new" type object-or-collection-initializer

			//delegate-creation-expression: 
			//"new" delegate-type "(" expression ")"
			CsNewObjectExpression node = (CsNewObjectExpression)pStatement;

			StringBuilder sb = new StringBuilder();
			TheClass c = TheClassFactory.Get(pStatement.entity_typeref);

			sb.Append("(new ");
			bool addP = false;
			if (c == null) {
				sb.AppendFormat("{0}(",As3Helpers.Convert(Helpers.GetType(node.type)));
				addP = true;

			} else {
				TheConstructor constructor = c.GetConstructor(node);
				if (constructor == null) {
					//sb.AppendFormat("{0}())(", c.Name);	
					return new Expression(
						string.Format("new {0}()", c.Name),
						pStatement.entity_typeref
					);

				}

				sb.AppendFormat("{0}()).{1}(", c.Name, constructor.Name);
			}

			if (node.argument_list != null) {
				List<string> args = new List<string>();
				foreach (CsArgument argument in node.argument_list.list) {
					args.Add(FactoryExpressionCreator.Parse(argument.expression).Value);
				}

				sb.Append(String.Join(", ", args.ToArray()));
			}

			sb.Append(")");
			if (addP)
				sb.Append(")");

			return new Expression(
				sb.ToString(),
				pStatement.entity_typeref
			);
		}
	}
}
