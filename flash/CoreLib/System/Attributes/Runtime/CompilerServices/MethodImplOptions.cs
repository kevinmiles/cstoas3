namespace System.Runtime.CompilerServices {
	using InteropServices;

	/// <summary>
	/// </summary>
	[Flags, ComVisible(true)]
	public enum MethodImplOptions {
		/// <summary>
		/// </summary>
		Unmanaged = 4,

		/// <summary>
		/// </summary>
		ForwardRef = 16,

		/// <summary>
		/// </summary>
		InternalCall = 4096,

		/// <summary>
		/// </summary>
		Synchronized = 32,

		/// <summary>
		/// </summary>
		NoInlining = 8,

		/// <summary>
		/// </summary>
		PreserveSig = 128,

		NoOptimization = 64
	}

	// MethodImplOptions
}


// System.Runtime.CompilerServices