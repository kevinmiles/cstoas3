namespace CsCompiler.CsParser {
	using Interfaces;
	using Metaspec;

	public class TheMethod : BaseMethod, ICsMethod {
		private readonly string _name;

		internal TheMethod(CsEntityMethod pCsMethod, TheClass pMyClass, bool pIsEvent = false, bool pIsAddEvent = false) {
			MyClass = pMyClass;
			//Modifiers.AddRange(Helpers.GetModifiers(pCsMethod.access));
			Arguments = getArguments(pCsMethod.parameters);
			Signature = getSignature(Arguments);
			
			_name = Helpers.GetRealName(pCsMethod, pIsEvent ? 
				pIsAddEvent ? "add" : "remove" : 
				pCsMethod.name);
			
			RealName = pCsMethod.name;
			FullRealName = MyClass.FullRealName + "." + RealName;

			ReturnType = Helpers.GetType(pCsMethod.specifier.return_type);
			IsExtensionMethod = pCsMethod.isExtensionMethod();
		}

		public override string FullName {
			get {
				return MyClass.FullName + "." + Name;
			}

			internal set {
				base.FullName = value;
			}
		}

		private string _lazyName;
		public override string Name {
			get {
				if (_lazyName == null) {
					_lazyName = _isUnique ? _name : _name + _index;

					if (MyClass.Base != null) {
						TheClass c = MyClass.Base;
						TheMethod m = c.FindMethod(RealName, Signature);
						if (m != null)
							_lazyName = m.Name;		
					}
				}

				return _lazyName;
			}
		}

		internal TheMethod(CsMethod pCsMethod, TheClass pMyClass) {
			MyClass = pMyClass;
			Modifiers.AddRange(Helpers.GetModifiers(pCsMethod.modifiers));
			Arguments = getArguments(pCsMethod.parameters.parameters);
			Signature = getSignature(Arguments);
			CodeBlock = pCsMethod.definition;

			//_sig = Signature.Replace(',', '_').Replace("<", "").Replace(">", "");
			_name = Helpers.GetRealName(pCsMethod, pCsMethod.identifier.identifier);
			RealName = pCsMethod.identifier.identifier;
			FullRealName = MyClass.FullRealName + "." + RealName;

			ReturnType = Helpers.GetType(pCsMethod.return_type);
			IsExtensionMethod = pCsMethod.entity.isExtensionMethod();
		}

		public string ReturnType {get; private set;}
		public bool IsExtensionMethod {
			get; private set; }
	}
}
