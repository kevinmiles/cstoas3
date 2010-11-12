namespace System.Text {
	internal sealed class StringBuilder {
		public StringBuilder() {}
		public StringBuilder(int capacity) {}

		public StringBuilder(string value){}
		public StringBuilder(int capacity, int maxCapacity){}

		public StringBuilder Append(bool s) {return this;}
		public StringBuilder Append(byte s) {return this;}
		public StringBuilder Append(char s) {return this;}
		public StringBuilder Append(decimal s) {return this;}
		public StringBuilder Append(double s) {return this;}
		public StringBuilder Append(string s) {return this;}
		public StringBuilder Append(int s) {return this;}
		public StringBuilder Append(uint s) {return this;}
		public StringBuilder Append(float s) {return this;}
		public StringBuilder Append(object value) {return this;}
		public StringBuilder Append(char[] value) {return this;}
		
		[Obsolete]
		public override string ToString() {
			return "";
		}
	}
}
