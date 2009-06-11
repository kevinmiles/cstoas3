namespace flash.events {
	using System;

	public class EventDispatcher : IEventDispatcher {
		/// <summary>
		/// Aggregates an instance of the EventDispatcher class
		/// </summary>
		public EventDispatcher() {
		}

		/// <summary>
		/// Aggregates an instance of the EventDispatcher class
		/// </summary>
		/// <param name="pTarget">The target object for events dispatched to the EventDispatcher object. This parameter is used when the EventDispatcher instance is aggregated by a class that implements IEventDispatcher; it is necessary so that the containing object can be the target for events. Do not use this parameter in simple cases in which a class extends EventDispatcher.</param>
		public EventDispatcher(IEventDispatcher pTarget) {
			
		}

		public void addEventListener(string pType, EventHandler pHandler) {
			throw new NotImplementedException();
		}

		public void addEventListener(string pType, EventHandler pHandler, bool pUseCapture, int pPriority, bool pUseWeakReference) {
			throw new NotImplementedException();
		}

		public void addEventListener(string pType, EventHandler pHandler, bool pUseCapture, int pPriority) {
			throw new NotImplementedException();
		}

		public void addEventListener(string pType, EventHandler pHandler, bool pUseCapture) {
			throw new NotImplementedException();
		}

		public bool dispatchEvent(Event pEvent) {
			throw new NotImplementedException();
		}

		public bool hasEventListener(string pType) {
			throw new NotImplementedException();
		}

		public void removeEventListener(string pType, EventHandler pHandler) {
			throw new NotImplementedException();
		}

		public void removeEventListener(string pType, EventHandler pHandler, bool pUseCapture) {
			throw new NotImplementedException();
		}

		public bool willTrigger(string pType) {
			throw new NotImplementedException();
		}
	}
}
