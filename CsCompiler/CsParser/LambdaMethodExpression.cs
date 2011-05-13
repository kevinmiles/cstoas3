namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using Metaspec;
	using Tools;

	public sealed class LambdaMethodExpression {
		public LambdaMethodExpression(CsLambdaExpression pStatement, FactoryExpressionCreator pCreator) {
			Arguments = BaseMethod.getArguments(pStatement.signature.parameters, pCreator);
			ReturnType = Helpers.GetType(pStatement.best_common_type);
			//ReturnType = Helpers.GetType(((CsEntityMethod)((CsEntityAnonymousMethod)pStatement.entity).parent.parent).specifier.return_type);
			CodeBlock = pStatement.body;
		}

		public List<TheMethodArgument> Arguments { get; private set; }

		public CsNode CodeBlock {
			get;
			private set;
		}

		public string ReturnType { get; private set; }
	}
}
