namespace CStoFlash.VsProjectParser {
	using System.Collections.Generic;

	/// <summary>
	/// 	Holds information about content items inside of a VisualStudio project.
	/// </summary>
	public class VsProjectItem {
		private readonly Dictionary<string, string> _itemProperties = new Dictionary<string, string>();
		private readonly VsItemType _itemType;

		public VsProjectItem(VsItemType pItemType) {
			_itemType = pItemType;
		}

		public string Item { get; set; }

		public VsItemType ItemType {
			get { return _itemType; }
		}

		public IDictionary<string, string> ItemProperties {
			get { return _itemProperties; }
		}
	}

	public enum VsItemType {
		Content,
		CompileItem,
		None,
		ProjectReference,
		Reference,
		EmbeddedResource
	}
}
