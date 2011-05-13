namespace System.Collections {
	using ComponentModel;

	[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
	public interface IComparer {
		int Compare(object x, object y);
	}
}