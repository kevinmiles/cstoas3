namespace flash.events {
	public class Event {
		public Event(string pType) {

		}

		public Event(string pType, bool pBubbles) {

		}

		public Event(string pType, bool pBubbles, bool pCancelable) {

		}

		/// <summary>
		/// Indicates whether an event is a bubbling event
		/// </summary>
		public readonly bool bubbles;

		/// <summary>
		/// Indicates whether the behavior associated with the event can be prevented.
		/// </summary>
		public readonly bool cancelable;

		/// <summary>
		/// The object that is actively processing the Event object with an event listener.
		/// </summary>
		public readonly object currentTarget;

		/// <summary>
		/// The current phase in the event flow
		/// </summary>
		public readonly EventPhase eventPhase;

		/// <summary>
		/// The event target.
		/// </summary>
		public readonly object target;

		/// <summary>
		/// The type of event.
		/// </summary>
		public readonly string type;

		/// <summary>
		/// Duplicates an instance of an Event subclass.
		/// </summary>
		/// <returns></returns>
		public Event clone() {
			return null;
		}

		/// <summary>
		/// A utility function for implementing the toString() method in custom ActionScript 3.0 Event classes.
		/// </summary>
		/// <param name="pClassName">The name of your custom Event class</param>
		/// <param name="pArguments">The properties of the Event class and the properties that you add in your custom Event class</param>
		/// <returns></returns>
		public string formatToString(string pClassName, params object[] pArguments) {
			return "";
		}

		/// <summary>
		/// Checks whether the <see cref="preventDefault"/>() method has been called on the event. If the <see cref="preventDefault"/>() method has been called, returns true ; otherwise, returns false .
		/// </summary>
		/// <returns>If <see cref="preventDefault"/>() has been called, returns true ; otherwise, returns false .</returns>
		public bool isDefaultPrevented() {
			return false;
		}

		/// <summary>
		/// Cancels an event's default behavior if that behavior can be canceled. 
		/// </summary>
		public void preventDefault() {
			
		}

		/// <summary>
		/// Prevents processing of any event listeners in the current node and any subsequent nodes in the event flow. This method takes effect immediately, and it affects event listeners in the current node. In contrast, the stopPropagation() method doesn't take effect until all the event listeners in the current node finish processing. 
		/// </summary>
		public void stopImmediatePropagation() {
			
		}

		/// <summary>
		/// Prevents processing of any event listeners in nodes subsequent to the current node in the event flow. This method does not affect any event listeners in the current node ( currentTarget ). In contrast, the stopImmediatePropagation() method prevents processing of event listeners in both the current node and subsequent nodes. Additional calls to this method have no effect. This method can be called in any phase of the event flow.
		/// </summary>
		public void stopPropagation() {
			
		}

		
	}
}
