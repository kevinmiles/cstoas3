namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using System.Collections.Generic;
	using System.Text;
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class NewObjectExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			//object-creation-expression: 
			//"new" type "(" ( argument_list )? ")" object-or-collection-initializer? 
			//"new" type object-or-collection-initializer

			//delegate-creation-expression: 
			//"new" delegate-type "(" expression ")"
			CsNewObjectExpression node = (CsNewObjectExpression)pStatement;

			StringBuilder sb = new StringBuilder();
			sb.Append("(new ");

			string name = As3Helpers.Convert(Helpers.GetType(node.type));
			bool isVector = name.StartsWith("Vector.<", StringComparison.Ordinal) && node.initializer != null;
			if (isVector) {
				int lb = name.IndexOf("<")+1;
				sb.AppendFormat("<{0}>[", name.Substring(lb, name.IndexOf(">") - lb));

				CsCollectionInitializer initializer = (CsCollectionInitializer)node.initializer;
				if (initializer.element_initializer_list != null) {
					List<string> args = new List<string>();
					foreach (var csNode in initializer.element_initializer_list) {
						args.Add(pCreator.Parse(csNode).Value);
					}
					sb.Append(String.Join(", ", args.ToArray()));
				}

			} else {
				sb.AppendFormat("{0}(", name);
				if (node.argument_list != null) {
					List<string> args = new List<string>();
					foreach (CsArgument argument in node.argument_list.list) {
						args.Add(pCreator.Parse(argument.expression).Value);
					}

					sb.Append(String.Join(", ", args.ToArray()));
				}
			}

			sb.Append(isVector ? "]" : ")");
			sb.Append(")");

			return new Expression(
				sb.ToString(),
				pStatement.entity_typeref
			);
		}
	}
}
