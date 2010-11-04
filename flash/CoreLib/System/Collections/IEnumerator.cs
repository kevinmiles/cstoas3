namespace System.Collections {
	public interface IEnumerator {
		object Current {
			get;
		}

		bool MoveNext();

		void Reset();
	}

	public interface IEnumerator<T> : IEnumerator {
		new T Current {
			get;
		}
	}
}