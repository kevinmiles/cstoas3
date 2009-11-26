namespace System.Collections {
	public interface IEnumerator {
		object current {
			get;
		}

		bool moveNext();

		void reset();
	}
}