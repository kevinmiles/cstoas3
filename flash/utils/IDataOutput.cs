﻿namespace flash.utils {
	using net;

	public interface IDataOutput {
		/// <summary>
		/// The byte order for the data, either the BIG_ENDIAN or LITTLE_ENDIAN constant from the Endian class.
		/// </summary>
		Endian endian {
			get;
			set;
		}

		/// <summary>
		/// Used to determine whether the AMF3 or AMF0 format is used when writing or reading binary data using the writeObject() method.
		/// </summary>
		ObjectEncodingType objectEncoding {
			get;
			set;
		}

		/// <summary>
		/// Writes a Boolean value.
		/// </summary>
		void writeBoolean(bool value);

		/// <summary>
		/// Writes a byte.
		/// </summary>
		void writeByte(byte value);

		/// <summary>
		/// Writes a sequence of bytes from the specified byte array, bytes, starting offset(zero-based index) bytes with a length specified by length, into the file stream, byte stream, or byte array.
		/// </summary>
		void writeBytes(ByteArray bytes, uint offset, uint length);

		/// <summary>
		/// Writes a sequence of bytes from the specified byte array, bytes, starting offset(zero-based index) bytes with a length specified by length, into the file stream, byte stream, or byte array.
		/// </summary>
		void writeBytes(ByteArray bytes, uint offset);

		/// <summary>
		/// Writes a sequence of bytes from the specified byte array, bytes, starting offset(zero-based index) bytes with a length specified by length, into the file stream, byte stream, or byte array.
		/// </summary>
		void writeBytes(ByteArray bytes);

		/// <summary>
		/// Writes an IEEE 754 double-precision (64-bit) floating point number.
		/// </summary>
		void writeDouble(double value);

		/// <summary>
		/// Writes an IEEE 754 single-precision (32-bit) floating point number.
		/// </summary>
		void writeFloat(float value);

		/// <summary>
		/// Writes a 32-bit signed integer.
		/// </summary>
		void writeInt(int value);

		/// <summary>
		/// Writes a multibyte string to the file stream, byte stream, or byte array, using the specified character set.
		/// </summary>
		void writeMultiByte(string value, string charSet);

		/// <summary>
		/// Writes an object to the file stream, byte stream, or byte array, in AMF serialized format.
		/// </summary>
		void writeObject(object objectData);

		/// <summary>
		/// Writes a 16-bit integer.
		/// </summary>
		void writeShort(short value);

		/// <summary>
		/// Writes a 32-bit unsigned integer.
		/// </summary>
		void writeUnsignedInt(uint value);

		/// <summary>
		/// Writes a UTF-8 string to the file stream, byte stream, or byte array.
		/// </summary>
		void writeUTF(string value);

		/// <summary>
		/// Writes a UTF-8 string.
		/// </summary>
		void writeUTFBytes(string value);
	}
}