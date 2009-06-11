using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flash.filters {
	public class BevelFilter : BitmapFilter{
		/// <summary>
		/// The angle of the bevel.
		/// </summary>
		public float angle;

		/// <summary>
		/// The amount of horizontal blur, in pixels.
		/// </summary>
		public float blurX;

		/// <summary>
		/// The amount of vertical blur, in pixels.
		/// </summary>
		public float blurY;

		/// <summary>
		/// The offset distance of the bevel.
		/// </summary>
		public float distance;

		/// <summary>
		/// The alpha transparency value of the highlight color.
		/// </summary>
		public float highlightAlpha;

		/// <summary>
		/// The highlight color of the bevel.
		/// </summary>
		public uint highlightColor;

		/// <summary>
		/// Applies a knockout effect (true), which effectively makes the object's fill transparent and reveals the background color of the document.
		/// </summary>
		public bool knockout;

		/// <summary>
		/// The number of times to apply the filter.
		/// </summary>
		public int quality;

		/// <summary>
		/// The alpha transparency value of the shadow color.
		/// </summary>
		public float shadowAlpha;

		/// <summary>
		/// The shadow color of the bevel.
		/// </summary>
		public uint shadowColor;

		/// <summary>
		/// The strength of the imprint or spread.
		/// </summary>
		public float strength;

		/// <summary>
		/// The placement of the bevel on the object.
		/// </summary>
		public BitmapFilterType type;

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX, float blurY, float strength, 
			float quality, BitmapFilterType type, bool knockout) {
			
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX, float blurY, float strength,
			float quality, BitmapFilterType type) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX, float blurY, float strength,
			float quality) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX, float blurY, float strength) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX, float blurY) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha, float blurX) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor, float shadowAlpha) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha,
			uint shadowColor) {
		}

		public BevelFilter(float distance, float angle, uint highlightColor, float highlightAlpha) {}
		public BevelFilter(float distance, float angle, uint highlightColor) {}
		public BevelFilter(float distance, float angle) {}
		public BevelFilter(float distance) {}
		public BevelFilter() {}
	}
}
