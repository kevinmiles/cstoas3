namespace flash.display {
	using utils;

	public class Shader {
		/// <summary>
		/// Creates a new Shader instance.
		/// </summary>
		/// <param name="pByteCode">The raw shader bytecode to link to the Shader.</param>
		public Shader(ByteArray pByteCode) {
			
		}

		/// <summary>
		/// The raw shader bytecode for this Shader instance.
		/// </summary>
		public ByteArray byteCode {
			set {
				
			}
		}

		/// <summary>
		/// Provides access to parameters, input images, and metadata for the Shader instance.
		/// </summary>
		public ShaderData data;

		public ShaderPrecision precisionHint;
	}
}
