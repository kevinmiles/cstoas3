namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Property, Inherited = true), ComVisible(true)]
	public sealed class IndexerNameAttribute : Attribute {
		public IndexerNameAttribute(string indexerName) {}
	}
}