namespace flash.display {
	using geom;

	using media;

	public class Sprite : DisplayObjectContainer {
		/// <summary>
		/// Specifies the button mode of this sprite.
		/// </summary>
		public bool buttonMode {
			get;
			set;
		}

		/// <summary>
		/// [read-only] Specifies the display object over which the sprite is being dragged, or on which the sprite was dropped.
		/// </summary>
		public readonly DisplayObject dropTarget;

		/// <summary>
		/// [read-only] Specifies the Graphics object that belongs to this sprite where vector drawing commands can occur.
		/// </summary>
		public readonly Graphics graphics;

		/// <summary>
		/// Designates another sprite to serve as the hit area for a sprite.
		/// </summary>
		public Sprite hitArea {
			get;
			set;
		}

		/// <summary>
		/// Controls sound within this sprite.
		/// </summary>
		public SoundTransform soundTransform {
			get;
			set;
		}

		/// <summary>
		/// A Boolean value that indicates whether the pointing hand (hand cursor) appears when the mouse rolls over a sprite in which the buttonMode property is set to true.
		/// </summary>
		public bool useHandCursor {
			get;
			set;
		}

		/// <summary>
		/// Lets the user drag the specified sprite.
		/// </summary>
		public void startDrag(bool lockCenter, Rectangle bounds) {
			return;
		}

		/// <summary>
		/// Lets the user drag the specified sprite.
		/// </summary>
		public void startDrag(bool lockCenter) {
			return;
		}

		/// <summary>
		/// Lets the user drag the specified sprite.
		/// </summary>
		public void startDrag() {
			return;
		}

		/// <summary>
		/// Ends the startDrag() method.
		/// </summary>
		public void stopDrag() {
			return;
		}
	}
}