namespace flash.ui {
	using System;

	using events;

	public class ContextMenuItem : EventDispatcher {
		/// <summary>
		/// Specifies the menu item caption (text) displayed in the context menu.
		/// </summary>
		public string caption {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether a separator bar should appear above the specified menu item.
		/// </summary>
		public bool separatorBefore {
			get;
			set;
		}

		/// <summary>
		/// Indicates whether the specified menu item is visible when the Flash Player context menu is displayed.
		/// </summary>
		public bool visible {
			get;
			set;
		}

		/// <summary>
		/// Dispatched when a user selects an item from a context menu.
		/// </summary>
		[As3Event("ContextMenuEvent.MENU_ITEM_SELECT")]
		public event Action<ContextMenuEvent> menuItemSelect;

		/// <summary>
		/// Creates a new ContextMenuItem object that can be added to the <see cref="ContextMenu"/>.customItems array.
		/// </summary>
		public ContextMenuItem(string caption, bool separatorBefore, bool enabled, bool visible) {}

		/// <summary>
		/// Creates a new ContextMenuItem object that can be added to the ContextMenu.customItems array.
		/// </summary>
		public ContextMenuItem(string caption, bool separatorBefore, bool enabled) {}

		/// <summary>
		/// Creates a new ContextMenuItem object that can be added to the <see cref="ContextMenu"/>.customItems array.
		/// </summary>
		public ContextMenuItem(string caption, bool separatorBefore) {}

		/// <summary>
		/// Creates a new ContextMenuItem object that can be added to the <see cref="ContextMenu"/>.customItems array.
		/// </summary>
		public ContextMenuItem(string caption) {}
	}
}