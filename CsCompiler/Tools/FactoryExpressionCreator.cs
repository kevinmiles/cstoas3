namespace CsCompiler.Tools {
	using System;
	using System.Collections.Generic;
	using Metaspec;

	public static class FactoryExpressionCreator {
		static readonly Dictionary<Type, IExpressionParser> _parsers = new Dictionary<Type, IExpressionParser>();

		public static void AddParser(Type pType, IExpressionParser pParser) {
			_parsers.Add(pType, pParser);
		}

		public static Expression Parse(CsExpression pExpression) {
			if (pExpression != null) {
				Type type = pExpression.GetType();

				if (_parsers.ContainsKey(type)) {
					return _parsers[type].Parse(pExpression);
				}
			}

			throw new NotImplementedException();
		}

		public static Expression Parse(CsNode pNode) {
			if (pNode != null) {
				Type type = pNode.GetType();

				if (_parsers.ContainsKey(type)) {
					return _parsers[type].Parse(pNode as CsExpression);
				}
			}

			throw new NotImplementedException();
		}
	}
}
