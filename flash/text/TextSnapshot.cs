namespace flash.text {
	public class TextSnapshot {
		public readonly int charCount;

		public int findText(int beginIndex, string textToFind, bool caseSensitive) {
			return 0;
		}

		public bool getSelected(int beginIndex, int endIndex) {
			return false;
		}

		public string getSelectedText(bool includeLineEndings) {return "";}
		public string getSelectedText() {return "";}

		public string getText(int beginIndex, int endIndex, bool includeLineEndings) {return "";}
		public string getText(int beginIndex, int endIndex) {return "";}

		public object [] getTextRunInfo(int beginIndex, int endIndex) {
			return null;
		}

		public float hitTestTextNearPos(float x, float y, float maxDistance) {return 0;}
		public float hitTestTextNearPos(float x, float y) {return 0;}

		public void setSelectColor(uint hexColor){}
		public void setSelectColor(){}

		public void setSelected(int beginIndex, int endIndex, bool select){}
	}
}
