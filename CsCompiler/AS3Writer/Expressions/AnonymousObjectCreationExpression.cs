namespace CsCompiler.AS3Writer.Expressions {
	using System.Text;
	using Metaspec;
	using Tools;

	public class AnonymousObjectCreationExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsAnonymousObjectCreationExpression ex = (CsAnonymousObjectCreationExpression)pStatement;
			StringBuilder builder = new StringBuilder("{");

			if (ex.member_declarator_list != null) {
				foreach (var declarator in ex.member_declarator_list) {
					builder.AppendFormat(@"""{0}"" = {1}, ",
						declarator.identifier.identifier,
						FactoryExpressionCreator.Parse(declarator.expression).Value
					);
				}

				builder.Remove(builder.Length - 2, 2);
			}

			builder.Append("}");
			return new Expression(builder.ToString(), ex.entity_typeref);
		}
	}
}
