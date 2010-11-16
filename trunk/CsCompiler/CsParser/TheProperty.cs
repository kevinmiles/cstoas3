namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using Interfaces;
	using Metaspec;

	public class TheProperty : BaseNode, ICsHasReturnType {
		public TheProperty(CsProperty pCsProperty, TheClass pTheClass) {
			MyClass = pTheClass;
			Modifiers.AddRange(Helpers.GetModifiers(pCsProperty.modifiers));
			Name = pCsProperty.identifier.identifier;
			FullName = MyClass.FullName + "." + Name;
			
			ReturnType = Helpers.GetType(pCsProperty.type);

			if (pCsProperty.getter != null)
				Getter = new Property(pCsProperty.getter, this);

			if (pCsProperty.setter != null)
				Setter = new Property(pCsProperty.setter, this);
		}

		public TheClass MyClass { get; private set; }

		public Property Getter { get; private set; }
		public Property Setter { get; private set; }

		public string ReturnType {
			get; private set; }

		public bool IsEmpty {
			get {
				return (Getter != null && Getter.CodeBlock == null) && (Setter != null && Setter.CodeBlock == null);
			}
		}
	}

	public class Property : BaseNode, ICsHasReturnType, ICsHasCodeBlock {
		internal Property(CsPropertyAccessor pGetter, TheProperty pTheProperty) {
			List<string> mods = Helpers.GetModifiers(pGetter.modifiers);
			Modifiers.AddRange(mods.Count == 0 ? pTheProperty.Modifiers : mods);
			Name = pGetter.entity.name;//RealName = 
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
