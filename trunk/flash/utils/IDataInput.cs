namespace flash.utils {
	using net;

	public interface IDataInput {
		/// <summary>
		/// [read-only] Returns the number of bytes of data available for reading in the input buffer.
		/// </summary>
		uint bytesAvailable {
			get;
		}

		/// <summary>
		/// The byte order for the data, either the BIG_ENDIAN or LITTLE_ENDIAN constant from the Endian class.
		/// </summary>
		Endian endian {
			get;
			set;
		}

		/// <summary>
		/// Used to determine whether the AMF3 or AMF0 format is used when writing or reading binary data using the readObject() method.
		/// </summary>
		ObjectEncodingType objectEncoding {
			get;
			set;
		}

		/// <summary>
		/// Reads a Boolean value from the file stream, byte stream, or byte array.
		/// </summary>
		bool readBoolean();

		/// <summary>
		/// Reads a signed byte from the file stream, byte stream, or byte array.
		/// </summary>
		int readByte();

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the file stream, byte stream, or byte array.
		/// </summary>
		void readBytes(ByteArray bytes, uint offset, uint length);

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the file stream, byte stream, or byte array.
		/// </summary>
		void readBytes(ByteArray bytes, uint offset);

		/// <summary>
		/// Reads the number of data bytes, specified by the length parameter, from the file stream, byte stream, or byte array.
		/// </summary>
		void readBytes(ByteArray bytes);

		/// <summary>
		/// Reads an IEEE 754 double-precision floating point number from the file stream, byte stream, or byte array.
		/// </summary>
		double readDouble();

		/// <summary>
		/// Reads an IEEE 754 single-precision floating point number from the file stream, byte stream, or byte array.
		/// </summary>
		float readFloat();

		/// <summary>
		/// Reads a signed 32-bit integer from the file stream, byte stream, or byte array.
		/// </summary>
		int readInt();

		/// <summary>
		/// Reads a multibyte string of specified length from the file stream, byte stream, or byte array using the specified character set.
		/// </summary>
		string readMultiByte(uint length, string charSet);

		/// <summary>
		/// Reads an object from the file stream, byte stream, or byte array, encoded in AMF serialized format.
		/// </summary>
		object readObject();

		/// <summary>
		/// Reads a signed 16-bit integer from the file stream, byte stream, or byte array.
		/// </summary>
		short readShort();

		/// <summary>
		/// Reads an unsigned byte from the file stream, byte stream, or byte array.
		/// </summary>
		byte readUnsignedByte();

		/// <summary>
		/// Reads an unsigned 32-bit integer from the file stream, byte stream, or byte array.
		/// </summary>
		uint readUnsignedInt();

		/// <summary>
		/// Reads an unsigned 16-bit integer from the file stream, byte stream, or byte array.
		/// </summary>
		ushort readUnsignedShort();

		/// <summary>
		/// Reads a UTF-8 string from the file stream, byte stream, or byte array.
		/// </summary>
		string readUTF();

		/// <summary>
		/// Reads a sequence of UTF-8 bytes from the byte stream or byte array and returns a string.
		/// </summary>
		string readUTFBytes(uint length);
	}
}