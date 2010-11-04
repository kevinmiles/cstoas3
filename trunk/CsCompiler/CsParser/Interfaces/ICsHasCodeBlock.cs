namespace CsCompiler.CsParser.Interfaces {
	using Metaspec;

	internal interface ICsHasCodeBlock {
		CsBlock CodeBlock { get; }
	}
}
