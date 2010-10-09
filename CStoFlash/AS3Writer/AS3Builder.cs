namespace CStoFlash.AS3Writer {
	using Tools;

	public class As3Builder : CodeBuilder {
		public As3Builder(string pIndentString) : base(pIndentString) {}

		/// <summary>
		/// Begins the scope.
		/// </summary>
		/// <returns></returns>
		public As3Builder BeginScope() {
			AppendLine("{").Indent();
			return this;
		}
		/// <summary>
		/// Ends the scope.
		/// </summary>
		/// <returns></returns>
		public As3Builder EndScope() {
			Unindent().AppendLine("}");
			return this;
		}

		/// <summary>
		/// Begins the scope.
		/// </summary>
		/// <param name="pOpenClause">The opening clause.</param>
		/// <returns></returns>
		public As3Builder BeginScope(string pOpenClause) {
			Append(pOpenClause);
			return BeginScope();
		}

		/// <summary>
		/// Returns the accumulated code.
		/// </summary>
		/// <returns>The resulting string. Whitespace at the end of the
		/// accumulated code is trimmed.</returns>
		public override string ToString() {
			return base.ToString().TrimEnd();
		}
	}
}