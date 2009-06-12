namespace flash.display {
	using events;

	public class NativeMenu : EventDispatcher {
		public NativeMenuItem[] items;
		public readonly int numItems;
		public readonly NativeMenu parent;

		public NativeMenuItem addItem(NativeMenuItem item) {
			return item;
		}

		public NativeMenuItem addItemAt(NativeMenuItem item, int index) {
			return item;
		}

		public NativeMenuItem addSubmenu(NativeMenu submenu, string label) {
			return null;
		}

		public NativeMenuItem addSubmenuAt(NativeMenu submenu, int index, string label) {
			return null;
		}

		public NativeMenu clone() {
			return this;
		}

		public bool containsItem(NativeMenuItem item) {
			return false;
		}

		public void display(Stage stage, float stageX, float stageY) {
			
		}

		public NativeMenuItem  getItemAt(int index) {
			return null;
		}

		public NativeMenuItem getItemByName(string name) {
			return null;
		}

		public int getItemIndex(NativeMenuItem item) {
			return 0;
		}

		public void removeAllItems(){}

		public NativeMenuItem removeItem(NativeMenuItem item) {
			return item;
		}

		public NativeMenuItem removeItemAt(int index) {
			return null;
		}

		public void setItemIndex(NativeMenuItem item, int index){}
	}
}
