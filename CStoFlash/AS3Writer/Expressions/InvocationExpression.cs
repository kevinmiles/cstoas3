namespace CStoFlash.AS3Writer.Expressions {
	using System.Collections.Generic;

	using Metaspec;

	using Utils;

	public class InvocationExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsInvocationExpression ex = (CsInvocationExpression)pStatement;
			TheClass k = TheClass.Get(pStatement);

			List<string> indexes = new List<string>();

			foreach (CsArgument argument in ex.argument_list.list) {
				indexes.Add(FactoryExpressionCreator.Parse(argument.expression).Value);
			}

			string name = ParserHelper.GetRealName(ex, k == null ?
				FactoryExpressionCreator.Parse(ex.expression).Value :
				k.GetMethod((CsMethod)((CsEntityMethod)ex.entity).decl).Name);

			//patch
			if (name.Contains("{0}")) {
				string p = indexes[0];
				indexes.RemoveAt(0);
				name = string.Format(name, p, string.Join(", ", indexes.ToArray()));

			} else {
				name = name + "(" + string.Join(", ", indexes.ToArray()) + ")";
			}

			return new Expression(
				name,
				ex.entity_typeref
			);
		}
	}
}
