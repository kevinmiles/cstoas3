namespace CsCompiler.CsParser {
	using System;
	using Metaspec;
	using Tools;

	public class TheEvent : BaseNode {
		private readonly CsEventDeclarator _declarator;

		public TheClass MyClass {
			get;
			protected set;
		}

		public TheEvent(CsEvent pCsEvent, TheClass pTheClass, FactoryExpressionCreator pCreator) {
			MyClass = pTheClass;

			if (pCsEvent.declarators.Count > 1) throw new Exception("No more than one event declaration per handler is supported");

			_declarator = pCsEvent.declarators.First.Value;

			Name = _declarator.identifier.identifier;//RealName = 
			//FullRealName = MyClass.FullRealName + "." + RealName;
			FullName = MyClass.FullName + "." + Name;
			Modifiers.AddRange(Helpers.GetModifiers(pCsEvent.modifiers));

			string eventName = Helpers.GetEventFromAttr(pCsEvent.attributes, pCreator);
			IsFlashEvent = !string.IsNullOrEmpty(eventName);

			Add = new TheMethod(_declarator.entity.add, pTheClass, pCreator, true, true);
			Remove = new TheMethod(_declarator.entity.remove, pTheClass, pCreator, true);
			EventName = Helpers.GetEventFromAttr(pCsEvent.attributes, pCreator);
		}

		public string EventName { get; private set; }

		public bool IsFlashEvent { get; private set; }
		public TheMethod Add { get; private set; }
		public TheMethod Remove { get; private set; }
	}
}
