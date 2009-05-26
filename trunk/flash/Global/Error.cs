namespace flash.Global {
	public class Error {
		public int errorID;
		public string message;
		public string name;

		/// <summary>
		/// Creates a new Error object. If message is specified, its value is assigned to the object's Error.message property.
		/// </summary>
		/// <param name="pMessage">A string associated with the Error object; this parameter is optional</param>
		/// <param name="pId">A reference number to associate with the specific error message</param>
		public Error(string pMessage, int pId) {
			
		}
		/// <summary>
		/// Returns the call stack for an error as a string at the time of the error's construction (for the debugger version of Flash Player and the AIR Debug Launcher (ADL) only; returns null if not using the debugger version of Flash Player or the ADL.
		/// </summary>
		/// <returns>A string representation of the call stack.</returns>
		public string getStackTrace() {
			return "";
		}

		/// <summary>
		/// Returns the string "Error" by default or the value contained in the Error.message property, if defined.
		/// </summary>
		/// <returns>The error message.</returns>
		public string toString() {
			return "";
		}
	}
}
