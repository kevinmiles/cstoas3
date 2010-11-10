namespace System.Runtime.CompilerServices {
	using InteropServices;

	/// <summary>
	/// </summary>
#if !NET_2_0
	[Flags]
#endif
#if NET_2_0
	[Flags, ComVisible(true)]
	
	
#endif
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

#if NET_2_0
		NoOptimization = 64
#endif
	}

	// MethodImplOptions
}


// System.Runtime.CompilerServices