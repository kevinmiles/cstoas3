namespace System {
	using flash.Global;

	public class Exception : Error {
		public Exception(string pMessage, int pId): base(pMessage, pId) {}
		public Exception(string pMessage) : base(pMessage){}
		public Exception() {}
	}
}