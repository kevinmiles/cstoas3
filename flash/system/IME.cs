namespace flash.system {
	using events;

	public class IME : EventDispatcher {
		public static IMEConversionMode conversionMode;
		public static bool enabled;

		public static void compositionAbandoned(){}

		public static void compositionSelectionChanged(int start, int end){}

		public static void doConversion(){}

		public static void setCompositionString(string composition) {
			
		}

		[As3Event("IMEEvent.IME_COMPOSITION")]
		public event IMEEventDelegate imeComposition;
	}
}