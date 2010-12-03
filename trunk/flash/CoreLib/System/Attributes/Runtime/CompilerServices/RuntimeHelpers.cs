namespace System.Runtime.CompilerServices {
	public static class RuntimeHelpers {
		#region Delegates
		public delegate void CleanupCode(Object userData, bool exceptionThrown);

		public delegate void TryCode(Object userData);
		#endregion

		public static extern int OffsetToStringData {
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) {}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern object GetObjectValue(object obj);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void RunClassConstructor(IntPtr type);

		public static void RunClassConstructor(RuntimeTypeHandle type) {}

		public static void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, Object userData) {}

		public static void PrepareConstrainedRegions() {}

		public static void PrepareConstrainedRegionsNoOP() {}

		public static void ProbeForSufficientStack() {}

		public static void PrepareDelegate(Delegate d) {}

		//public static void PrepareMethod(RuntimeMethodHandle method) {}

		//public static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation) {}

		//public static void RunModuleConstructor(ModuleHandle module) {

		//}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void RunModuleConstructor(IntPtr module);
	}
}