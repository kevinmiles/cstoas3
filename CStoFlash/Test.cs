namespace CStoFlash {
	using flash.events;
	using flash.Global;
	using flash.system;

	public class Test {
		static void test() {
			
			RegExp rx = new RegExp("", "");
			RegExpMatch m = rx.exec("");

			string val0 = m[0];

			IME.imeComposition += imeEvent;

		}

		private static void imeEvent(IMEEvent eventobject) {
			

		}
	}
}
