namespace CStoFlash {
	using System;

	using flash;
	using flash.display;
	using flash.events;
	using flash.Global;
	using flash.system;

	using Array = flash.Global.Array;

	public class Test : MovieClip {
		[As3MainClass(640, 480, 30, 0xffffff)]
		static void Main() {
			
		}

		
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

			Vector<string> b = new Vector<string>(5, true);
			Vector<string> f = (Vector<string>)new[]{"uno","dos"};

			bool theBool = 1 == 2;

			Event e = new Event("type");

			Sarasa += "hola";
		}

		public string Sarasa {
			get;
			private set;
		}

		private string _otro;
		public string Otro {
			get {
				return _otro;
			}

			set {
				if (value == "" || value == null)
					value = "kaka";

				if (value == "pepe") return;

				_otro = value;
			}
		}

		private void imeEvent(IMEEvent pEventobject) {

		}

		public delegate void MyDelegate(Event pEventObject);

		[As3Event("IMEEvent.IME_COMPOSITION")]
		public static event MyDelegate TestEvent;
	}
}
