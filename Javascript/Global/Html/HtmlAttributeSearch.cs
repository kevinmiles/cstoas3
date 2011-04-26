namespace Javascript.Global {
	using System;

	[Flags, AsIntegerAttribute]
	public enum HtmlAttributeSearch {
		/// <summary>
		/// Performs a property search that is not case-sensitive, and returns an interpolated value if the property is found.
		/// </summary>
		Default = 0,

		/// <summary>
		/// Performs a case-sensitive property search. To find a match, the uppercase and lowercase letters in sAttrName must exactly match those in the attribute name.
		/// </summary>
		CaseSensitive = 1,

		/// <summary>
		/// Returns attribute value as a String. This flag does not work for event properties.
		/// </summary>
		ReturnAsString = 2,

		/// <summary>
		/// Returns attribute value as a fully expanded URL. Only works for URL attributes.
		/// </summary>
		ExpandURL = 4

	}
}
