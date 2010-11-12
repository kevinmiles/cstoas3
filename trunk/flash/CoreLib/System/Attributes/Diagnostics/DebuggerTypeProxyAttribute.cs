namespace System.Diagnostics {
	using Runtime.InteropServices;

	[AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Assembly,
		AllowMultiple = true), ComVisible(true)]
	
	public sealed class DebuggerTypeProxyAttribute : Attribute {
		private readonly string proxy_type_name;
		private Type target_type;
		private string target_type_name;

		public DebuggerTypeProxyAttribute(string typeName) {
			proxy_type_name = typeName;
		}

		public DebuggerTypeProxyAttribute(Type type) {
			
		}

		public string ProxyTypeName {
			get {
				return proxy_type_name;
			}
		}

		public Type Target {
			get {
				return target_type;
			}
			set {
				target_type = value;
			}
		}

		public string TargetTypeName {
			get {
				return target_type_name;
			}
			set {
				target_type_name = value;
			}
		}
	}
}