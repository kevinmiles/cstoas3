namespace flash.events {
	using display;

	public class ContextMenuEvent : Event {
		/// <summary>
		/// Defines the value of the type property of a menuItemSelect event object.
		/// </summary>
		public const string MENU_ITEM_SELECT = "menuItemSelect";

		/// <summary>
		/// Defines the value of the type property of a menuSelect event object.
		/// </summary>
		public const string MENU_SELECT = "menuSelect";

		public ContextMenuEvent(string pType) : base(pType) {}

		public ContextMenuEvent(string pType, bool pBubbles) : base(pType, pBubbles) {}

		public ContextMenuEvent(string pType, bool pBubbles, bool pCancelable) : base(pType, pBubbles, pCancelable) {}

		/// <summary>
		/// The display list object to which the menu is attached.
		/// </summary>
		public InteractiveObject contextMenuOwner {
			get;
			set;
		}

		/// <summary>
		/// The display list object on which the user right-clicked to display the context menu.
		/// </summary>
		public InteractiveObject mouseTarget {
			get;
			set;
		}
	}
}