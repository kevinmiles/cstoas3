namespace CStoFlash.Utils {
	using System;
	using System.Text;

	/// <summary>
	/// Builds code in a specific language. This abstract class is the root. Wraps around the
	/// <c>builder</c> and provides useful features besides. Intended for sub classing.
	/// </summary>
	/// <remarks>
	/// Parts of this class were auto-generated automatically from <c>builder</c>.
	/// </remarks>
	public abstract class CodeBuilder {
		protected readonly StringBuilder _builder;
		protected int _indentLevel;
		protected string _indentString = string.Empty;

		protected CodeBuilder(string indentString) {
			_builder = new StringBuilder();
			_indentString = indentString;
		}

		protected string IndentString {
			get {
				StringBuilder sb = new StringBuilder();
				int n = _indentLevel;
				while (n -- > 0) {
					sb.Append(_indentString);
				}
				return sb.ToString();
			}
		}

		public int Capacity {
			get {
				return _builder.Capacity;
			}
			set {
				_builder.Capacity = value;
			}
		}

		public int Length {
			get {
				return _builder.Length;
			}
			set {
				_builder.Length = value;
			}
		}

		public int MaxCapacity {
			get {
				return _builder.MaxCapacity;
			}
		}

		public char this[int index] {
			get {
				return _builder[index];
			}
			set {
				_builder[index] = value;
			}
		}

		public CodeBuilder Indent() {
			++_indentLevel;
			return this;
		}

		public CodeBuilder Unindent() {
			--_indentLevel;
			return this;
		}

		public CodeBuilder Append(bool value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(byte value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(char value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(decimal value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(double value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(char[] value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(short value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(int value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(long value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(object value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(sbyte value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(float value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(string value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(ushort value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(uint value) {
			return AppendImpl(value);
		}

		public CodeBuilder Append(ulong value) {
			return AppendImpl(value);
		}

		protected CodeBuilder AppendIndent() {
			int level = _indentLevel;
			while (level-- > 0) {
				_builder.Append(_indentString);
			}
			return this;
		}

		protected CodeBuilder AppendImpl(object value) {
			AppendIndent();
			_builder.Append(value);
			return this;
		}

		public CodeBuilder Append(char value, int repeatCount) {
			AppendIndent();
			_builder.Append(value, repeatCount);
			return this;
		}

		public CodeBuilder Append(string value, int startIndex, int count) {
			AppendIndent();
			_builder.Append(value, startIndex, count);
			return this;
		}

		public CodeBuilder Append(char[] value, int startIndex, int charCount) {
			AppendIndent();
			_builder.Append(value, startIndex, charCount);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0) {
			AppendIndent();
			_builder.AppendFormat(format, arg0);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object[] args) {
			AppendIndent();
			_builder.AppendFormat(format, args);
			return this;
		}

		public CodeBuilder AppendFormat(IFormatProvider provider, string format, object[] args) {
			AppendIndent();
			_builder.AppendFormat(provider, format, args);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0, object arg1) {
			AppendIndent();
			_builder.AppendFormat(format, arg0, arg1);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2) {
			AppendIndent();
			_builder.AppendFormat(format, arg0, arg1, arg2);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2, object arg3) {
			AppendIndent();
			_builder.AppendFormat(format, arg0, arg1, arg2, arg3);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2, object arg3, object arg4) {
			AppendIndent();
			_builder.AppendFormat(format, arg0, arg1, arg2, arg3, arg4);
			return this;
		}

		public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
			AppendIndent();
			_builder.AppendFormat(format, arg0, arg1, arg2, arg3, arg4, arg5);
			return this;
		}

		public CodeBuilder AppendLineImpl() {
			AppendIndent();
			_builder.AppendLine();
			return this;
		}

		public CodeBuilder AppendLine() {
			return AppendLineImpl();
		}

		public CodeBuilder AppendLineAndIndent() {
			_builder.AppendLine();
			Indent();
			return this;
		}

		public CodeBuilder AppendLineAndIndent(string value) {
			_builder.AppendLine(value);
			Indent();
			return this;
		}

		public CodeBuilder AppendLineAndUnindent(string value) {
			Unindent();
			AppendIndent();
			_builder.AppendLine(value);
			return this;
		}

		public CodeBuilder AppendLine(string value) {
			Append(value);
			return AppendLineImpl();
		}

		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) {
			_builder.CopyTo(sourceIndex, destination, destinationIndex, count);
		}

		public int EnsureCapacity(int capacity) {
			return _builder.EnsureCapacity(capacity);
		}

		public bool Equals(CodeBuilder sb) {
			return _builder.Equals(sb);
		}

		public CodeBuilder Insert(int index, char[] value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, bool value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, byte value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, char value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, decimal value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, double value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, short value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, int value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, long value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, object value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, sbyte value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, float value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, string value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, ushort value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, uint value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, ulong value) {
			_builder.Insert(index, value);
			return this;
		}

		public CodeBuilder Insert(int index, string value, int count) {
			_builder.Insert(index, value, count);
			return this;
		}

		public CodeBuilder Insert(int index, char[] value, int startIndex, int charCount) {
			_builder.Insert(index, value, startIndex, charCount);
			return this;
		}

		public CodeBuilder Remove(int startIndex, int length) {
			_builder.Remove(startIndex, length);
			return this;
		}

		public CodeBuilder Replace(char oldChar, char newChar) {
			_builder.Replace(oldChar, newChar);
			return this;
		}

		public CodeBuilder Replace(string oldValue, string newValue) {
			_builder.Replace(oldValue, newValue);
			return this;
		}

		public CodeBuilder Replace(char oldChar, char newChar, int startIndex, int count) {
			_builder.Replace(oldChar, newChar, startIndex, count);
			return this;
		}

		public CodeBuilder Replace(string oldValue, string newValue, int startIndex, int count) {
			_builder.Replace(oldValue, newValue, startIndex, count);
			return this;
		}

		public override string ToString() {
			return _builder.ToString();
		}

		public string ToString(int startIndex, int length) {
			return _builder.ToString(startIndex, length);
		}
	}
}