namespace CStoFlash.CsParser.Interfaces {
	using System.Collections.Generic;

	interface ICsNode {
		/// <summary>
		/// The name after any transformations have been applied
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The real name (the name found in the source code)
		/// </summary>
		string RealName { get; }

		/// <summary>
		/// The name after any transformations have been applied plus the NameSpace
		/// </summary>
		string FullName { get; }

		/// <summary>
		/// The real name plus the NameSpace
		/// </summary>
		string FullRealName { get; }

		/// <summary>
		/// Any modifiers applied to the node (public, private, static, etc)
		/// </summary>
		List<string> Modifiers { get; }
	}
}
