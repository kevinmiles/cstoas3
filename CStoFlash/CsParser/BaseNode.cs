using System.Collections.Generic;

namespace CStoFlash.CsParser {
	using Interfaces;

	public class BaseNode : ICsNode {
		readonly List<string> _modifiers = new List<string>();
		public List<string> Modifiers {
			get { return _modifiers; }
		}

		/// <summary>
		/// The unique, renamed, argument based name
		/// </summary>
		public virtual string Name {
			get;
			internal set;
		}

		/// <summary>
		/// The name of the method as found in the source code
		/// </summary>
		public string RealName {
			get;
			internal set;
		}

		/// <summary>
		/// The full path to the method (namespace.namespace.class.method)
		/// </summary>
		public virtual string FullName {
			get;
			internal set;
		}

		public string FullRealName {
			get;
			internal set;
		}
	}
}
