namespace CsCompiler.Tools {
	using System;
	using System.Collections.Generic;
	using Metaspec;

	public sealed class FactoryExpressionCreator {
		readonly Dictionary<Type, IExpressionParser> _parsers = new Dictionary<Type, IExpressionParser>();

		public void AddParser(Type pType, IExpressionParser pParser) {
			_parsers.Add(pType, pParser);
		}

		public Expression Parse(CsExpression pExpression) {
			if (pExpression != null) {
				Type type = pExpression.GetType();

				if (_parsers.ContainsKey(type)) {
					return _parsers[type].Parse(pExpression, this);
				}
			}

			throw new NotImplementedException();
		}

		public Expression Parse(CsNode pNode) {
			if (pNode != null) {
				Type type = pNode.GetType();

				if (_parsers.ContainsKey(type)) {
					return _parsers[type].Parse(pNode as CsExpression, this);
				}
			}

			throw new NotImplementedException();
		}
	}
}
