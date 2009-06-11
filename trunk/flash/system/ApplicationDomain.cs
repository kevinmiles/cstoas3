namespace flash.system {
	using utils;

	public class ApplicationDomain {
		public static readonly ApplicationDomain currentDomain;
		public static readonly uint MIN_DOMAIN_MEMORY_LENGTH;

		public ByteArray domainMemory;
		public readonly ApplicationDomain parentDomain;
		
		public ApplicationDomain(ApplicationDomain domain){}
		public ApplicationDomain(){}

		public object getDefinition(string name) {
			return null;
		}

		public bool hasDefinition(string name) {
			return false;
		}

	}
}
