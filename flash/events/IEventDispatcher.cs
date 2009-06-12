namespace flash.events {
	public delegate void EventHandler(Event handler);

	public interface IEventDispatcher {
		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="pType">The type of event.</param>
		/// <param name="pHandler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		void addEventListener(string type, EventHandler handler);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="pType">The type of event.</param>
		/// <param name="pHandler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="pUseCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If useCapture is set to true , the listener processes the event only during the capture phase and not in the target or bubbling phase. If useCapture is false , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with useCapture set to true , then again with useCapture set to false .</param>
		/// <param name="pPriority">The priority level of the event listener. Priorities are designated by a 32-bit integer. The higher the number, the higher the priority. All listeners with priority n are processed before listeners of priority n-1 . If two or more listeners share the same priority, they are processed in the order in which they were added. The default priority is 0.</param>
		/// <param name="pUseWeakReference">Determines whether the reference to the listener is strong or weak. A strong reference (the default) prevents your listener from being garbage-collected. A weak reference does not.</param>
		void addEventListener(string pType, EventHandler handler, bool pUseCapture, int pPriority, bool pUseWeakReference);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="pType">The type of event.</param>
		/// <param name="pHandler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="pUseCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If useCapture is set to true , the listener processes the event only during the capture phase and not in the target or bubbling phase. If useCapture is false , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with useCapture set to true , then again with useCapture set to false .</param>
		/// <param name="pPriority">The priority level of the event listener. Priorities are designated by a 32-bit integer. The higher the number, the higher the priority. All listeners with priority n are processed before listeners of priority n-1 . If two or more listeners share the same priority, they are processed in the order in which they were added. The default priority is 0.</param>
		void addEventListener(string pType, EventHandler handler, bool pUseCapture, int pPriority);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="pType">The type of event.</param>
		/// <param name="pHandler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="pUseCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If useCapture is set to true , the listener processes the event only during the capture phase and not in the target or bubbling phase. If useCapture is false , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with useCapture set to true , then again with useCapture set to false .</param>
		void addEventListener(string pType, EventHandler handler, bool pUseCapture);

		/// <summary>
		/// Dispatches an event into the event flow. The event target is the <see cref="EventDispatcher"/> object upon which dispatchEvent() is called. 
		/// </summary>
		/// <param name="pEvent">The event object dispatched into the event flow</param>
		/// <returns> value of true unless preventDefault() is called on the event, in which case it returns false .</returns>
		bool dispatchEvent(Event pEvent);

		/// <summary>
		/// Checks whether the <see cref="EventDispatcher"/> object has any listeners registered for a specific type of event. This allows you to determine where an <see cref="EventDispatcher"/> object has altered handling of an event type in the event flow hierarchy. To determine whether a specific event type will actually trigger an event listener, use <see cref="IEventDispatcher"/>.willTrigger().
		/// </summary>
		/// <param name="pType">The type of event</param>
		/// <returns>A value of true if a listener of the specified type is registered; false otherwise</returns>
		bool hasEventListener(string pType);

		/// <summary>
		/// Removes a listener from the <see cref="EventDispatcher"/> object. If there is no matching listener registered with the <see cref="EventDispatcher"/> object, a call to this method has no effect.
		/// </summary>
		/// <param name="pType">The type of event</param>
		/// <param name="pHandler">The listener object to remove</param>
		void removeEventListener(string pType, EventHandler handler);
		
		/// <summary>
		/// Removes a listener from the <see cref="EventDispatcher"/> object. If there is no matching listener registered with the <see cref="EventDispatcher"/> object, a call to this method has no effect.
		/// </summary>
		/// <param name="pType">The type of event</param>
		/// <param name="pHandler">The listener object to remove</param>
		/// <param name="pUseCapture">Specifies whether the listener was registered for the capture phase or the target and bubbling phases. If the listener was registered for both the capture phase and the target and bubbling phases, two calls to removeEventListener() are required to remove both: one call with useCapture set to true , and another call with useCapture set to false.</param>
		void removeEventListener(string pType, EventHandler handler, bool pUseCapture);

		/// <summary>
		/// Checks whether an event listener is registered with this <see cref="EventDispatcher"/> object or any of its ancestors for the specified event type. This method returns true if an event listener is triggered during any phase of the event flow when an event of the specified type is dispatched to this EventDispatcher object or any of its descendants. 
		/// </summary>
		/// <param name="pType">The type of event.</param>
		/// <returns>A value of true if a listener of the specified type will be triggered; false otherwise</returns>
		bool willTrigger(string pType);


	}
}
