namespace CStoFlash.AS3Writer {
	using System.Xml.Serialization;
	using Tools;

	[XmlRoot("Configuration")]
	public sealed class As3Configuration : Configuration<As3Configuration> {
		private string _swfmillPath;

		[XmlElement]
		public string SwfmillPath {
			get {
				return ParsePath(_swfmillPath);
			}
			set { _swfmillPath = value; }
		}

		private string _flexSdkPath;

		[XmlElement]
		public string FlexSdkPath {
			get {
				return ParsePath(_flexSdkPath);
			}
			set { _flexSdkPath = value; }
		}

		private string _outputPath;

		[XmlElement]
		public string OutputPath {
			get {
				return ParsePath(_outputPath);
			}
			set { _outputPath = value; }
		}

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
		public string Name { get; set; }

		private string _value;

		[XmlAttribute]
		public string Value {
			get {
				return As3Configuration.ParsePath(_value);
			}
			set { _value = value; }
		}
	}
}
