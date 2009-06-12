namespace flash.display {
	using events;

	using ui;

	public class NativeMenuItem : EventDispatcher {
		[As3Name("checked")]
		public bool isChecked;

		public object data;

		public bool enabled;
		public readonly bool isSeparator;
		public string keyEquivalent;
		public KeyboardKey[] keyEquivalentModifiers;

		public string label;
		public readonly NativeMenu menu;
		public int mnemonicIndex;
		public string name;
		public NativeMenu submenu;

		public NativeMenuItem(string label, bool isSeparator) {}
		public NativeMenuItem(string label) {}
		public NativeMenuItem() {}

		public NativeMenuItem clone() {
			return this;
		}
	}
}
