namespace System.Collections {
	public interface IEnumerator {
		object Current {
			get;
		}

		bool MoveNext();

		void Reset();
	}

	public interface IEnumerator<out T> : IEnumerator {//IDisposable, 
		new T Current {
			get;
		}
	}
}