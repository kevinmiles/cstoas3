﻿namespace flash.display {
	using geom;

	using text;

	public class DisplayObjectContainer : InteractiveObject
	{
		/// <summary>
		/// Determines whether or not the children of the object are mouse enabled.
		/// </summary>
		public bool mouseChildren { get; set; }

		/// <summary>
		/// [read-only] Returns the number of children of this object.
		/// </summary>
		public readonly int numChildren;

		/// <summary>
		/// Determines whether the children of the object are tab enabled.
		/// </summary>
		public bool tabChildren { get; set; }

		/// <summary>
		/// [read-only] Returns a <see cref="TextSnapshot"/> object for this <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public readonly TextSnapshot textSnapshot;

		/// <summary>
		/// Adds a child <see cref="DisplayObject"/> instance to this <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public DisplayObject addChild(DisplayObject child)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Adds a child <see cref="DisplayObject"/> instance to this <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public DisplayObject addChildAt(DisplayObject child, int index)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Indicates whether the security restrictions would cause any display objects to be omitted from the list returned by calling the DisplayObjectContainer.getObjectsUnderPoint() method with the specified point point.
		/// </summary>
		public bool areInaccessibleObjectsUnderPoint(Point point)
		{
			return default(bool);
		}

		/// <summary>
		/// Determines whether the specified display object is a child of the <see cref="DisplayObjectContainer"/> instance or the instance itself.
		/// </summary>
		public bool contains(DisplayObject child)
		{
			return default(bool);
		}

		/// <summary>
		/// Returns the child display object instance that exists at the specified index.
		/// </summary>
		public DisplayObject getChildAt(int index)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Returns the child display object that exists with the specified name.
		/// </summary>
		public DisplayObject getChildByName(string name)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Returns the index position of a child <see cref="DisplayObject"/> instance.
		/// </summary>
		public int getChildIndex(DisplayObject child)
		{
			return default(int);
		}

		/// <summary>
		/// Returns an array of objects that lie under the specified point and are children (or grandchildren, and so on) of this <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public object[] getObjectsUnderPoint(Point point)
		{
			return null;
		}

		/// <summary>
		/// Removes the specified child <see cref="DisplayObject"/> instance from the child list of the <see cref="DisplayObjectContainer"/> instance.
		/// </summary>
		public DisplayObject removeChild(DisplayObject child)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Removes a child <see cref="DisplayObject"/> from the specified index position in the child list of the <see cref="DisplayObjectContainer"/>.
		/// </summary>
		public DisplayObject removeChildAt(int index)
		{
			return default(DisplayObject);
		}

		/// <summary>
		/// Changes the position of an existing child in the display object container.
		/// </summary>
		public void setChildIndex(DisplayObject child, int index) {
			return;
		}

		/// <summary>
		/// Swaps the z-order (front-to-back order) of the two specified child objects.
		/// </summary>
		public void swapChildren(DisplayObject child1, DisplayObject child2) {
			return;
		}

		/// <summary>
		/// Swaps the z-order (front-to-back order) of the child objects at the two specified index positions in the child list.
		/// </summary>
		public void swapChildrenAt(int index1, int index2) {
			return;
		}

		/// <summary>
		/// Calling the new DisplayObjectContainer() constructor throws an ArgumentError exception.
		/// </summary>
		public DisplayObjectContainer() {
			return;
		}
	}
}