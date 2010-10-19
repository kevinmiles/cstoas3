namespace CStoFlash.AS3Writer {
	using System.Xml.Serialization;
	using Tools;

	[XmlRoot("Configuration")]
	public sealed class As3Configuration : Configuration<As3Configuration> {
		[XmlElement]
		public string SwfmillPath;

		[XmlElement]
		public string FlexSdkPath;

		[XmlElement]
		public string OutputPath;

		[XmlArray]
		[XmlArrayItem("Option")]
		public FlexOption[] FlexOptions;

		public static As3Configuration Instance {
			get {
				return load(@"flash\\As3Configuration.xml");
			}
		}
	}
	
	public sealed class FlexOption {
		[XmlAttribute]
		public string Name;

		[XmlAttribute]
		public string Value;
	}
}
