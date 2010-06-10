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

			string[]c1 = new string[5];

			Array d = new Array(32);
			d[5] = 1;
			d[32] = "";

			uint j = 2;

			Vector<string> b = new Vector<string>(5, true);
			Vector<string> f = new[]{"uno","dos"};

			bool theBool = 1 == 2;

			Event e = new Event("type");

			Sarasa += "hola";
			Sarasa = Extensions.Extension1("chau", 1);

			string bb = MyMethod("1", "2", "3");
		}

		public string MyMethod(params string[] arguments) {
			string r = "";
			foreach (string s in arguments) {
				r += s;
			}

			string[] f = new[] { "uno", "dos" };
			foreach (string s in f) {
				r += s;
			}

			Vector<string> f1 = new[]{"uno", "dos"};
			foreach (string s in f1) {
				r += s;
			}

			return r;
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

	public class OtraClase : BaseClase, IDisposable {
		public OtraClase() : base("hola") {
			
		}

		public void Dispose() {
			
		}
	}

	public class BaseClase {
		public BaseClase(string pValue) {
			Valor = pValue;
		}

		public string Valor {
			get;
			set;
		}
	}

	public static class Extensions {
		public static string Extension1(string pInValue, int pPosition) {
			return pInValue+pPosition;
		}
	}
}
