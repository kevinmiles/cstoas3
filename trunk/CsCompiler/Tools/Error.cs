namespace CsCompiler.Tools {
	using System;

	[Serializable]
	public sealed class Error {
		public string AdditionalInfo { get; set; }
		public string File { get; set; }
		public string Message { get; set; }
		public int Line { get; set; }
		public int Column { get; set; }
		public ErrorType ErrorType { get; set; }
	}

	public enum ErrorType {
		Message,
		Warning,
		Error
	}
}
