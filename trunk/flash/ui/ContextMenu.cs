namespace flash.ui {
	using System;

	using display;

	using events;

	public class ContextMenu : EventDispatcher {
		#region Properties
		/// <summary>
		/// An object that has the following properties of the <see cref="ContextMenuBuiltInItems"/> class: forwardAndBack, loop, play, print, quality, rewind, save, and zoom.
		/// </summary>
		public ContextMenuBuiltInItems builtInItems {
			get;
			set;
		}

		/// <summary>
		/// An array of <see cref="ContextMenuItem"/> objects.
		/// </summary>
		public ContextMenuItem[] customItems {
			get;
			set;
		}
		#endregion

		/// <summary>
		/// Pops up this menu at the specified location.
		/// </summary>
		public void display(Stage stage, double stageX, double stageY) {}

		/// <summary>
		/// Hides all built-in menu items (except Settings) in the specified <see cref="ContextMenu"/> object.
		/// </summary>
		public void hideBuiltInItems() {}

		/// <summary>
		/// Dispatched when a user first generates a context menu but before the contents of the context menu are displayed.
		/// </summary>
		[As3Event(ContextMenuEvent.MENU_SELECT)]
		public event ContextMenuEventDelegate menuSelect;

		
	}
}