namespace CStoFlash {
	using System;

	using flash;
	using flash.display;
	using flash.events;
	using flash.Global;
	using flash.system;

	using Array = flash.Global.Array;

	public class Test : MovieClip {
		static void Main() {
			
		}

		[As3MainClass(640, 480, 30, 0xffffff)]
		public Test() {
			RegExp rx = new RegExp("", "");
			RegExpMatch m = rx.exec("");

			string val0 = m[0];

			IME a = new IME();
			a.imeComposition += imeEvent;

			Object o = new Object();
			o["test"] = 1;
			
			string[] c = new []{"a", "b", "c"};
			c[1] = "a";

			Array d = new Array(32);
			d[5] = 1;
			d[32] = "";

			uint j = 2;

			Vector<string> b = (Vector<string>) d;

			Event e = new Event("type");

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
