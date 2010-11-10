#if NET_2_0

#endif


namespace System.Runtime.CompilerServices {
#if NET_2_0
	public static class RuntimeHelpers
#else
	[Serializable]
	public sealed class RuntimeHelpers
#endif
	{
#if NET_2_0
		public delegate void TryCode(Object userData);

		public delegate void CleanupCode(Object userData, bool exceptionThrown);
#else
		private RuntimeHelpers () {}
#endif

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) {
			
		}

		public static extern int OffsetToStringData {
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

#if NET_1_1
		public static int GetHashCode (object o) {
			return Object.InternalGetHashCode (o);
		}

		public static new bool Equals (object o1, object o2) {
			// LAMESPEC: According to MSDN, this is equivalent to 
			// Object::Equals (). But the MS version of Object::Equals()
			// includes the functionality of ValueType::Equals(), while
			// our version does not.
			if (o1 == o2)
				return true;
			if ((o1 == null) || (o2 == null))
				return false;
			if (o1 is ValueType)
				return ValueType.DefaultEquals (o1, o2);
			else
				return Object.Equals (o1, o2);
		}
#endif

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern object GetObjectValue(object obj);

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void RunClassConstructor(IntPtr type);

		public static void RunClassConstructor(RuntimeTypeHandle type) {
			
		}

#if NET_2_0
		public static void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, Object userData) {}

	
		public static void PrepareConstrainedRegions() {}
		
		public static void PrepareConstrainedRegionsNoOP() {}

		public static void ProbeForSufficientStack() {}

		public static void PrepareDelegate(Delegate d) {
			
		}

		//public static void PrepareMethod(RuntimeMethodHandle method) {}

		//public static void PrepareMethod(RuntimeMethodHandle method, RuntimeTypeHandle[] instantiation) {}

		//public static void RunModuleConstructor(ModuleHandle module) {
		
		//}

		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public static extern void RunModuleConstructor(IntPtr module);
#endif
	}
}