namespace CompilerCheck {
	public class MethodOverloadingTest {
		public void Test() {
			Method("a","b");
			Method("a",5);
		}

		public virtual void Method(string a, string b) {
			
		}

		public virtual void Method(string a, int b) {

		}
	}

	public class MethodOverloadingOverridingTest : MethodOverloadingTest {
		public override void Method(string a, int b) {
			base.Method(a, b);
		}

		public override void Method(string a, string b) {
			base.Method(a, b);
		}
	}
}
