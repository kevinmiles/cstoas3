using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Runtime.Versioning {
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public sealed class TargetFrameworkAttribute : Attribute {
		public TargetFrameworkAttribute(string pFVersion) {
			
		}
		public string FrameworkDisplayName;
	}
}
