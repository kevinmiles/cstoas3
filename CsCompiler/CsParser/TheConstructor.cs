﻿namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using Metaspec;
	using Tools;

	public class TheConstructor : BaseMethod {
		private readonly CsEntityClass _baseConstructor;
		private readonly CsConstructor _constructor;
		private readonly bool _noFormalParams;
		private FactoryExpressionCreator _creator;

		internal TheConstructor(CsConstructor pConstructor, TheClass pMyClass, FactoryExpressionCreator pCreator) {
			_constructor = pConstructor;
			_creator = pCreator;
			MyClass = pMyClass;
			Modifiers.AddRange(Helpers.GetModifiers(pConstructor.modifiers));
			Arguments = getArguments(pConstructor.parameters.parameters, pCreator);
			BaseArguments = Helpers.GetCallingArguments(pConstructor.argument_list, pCreator);

			Signature = getSignature(Arguments);
			CodeBlock = pConstructor.definition;
			HasBaseCall = pConstructor.basethis == CsTokenType.tkBASE;

			LinkedList<CsFormalParameter> csFormalParameters = pConstructor.parameters.parameters;
			_noFormalParams = csFormalParameters == null;
			_name = pConstructor.identifier.identifier;
			IsStaticConstructor = (pConstructor.modifiers.flags & (uint)CsModifierEnum.mSTATIC) != 0;

			if (pConstructor.basethis == CsTokenType.tkBASE || pConstructor.basethis == CsTokenType.tkTHIS) {
				_baseConstructor = pConstructor.basethis == CsTokenType.tkBASE
				                   	? (CsEntityClass)((CsEntityClass)pConstructor.entity.parent).base_type.u
				                   	: ((CsEntityClass)pConstructor.entity.parent);
			}
		}

		private string _lazyName;
		//const string NAME = @"$ctor";
		private readonly string _name;

		public override string Name {
			get {
				if (_lazyName == null) {
					_lazyName = _name;
					//(_noFormalParams || _isUnique) ? NAME : NAME + _index;

					if (MyClass.Base != null) {
						TheClass c = MyClass.Base;
						TheConstructor m = c.FindConstructor(Signature);
						if (m != null) {
							_lazyName = m.Name;
							OverridesBaseConstructor = true;
						}
					}
				}

				return _lazyName;
			}
		}

		public bool OverridesBaseConstructor {
			get; private set; }

		public List<Expression> BaseArguments { get; protected set; }

		public TheConstructor BaseConstructor {
			get {
				if (_baseConstructor == null) {
					return null;
				}

				TheClass baseClass = TheClassFactory.Get(_baseConstructor, _creator);

				return baseClass.GetConstructor(_constructor.invoked_method.decl as CsConstructor);
			}
		}

		public TheConstructor ParentConstructor {
			get {
				TheClass baseClass = TheClassFactory.Get(_constructor, _creator).Base;
				return baseClass == null ? null : baseClass.GetDefaultConstructor();
			}
		}

		public bool HasBaseCall { get; private set; }
		public bool IsDefaultConstructor { get { return _noFormalParams || _isUnique; } }
		public bool IsStaticConstructor { get; private set; }
	}
}
