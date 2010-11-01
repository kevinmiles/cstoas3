namespace CStoFlash.AS3Writer {
	using System.Collections.Generic;
	using CsParser;
	using Tools;

	public static class EventParser {
		private static readonly Dictionary<string, string> _notValidClassMod =
			new Dictionary<string, string> {
				{ "static", null }
			};

		public static void Parse(TheEvent pEvent, As3Builder pBuilder) {
			if (pEvent.IsFlashEvent) return;

			ImportStatementList.AddImport(@"System.EventHandler");

			bool isStatic = pEvent.Modifiers.Contains("static");

			pBuilder.AppendFormat(@"private {1} var _e{0}:EventHandler;
		{2}{1} function get {0}():EventHandler {{
			if (_e{0} == null) _e{0} = new EventHandler();
			return _e{0};
		}}", 
				pEvent.Name, 
				isStatic ? "static" : string.Empty,
				As3Helpers.ConvertModifiers(pEvent.Modifiers, _notValidClassMod)
				//,isStatic ? pEvent.MyClass.Name : "this"
			);

			pBuilder.AppendLine();
		}
	}
}