namespace CStoFlash.CsParser {
	using System.Collections.Generic;
	using Interfaces;
	using Metaspec;

	public class TheProperty : BaseNode, ICsHasReturnType {
		public TheProperty(CsProperty pCsProperty, TheClass pTheClass) {
			MyClass = pTheClass;
			Modifiers.AddRange(Helpers.GetModifiers(pCsProperty.modifiers));
			Name = Helpers.GetRealName(pCsProperty, pCsProperty.identifier.identifier);
			RealName = pCsProperty.identifier.identifier;
			
			ReturnType = Helpers.GetType(pCsProperty.type);

			Getter = new Property(pCsProperty.getter, this);
			Setter = new Property(pCsProperty.setter, this);
		}

		public TheClass MyClass { get; private set; }

		public Property Getter { get; private set; }
		public Property Setter { get; private set; }

		public string ReturnType {
			get; private set; }

		public bool IsEmpty {
			get { return Getter.CodeBlock == null && Setter.CodeBlock == null; }
		}
	}

	public class Property : BaseNode, ICsHasReturnType, ICsHasCodeBlock {
		internal Property(CsPropertyAccessor pGetter, TheProperty pTheProperty) {
			List<string> mods = Helpers.GetModifiers(pGetter.modifiers);
			Modifiers.AddRange(mods.Count == 0 ? pTheProperty.Modifiers : mods);
			Name = RealName = pGetter.entity.name;
			ReturnType = pTheProperty.ReturnType;
			CodeBlock = pGetter.definition;
		}

		public string ReturnType {
			get;
			private set;
		}

		public CsBlock CodeBlock {
			get; private set; }
	}
}
