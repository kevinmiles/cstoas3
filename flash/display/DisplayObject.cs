namespace flash.display {
	using System;

	using accessibility;

	using events;

	using filters;

	using geom;

	public abstract class DisplayObject : EventDispatcher, IBitmapDrawable {
		/// <summary>
		/// Dispatched when a display object is added to the display list.
		/// </summary>
		[As3Event("Event.ADDED")]
		public event EventDelegate added;

		/// <summary>
		/// Dispatched when a display object is added to the on stage display list, either directly or through the addition of a sub tree in which the display object is contained.
		/// </summary>
		[As3Event("Event.ADDED_TO_STAGE")]
		public event EventDelegate addedToStage;

		/// <summary>
		/// Dispatched when the playhead is entering a new frame.
		/// </summary>
		[As3Event("Event.ENTER_FRAME")]
		public event EventDelegate enterFrame;

		/// <summary>
		/// Dispatched when a display object is about to be removed from the display list.
		/// </summary>
		[As3Event("Event.REMOVED")]
		public event EventDelegate removed;

		/// <summary>
		/// Dispatched when a display object is about to be removed from the display list, either directly or through the removal of a sub tree in which the display object is contained.
		/// </summary>
		[As3Event("Event.REMOVED_FROM_STAGE")]
		public event EventDelegate removedFromStage;

		/// <summary>
		/// Dispatched when the display list is about to be updated and rendered.
		/// </summary>
		[As3Event("Event.RENDER")]
		public event EventDelegate render;

		public readonly LoaderInfo loaderInfo;
		public readonly float mouseX;
		public readonly float mouseY;
		public readonly DisplayObjectContainer parent;
		public readonly DisplayObject root;
		public readonly Stage stage;

		/// <summary>
		/// The current accessibility options for this display object.
		/// </summary>
		public AccessibilityProperties accessibilityProperties;

		/// <summary>
		/// Indicates the alpha transparency value of the object specified.
		/// </summary>
		public float alpha;

		/// <summary>
		/// A value from the <see cref="BlendMode"/> class that specifies which blend mode to use.
		/// </summary>
		public BlendMode blendMode;

		/// <summary>
		/// If set to true, Flash Player or Adobe AIR caches an internal bitmap representation of the display object.
		/// </summary>
		public bool cacheAsBitmap;

		public BitmapFilter[] filters;

		public float height;

		public DisplayObject mask;

		public string name;
		public object opaqueBackground;

		public float rotation;
		public float rotationX;
		public float rotationY;
		public float rotationZ;

		public Rectangle scale9Grid;
		public float scaleX;
		public float scaleY;
		public float scaleZ;

		public Rectangle scrollRect;
		public Transform transform;
		public bool visible;
		public float width;
		public float x;
		public float y;
		public float z;

		/// <summary>
		/// Sets a shader that is used for blending the foreground and background.
		/// </summary>
		public Shader blendShader {
			set {
				return;
			}
		}

		public Rectangle getBounds(DisplayObject targetCoordinateSpace) {
			return null;
		}

		public Rectangle getRect(DisplayObject targetCoordinateSpace) {
			return null;
		}

		public Point globalToLocal(Point point) {
			return point;
		}

		public Vector3D globalToLocal3D(Point point) {
			return null;
		}

		public bool hitTestObject(DisplayObject obj) {
			return false;
		}

		public bool hitTestPoint(float x, float y, bool shapeFlag) {
			return false;
		}

		public bool hitTestPoint(float x, float y) {
			return false;
		}

		public Point local3DToGlobal(Vector3D point3D) {
			return null;
		}

		public Point localToGlobal(Point point) {
			return point;
		}
	}
}