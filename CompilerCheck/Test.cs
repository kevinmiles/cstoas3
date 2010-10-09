namespace CStoFlash {
	using System;

	using CompilerCheck;

	using flash;
	using flash.display;
	using flash.events;
	using flash.Global;
	using flash.system;

	using Array = flash.Global.Array;

	[As3MainClass(640, 480, 30, 0xffffff)]
	public class Test : Sprite {
		#region Delegates
		public delegate void MyDelegate(Event pEventObject);
		#endregion

		public MyDelegate IMustCallThisFunction;
		private string _otro;

		public Test() {
			const string pepe = @"aa";

			RegExp rx = new RegExp("", "");

			RegExp rx2 = new RegExp("", ""), rx3 = new RegExp("", "");

			RegExpMatch m = rx.exec("");

			string val0 = m[0];

			IME a = new IME();
			a.imeComposition += imeEvent;

			Object o = new Object();
			o["test"] = 1;

			string[] c = new[] {"a", "b", "c"};
			c[1] = "a";

			string[] c1 = new string[5];

			Array d = new Array(32);
			d[5] = 1;
			d[32] = "";

			uint j = 2;

			Vector<string> b = new Vector<string>(5, true);
			Vector<string> f = new[] {@"uno", @"dos"};

			bool theBool = 1 == 2;

			Event e = new Event("type");

			Sarasa += @"hola";
			Sarasa = @"chau".Extension1(1);

			string bb = MyMethod("1", "2", "3");

			IMustCallThisFunction = test;
			IMustCallThisFunction(e);
		}

		public string Sarasa {
			get;
			private set;
		}

		public string Otro {
			get {
				return _otro;
			}

			set {
				if (value == "" || value == null) {
					value = "kaka";
				}

				if (value == "pepe") {
					return;
				}

				_otro = value;
			}
		}

		private static void Main() {}

		private void test(Event pPeventobject) {}

		public string MyMethod(params string[] pArguments) {
			string r = "";
			foreach (string s in pArguments) {
				r += s;
			}

			string[] f = new[] {@"uno", @"dos"};
			foreach (string s in f) {
				r += s;
			}

			Vector<string> f1 = new[] {@"uno", @"dos"};
			foreach (string s in f1) {
				r += s;
			}

			return r;
		}

		private void imeEvent(IMEEvent pEventobject) {}

		[As3Event("IMEEvent.IME_COMPOSITION")]
		public static event MyDelegate TestEvent;
	}
}