namespace flash.net {
	[As3Name("ObjectEncoding")]
	public enum ObjectEncodingType {
		AMF0,
		AMF3,
		DEFAULT
	}

	public class ObjectEncoding {
		public IDynamicPropertyWriter dynamicPropertyWriter {
			get;
			set;
		}
	}
}
