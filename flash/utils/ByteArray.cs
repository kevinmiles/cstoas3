namespace flash.utils {
	using System;

	using Global;

	using net;

	public class ByteArray : IDataInput, IDataOutput {
		/// <summary>
		/// Denotes the default object encoding for the <see cref="ByteArray"/> class to use for a new <see cref="ByteArray"/> instance.
		/// </summary>
		public static ObjectEncodingType defaultObjectEncoding;

		/// <summary>
		/// The length of the <see cref="ByteArray"/> object, in bytes.
		/// </summary>
		public uint length;

		/// <summary>
		/// Moves, or returns the current position, in bytes, of the file pointer into the <see cref="ByteArray"/> object.
		/// </summary>
		public uint position;


		/// <summary>
		/// Clears the contents of the byte array and resets the length and position properties to 0. Calling this method explicitly frees up the memory used by the ByteArray instance.
		/// </summary>
		public void clear() {
			return;
		}

		/// <summary>
		/// Compresses the byte array. The entire byte array is compressed. For content running in Adobe AIR, you can specify a compression algorithm by passing a value (defined in the CompressionAlgorithm class) as the algorithm parameter. Flash Player supports only the default algorithm, zlib.
		/// </summary>
		/// <param name="algorithm">The compression algorithm to use when compressing. Valid values are defined as constants in the <see cref="CompressionAlgorithm"/> class. The default is to use zlib format. This parameter is only recognized for content running in Adobe AIR. Flash Player supports only the default algorithm, zlib, and throws an exception if you attempt to pass a value for this parameter. Calling compress( <see cref="CompressionAlgorithm"/>.DEFLATE) has the same effect as calling the deflate() method.</param>
		public void compress(CompressionAlgorithm algorithm) {
			return;
		}

		/// <summary>
		/// Compresses the byte array. The entire byte array is compressed. For content running in Adobe AIR, you can specify a compression algorithm by passing a value (defined in the CompressionAlgorithm class) as the algorithm parameter. Flash Player supports only the default algorithm, zlib.
		/// </summary>
		public void compress() {
			return;
		}

		/// <summary>
		/// Compresses the byte array using the deflate compression algorithm. The entire byte array is compressed.
		/// </summary>
		public void deflate() {
			return;
		}

		/// <summary>
		/// Decompresses the byte array using the deflate compression algorithm. The byte array must have been compressed using the same algorithm.
		/// </summary>
		/// <exception cref="IOError">The data is not valid compressed data; it was not compressed with the same compression algorithm used to compress.</exception>
		public void inflate() {
			return;
		}

		/// <summary>
		/// Reads a Boolean value from the byte stream. A single byte is read, and true is returned if the byte is nonzero, false otherwise.
        /// </summary>
		/// <returns>Returns true if the byte is nonzero, false otherwise. </returns>
		/// <exception cref="EOFError"></exception>
		public bool readBoolean() {
			return false;
		}

		/// <summary>
		/// Reads a signed byte from the byte stream. The returned value is in the range -128 to 127.
        /// </summary>
		/// <returns>An integer between -128 and 127.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public int readByte() {
			return 0;
		}

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the byte stream. The bytes are read into the <see cref="ByteArray"/> object specified by the bytes parameter, and the bytes are written into the destination ByteArray starting at the position specified by offset .
		/// </summary>
		/// <param name="pByteArray">The <see cref="ByteArray"/> object to read data into.</param>
		/// <param name="pOffset">The offset (position) in bytes at which the read data should be written. </param>
		/// <param name="pLength">The number of bytes to read. The default value of 0 causes all available data to be read.</param>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public void readBytes(ByteArray pByteArray, uint pOffset, uint pLength) {
			return;
		}

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the byte stream. The bytes are read into the <see cref="ByteArray"/> object specified by the bytes parameter, and the bytes are written into the destination ByteArray starting at the position specified by offset .
		/// </summary>
		/// <param name="pByteArray">The <see cref="ByteArray"/> object to read data into.</param>
		/// <param name="pOffset">The offset (position) in bytes at which the read data should be written. </param>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public void readBytes(ByteArray pByteArray, uint pOffset) {
			return;
		}

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the byte stream. The bytes are read into the <see cref="ByteArray"/> object specified by the bytes parameter, and the bytes are written into the destination ByteArray starting at the position specified by offset .
		/// </summary>
		/// <param name="pByteArray">The <see cref="ByteArray"/> object to read data into.</param>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public void readBytes(ByteArray pByteArray) {
			return;
		}

		/// <summary>
		/// Reads an IEEE 754 double-precision (64-bit) floating-point number from the byte stream.
		/// </summary>
		/// <returns>A double-precision (64-bit) floating-point number.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public double readDouble() {
			return 0.0;
		}

		/// <summary>
		/// Reads an IEEE 754 single-precision (32-bit) floating-point number from the byte stream.
		/// </summary>
		/// <returns>A single-precision (32-bit) floating-point number.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public float readFloat() {
			return (float) 0;
		}

		/// <summary>
		/// Reads a signed 32-bit integer from the byte stream. The returned value is in the range -2147483648 to 2147483647.
		/// </summary>
		/// <returns>A 32-bit signed integer between -2147483648 and 2147483647.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public int readInt() {
			return 0;
		}

		/// <summary>
		/// Reads a multibyte string of specified length from the byte stream using the specified character set.
		/// </summary>
		/// <param name="pLength">The number of bytes from the byte stream to read.</param>
		/// <param name="pCharset">The string denoting the character set to use to interpret the bytes. Possible character set strings include <c>shift-jis</c> , <c>cn-gb</c> , <c>iso-8859-1</c> , and others.</param>
		/// <returns>UTF-8 encoded string.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public string readMultiByte(uint pLength, string pCharset) {
			return "";
		}

		/// <summary>
		/// Reads an object from the byte array, encoded in AMF serialized format.
		/// </summary>
		/// <returns>The deserialized object.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public object readObject() {
			return null;
		}

		/// <summary>
		/// Reads a signed 16-bit integer from the byte stream. The returned value is in the range -32768 to 32767.
		/// </summary>
		/// <returns>A 16-bit signed integer between -32768 and 32767.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public short readShort() {
			return 0;
		}

		/// <summary>
		/// Reads an unsigned 32-bit integer from the byte stream. The returned value is in the range 0 to 4294967295.
		/// </summary>
		/// <returns>A 32-bit unsigned integer between 0 and 4294967295.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public uint readUnsignedInt() {
			return 0;
		}

		/// <summary>
		/// Reads a UTF-8 string from the byte stream. The string is assumed to be prefixed with an unsigned short indicating the length in bytes.
		/// </summary>
		/// <returns>UTF-8 encoded string.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public string readUTF() {
			return "";
		}

		/// <summary>
		/// Reads a sequence of UTF-8 bytes specified by the length parameter from the byte stream and returns a string.
		/// </summary>
		/// <param name="pLength">An unsigned short indicating the length of the UTF-8 bytes.</param>
		/// <returns>A string composed of the UTF-8 bytes of the specified length.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		public string readUTFBytes(uint pLength) {
			return pLength.toString();
		}

		/// <summary>
		/// Converts the byte array to a string. If the data in the array begins with a Unicode byte order mark, the application will honor that mark when converting to a string. If System.useCodePage is set to true , the application will treat the data in the array as being in the current system code page when converting.
		/// </summary>
		/// <returns></returns>
		new public string toString() {
			return "";
		}

		/// <summary>
		/// Decompresses the byte array. For content running in Adobe AIR, you can specify a compression algorithm by passing a value (defined in the CompressionAlgorithm class) as the algorithm parameter. The byte array must have been compressed using the same algorithm. Flash Player supports only the default algorithm, <c>zlib</c>.
		/// </summary>
		/// <param name="algorithm">The compression algorithm to use when decompressing. This must be the same compression algorithm used to compress the data. Valid values are defined as constants in the CompressionAlgorithm class. The default is to use zlib format. This parameter is only recognized for content running in Adobe AIR. Flash Player supports only the default algorithm, zlib, and throws an exception if you attempt to pass a value for this parameter.</param>
		/// <exception cref="IOError">The data is not valid compressed data; it was not compressed with the same compression algorithm used to compress.</exception>
		public void uncompress(CompressionAlgorithm algorithm) {
			return;
		}

		/// <summary>
		/// Decompresses the byte array. For content running in Adobe AIR, you can specify a compression algorithm by passing a value (defined in the CompressionAlgorithm class) as the algorithm parameter. The byte array must have been compressed using the same algorithm. Flash Player supports only the default algorithm, <c>zlib</c>.
		/// </summary>
		/// <exception cref="IOError">The data is not valid compressed data; it was not compressed with the same compression algorithm used to compress.</exception>
		public void uncompress() {
			return;
		}

		/// <summary>
		/// Writes a Boolean value. A single byte is written according to the value parameter, either 1 if true or 0 if false .
		/// </summary>
		/// <param name="boolean">A Boolean value determining which byte is written. If the parameter is true , the method writes a 1; if false , the method writes a 0.</param>
		public void writeBoolean(bool boolean) {
			return;
		}

		/// <summary>
		/// Writes an IEEE 754 double-precision (64-bit) floating-point number to the byte stream.
		/// </summary>
		/// <param name="pDouble">A double-precision (64-bit) floating-point number.</param>
		public void writeDouble(double pDouble) {
			return;
		}

		/// <summary>
		/// Writes an IEEE 754 single-precision (32-bit) floating-point number to the byte stream.
		/// </summary>
		/// <param name="pFloat">A single-precision (32-bit) floating-point number.</param>
		public void writeFloat(float pFloat) {
			return;
		}

		/// <summary>
		/// Writes a 32-bit signed integer to the byte stream.
		/// </summary>
		/// <param name="pInt">An integer to write to the byte stream.</param>
		public void writeInt(int pInt) {
			return;
		}

		/// <summary>
		/// Writes a multibyte string to the byte stream using the specified character set.
		/// </summary>
		/// <param name="pString">The string value to be written.</param>
		/// <param name="pCharset">The string denoting the character set to use. Possible character set strings include "shift-jis" , "cn-gb" , "iso-8859-1" , and others.</param>
		public void writeMultiByte(string pString, string pCharset) {
			return;
		}

		/// <summary>
		/// Writes an object into the byte array in AMF serialized format.
		/// </summary>
		/// <param name="pObject">The object to serialize</param>
		public void writeObject(object pObject) {
			return;
		}

		/// <summary>
		/// Writes a 16-bit integer to the byte stream. The low 16 bits of the parameter are used. The high 16 bits are ignored.
		/// </summary>
		/// <param name="pShort">32-bit integer, whose low 16 bits are written to the byte stream.</param>
		public void writeShort(short pShort) {
			return;
		}

		/// <summary>
		/// Writes a 32-bit unsigned integer to the byte stream.
		/// </summary>
		/// <param name="pUint">An unsigned integer to write to the byte stream.</param>
		public void writeUnsignedInt(uint pUint) {
			return;
		}

		/// <summary>
		/// Writes a UTF-8 string to the byte stream. The length of the UTF-8 string in bytes is written first, as a 16-bit integer, followed by the bytes representing the characters of the string.
		/// </summary>
		/// <param name="pString">The string value to be written.</param>
		/// <exception cref="RangeError">If the length is larger than 65535.</exception>
		public void writeUTF(string pString) {
			return;
		}

		/// <summary>
		/// Writes a UTF-8 string to the byte stream. Similar to the <see cref="writeUTF"/>() method, but writeUTFBytes() does not prefix the string with a 16-bit length word.
		/// </summary>
		/// <param name="pString">The string value to be written.</param>
		public void writeUTFBytes(string pString) {
			return;
		}

		public Byte this[uint i] {
			get {
				return new Byte();
			}

			set {
				return;
			}
		}

		#region IDataInput Members
		/// <summary>
		/// The number of bytes of data available for reading from the current position in the byte array to the end of the array.
		/// </summary>
		uint IDataInput.bytesAvailable {
			get {
				return new uint();
			}
		}

		/// <summary>
		/// Changes or reads the byte order for the data; either <see cref="Endian"/>.BIG_ENDIAN or <see cref="Endian"/>.LITTLE_ENDIAN.
		/// </summary>
		Endian IDataInput.endian {
			get {
				return new Endian();
			}
			set {
				return;
			}
		}

		/// <summary>
		/// Used to determine whether the ActionScript 3.0, ActionScript 2.0, or ActionScript 1.0 format should be used when writing to, or reading from, a <see cref="ByteArray"/> instance.
		/// </summary>
		ObjectEncodingType IDataInput.objectEncoding {
			get {
				return new ObjectEncodingType();
			}
			set {
				return;
			}
		}

		/// <summary>
		/// Reads an unsigned byte from the byte stream. The returned value is in the range 0 to 255.
		/// </summary>
		/// <returns>A 32-bit unsigned integer between 0 and 255.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		byte IDataInput.readUnsignedByte() {
			return 0;
		}

		/// <summary>
		/// Reads an unsigned 16-bit integer from the byte stream. The returned value is in the range 0 to 65535.
		/// </summary>
		/// <returns>A 16-bit unsigned integer between 0 and 65535.</returns>
		/// <exception cref="EOFError">There is not sufficient data available to read.</exception>
		ushort IDataInput.readUnsignedShort() {
			return 0;
		}

		#endregion

		#region IDataOutput Members

		/// <summary>
		/// Changes or reads the byte order for the data; either <see cref="Endian"/>.BIG_ENDIAN or <see cref="Endian"/>.LITTLE_ENDIAN.
		/// </summary>
		Endian IDataOutput.endian {
			get {
				return new Endian();
			}
			set {
				return;
			}
		}

		/// <summary>
		/// Used to determine whether the ActionScript 3.0, ActionScript 2.0, or ActionScript 1.0 format should be used when writing to, or reading from, a <see cref="ByteArray"/> instance.
		/// </summary>
		ObjectEncodingType IDataOutput.objectEncoding {
			get {
				return new ObjectEncodingType();
			}
			set {
				return;
			}
		}

		/// <summary>
		/// Writes a byte to the byte stream. The low 8 bits of the parameter are used. The high 24 bits are ignored.
		/// </summary>
		/// <param name="value">A 32-bit integer. The low 8 bits are written to the byte stream.</param>
		public void writeByte(byte value) {
			return;
		}

		/// <summary>
		/// <para>Writes a sequence of length bytes from the specified byte array, bytes , starting offset (zero-based index) bytes into the byte stream.</para>
		/// <para>If the length parameter is omitted, the default length of 0 is used; the method writes the entire buffer starting at offset . If the offset parameter is also omitted, the entire buffer is written. </para>
		/// <para>If offset or length is out of range, they are clamped to the beginning and end of the bytes array. </para>
		/// </summary>
		/// <param name="bytes">The <see cref="ByteArray"/> object.</param>
		/// <param name="offset">A zero-based index indicating the position into the array to begin writing.</param>
		/// <param name="length">An unsigned integer indicating how far into the buffer to write.</param>
		public void writeBytes(ByteArray bytes, uint offset, uint length) {
			return;
		}

		public void writeBytes(ByteArray bytes, uint offset) {
			return;
		}

		public void writeBytes(ByteArray bytes) {
			return;
		}

		#endregion
	}
}
