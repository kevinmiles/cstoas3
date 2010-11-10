namespace System.Runtime.CompilerServices {
	using InteropServices;

	[AttributeUsage(AttributeTargets.Property, Inherited = true), ComVisible(true)]
#if NET_2_0
	
#endif
	public sealed class IndexerNameAttribute : Attribute {
		public IndexerNameAttribute(string indexerName) {}
	}
}