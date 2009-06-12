namespace flash.events {
	public class EventDispatcher : IEventDispatcher {
		/// <summary>
		/// Aggregates an instance of the EventDispatcher class
		/// </summary>
		public EventDispatcher() {
		}

		/// <summary>
		/// Aggregates an instance of the EventDispatcher class
		/// </summary>
		/// <param name="pTarget">The target object for events dispatched to the EventDispatcher object. This parameter is used when the EventDispatcher instance is aggregated by a class that implements <see cref="IEventDispatcher"/>; it is necessary so that the containing object can be the target for events. Do not use this parameter in simple cases in which a class extends EventDispatcher.</param>
		public EventDispatcher(IEventDispatcher target) {
			
		}

		public void addEventListener(string type, EventHandler handler) {
			
		}

		public void addEventListener(string type, EventHandler handler, bool useCapture, int priority, bool useWeakReference) {
			
		}

		public void addEventListener(string type, EventHandler handler, bool useCapture, int priority) {
			
		}

		public void addEventListener(string type, EventHandler handler, bool useCapture) {
			
		}

		public bool dispatchEvent(Event pEvent) {
			return false;
		}

		public bool hasEventListener(string type) {
			return false;
		}

		public void removeEventListener(string type, EventHandler handler) {
			
		}

		public void removeEventListener(string type, EventHandler handler, bool useCapture) {
			
		}

		public bool willTrigger(string type) {
			return false;
		}
	}
}
