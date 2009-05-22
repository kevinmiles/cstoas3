namespace CStoFlash.Utils {
	public class AS3Builder : CodeBuilder {
		public AS3Builder(string pIndentString) : base(pIndentString) {}

		/// <summary>
		/// Begins the scope.
		/// </summary>
		/// <returns></returns>
		public AS3Builder BeginScope() {
			AppendLine("{").Indent();
			return this;
		}
		/// <summary>
		/// Ends the scope.
		/// </summary>
		/// <returns></returns>
		public AS3Builder EndScope() {
			Unindent().AppendLine("}");
			return this;
		}

		/// <summary>
		/// Begins the scope.
		/// </summary>
		/// <param name="pOpenClause">The opening clause.</param>
		/// <returns></returns>
		public AS3Builder BeginScope(string pOpenClause) {
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
