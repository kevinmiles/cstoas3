namespace Javascript.Global {
	public abstract class History {
		public long length {
			get;
			set;
		}
		public void go(long delta) {
		}
		public void back() {
		}
		public void forward() {
		}
		public void pushState(object data, string title, string url) {
		}
		public void replaceState(object data, string title, string url) {
		}
	}
}
