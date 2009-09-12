namespace CStoFlash {
	using flash;
	using flash.display;
	using flash.events;
	using flash.Global;
	using flash.system;

	public class Test : MovieClip {
		[As3MainClass(640, 480, 30, 0xffffff)]
		public Test() {
			RegExp rx = new RegExp("", "");
			RegExpMatch m = rx.exec("");

			string val0 = m[0];

			IME a = new IME();
			a.imeComposition += imeEvent;

			string[] c = new []{"a", "b", "c"};
			Array d = new string[32];
			d[5] = 1;

			UInt32 j = 2;

			Vector<string> b = (Vector<string>) d;

			Event e = new Event("type");
			TestEvent.Invoke(e);

			Sarasa += "hola";
		}

		public string Sarasa {
			get;
			private set;
		}

		private void imeEvent(IMEEvent pEventobject) {
			

		}

		public delegate void MyDelegate(Event pEventObject);

		[As3Event("IMEEvent.IME_COMPOSITION")]
		public static event MyDelegate TestEvent;
	}
}
