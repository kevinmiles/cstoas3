namespace CStoFlash {
	using System;

	using flash.Global;
	using flash.net;
	using flash.utils;

	public class Test {
		static void test() {
			
			Vector<string> a = new Vector<string>();
			bool b = a.isFixed;
			a.map(callback);


			ByteArray byteArray = new ByteArray();
			uint c = byteArray.bytesAvailable;
			ByteArray.defaultObjectEncoding = ObjectEncodingType.AMF3;

			string t = Reflection.getQualifiedClassName(5);
			
			Class pp2 = Reflection.getDefinitionByName("asdas") as Class;

			ByteArray aa = Reflection.create(pp2, "as", 2, t) as ByteArray;

		}

		private static string callback(string pItem, int pIndex, Vector<string> pVector) {
			throw new NotImplementedException();
		}
	}
}
