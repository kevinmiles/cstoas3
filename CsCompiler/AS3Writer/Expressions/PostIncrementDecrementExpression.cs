namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using Metaspec;
	using Tools;

	public class PostIncrementDecrementExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsPostIncrementDecrementExpression ex = (CsPostIncrementDecrementExpression)pStatement;

			Expression exp = FactoryExpressionCreator.Parse(ex.expression);
			if (exp.InternalType) {
				if (ex.expression is CsElementAccess) {
					string setter = ElementAccessHelper.parseElementAccess(ex.expression, true, true).Value;

					switch (ex.oper) {
						case CsTokenType.tkINC:
							return new Expression(string.Format(setter, exp.Value + "++"), exp.Type);

						case CsTokenType.tkDEC:
							return new Expression(string.Format(setter, exp.Value + "--"), exp.Type);

						default:
							throw new Exception();
					}

				}
			}

			switch (ex.oper) {
				case CsTokenType.tkINC:
					return new Expression(exp.Value + "++", exp.Type);

				case CsTokenType.tkDEC:
					return new Expression(exp.Value + "--", exp.Type);

				default:
					throw new NotImplementedException();
			}
		}
	}
}
