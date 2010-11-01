namespace System {
		public unsafe struct IntPtr  {
			private void* m_value;

			public static readonly IntPtr Zero;

			public IntPtr(int value) {
				m_value = (void*)value;
				return;
			}

			public IntPtr(long value) {
				m_value = (void*)value;
				return;
			}

			unsafe public IntPtr(void* value) {
				m_value = value;
				return;
			}

			public static int Size {
				get {
					return sizeof(void*);
				}
			}

			public int ToInt32() {
				return (int)m_value;
			}

			public long ToInt64() {
				// pointer to long conversion is done using conv.u8 by the compiler
				if (Size == 4)
					return (long)(int)m_value;
				else
					return (long)m_value;
			}

			unsafe public void* ToPointer() {
				return m_value;
			}

			public static explicit operator IntPtr(int value) {
				return new IntPtr(value);
			}

			public static explicit operator IntPtr(long value) {
				return new IntPtr(value);
			}

			unsafe public static explicit operator IntPtr(void* value) {
				return new IntPtr(value);
			}

			public static explicit operator int(IntPtr value) {
				return (int)value.m_value;
			}

			public static explicit operator long(IntPtr value) {
				return value.ToInt64();
			}

			unsafe public static explicit operator void*(IntPtr value) {
				return value.m_value;
			}

		} 

}