namespace CompilerCheck {
	using System;

	public class ConstructorOverloadedTest {
		static ConstructorOverloadedTest() {

			new OtraClase();
			new OtraClase("a");
			new OtraClase("b", "c");

			new BaseClase("d");
			new BaseClase("d", "e", "f");
		}
	}

	public class BaseClase {
		public BaseClase(string pValue) {
			Valor = pValue;
		}

		public BaseClase(string a, string b, string c) {

		}

		protected BaseClase() {
			if (true) return;
		}

		public string Valor {
			get;
			set;
		}
	}

	public class OtraClase : BaseClase, IDisposable {
		public OtraClase()
			: base("hola") {
		}

		public OtraClase(string a)
			: this(a, "b" + "c") {

		}

		public OtraClase(string a, string b) {//has to call base() constructor...

		}

		public void Dispose() {

		}
	}
}
