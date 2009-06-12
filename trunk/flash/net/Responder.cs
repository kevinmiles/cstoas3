namespace flash.net {
	public class Responder {
		public delegate void ResponderResultDelegate();
		public delegate void ResponderStatusDelegate(object status);

		/// <summary>
		/// Creates a new Responder object.
		/// </summary>
		public Responder(ResponderResultDelegate result, ResponderStatusDelegate status) {
		}

		/// <summary>
		/// Creates a new Responder object.
		/// </summary>
		public Responder(ResponderResultDelegate result) {
		}
	}
}