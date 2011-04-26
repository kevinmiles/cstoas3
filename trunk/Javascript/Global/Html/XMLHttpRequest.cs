namespace Javascript.Global {
	using System;

	public class XMLHttpRequest {
		public void open(string method, string address, bool async) {
		}
		public void send(string body) {
		}
		public string responseText {
			get;
			private set;
		}

		public Action onreadystatechange {
			get;
			set;
		}
		public int readyState {
			get;
			private set;
		}
		public int status {
			get;
			private set;
		}
		public string statusText {
			get;
			private set;
		}
		public void setRequestHeader(string name, string value) {
		}

	}
}
