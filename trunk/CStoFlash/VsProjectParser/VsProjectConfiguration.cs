namespace CStoFlash.VsProjectParser {
	using System.Collections.Generic;

	public class VsProjectConfiguration {
		private readonly Dictionary<string, string> _properties = new Dictionary<string, string>();
		public string Condition { get; set; }

		public IDictionary<string, string> Properties {
			get { return _properties; }
		}
	}
}
