namespace System {
	using Javascript.Global;

	public class Exception : Error {
		public Exception(string pMessage): base(pMessage) {}
		public Exception() {}
	}
}