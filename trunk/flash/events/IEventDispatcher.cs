namespace flash.events {
	using System;

	public interface IEventDispatcher {
		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="type">The type of event.</param>
		/// <param name="handler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		void addEventListener(string type, Action<Event> handler);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="type">The type of event.</param>
		/// <param name="handler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="useCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If <paramref name="useCapture"/> is set to <see langword="true"/> , the listener processes the event only during the capture phase and not in the target or bubbling phase. If <paramref name="useCapture"/> is <see langword="false"/> , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with <paramref name="useCapture"/> set to <see langword="true"/> , then again with <paramref name="useCapture"/> set to <see langword="false"/> .</param>
		/// <param name="priority">The priority level of the event listener. Priorities are designated by a 32-bit integer. The higher the number, the higher the priority. All listeners with priority n are processed before listeners of priority n-1 . If two or more listeners share the same priority, they are processed in the order in which they were added. The default priority is 0.</param>
		/// <param name="useWeakReference">Determines whether the reference to the listener is strong or weak. A strong reference (the default) prevents your listener from being garbage-collected. A weak reference does not.</param>
		void addEventListener(string type, Action<Event> handler, bool useCapture, int priority, bool useWeakReference);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="type">The type of event.</param>
		/// <param name="handler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="useCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If <paramref name="useCapture"/> is set to <see langword="true"/> , the listener processes the event only during the capture phase and not in the target or bubbling phase. If <paramref name="useCapture"/> is <see langword="false"/> , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with <paramref name="useCapture"/> set to <see langword="true"/> , then again with <paramref name="useCapture"/> set to <see langword="false"/> .</param>
		/// <param name="priority">The priority level of the event listener. Priorities are designated by a 32-bit integer. The higher the number, the higher the priority. All listeners with priority n are processed before listeners of priority n-1 . If two or more listeners share the same priority, they are processed in the order in which they were added. The default priority is 0.</param>
		void addEventListener(string type, Action<Event> handler, bool useCapture, int priority);

		/// <summary>
		/// Registers an event listener object with an <see cref="EventDispatcher"/> object so that the listener receives notification of an event.
		/// </summary>
		/// <param name="type">The type of event.</param>
		/// <param name="handler">The listener function that processes the event. This function must accept an event object as its only parameter and must return nothing.</param>
		/// <param name="useCapture">Determines whether the listener works in the capture phase or the target and bubbling phases. If <paramref name="useCapture"/> is set to <see langword="true"/> , the listener processes the event only during the capture phase and not in the target or bubbling phase. If <paramref name="useCapture"/> is <see langword="false"/> , the listener processes the event only during the target or bubbling phase. To listen for the event in all three phases, call addEventListener() twice, once with <paramref name="useCapture"/> set to <see langword="true"/> , then again with <paramref name="useCapture"/> set to <see langword="false"/> .</param>
		void addEventListener(string type, Action<Event> handler, bool useCapture);

		/// <summary>
		/// Dispatches an event into the event flow. The event target is the <see cref="EventDispatcher"/> object upon which dispatchEvent() is called.
		/// </summary>
		/// <param name="pEvent">The event object dispatched into the event flow</param>
		/// <returns> value of <see langword="true"/> unless preventDefault() is called on the event, in which case it returns <see langword="false"/> .</returns>
		bool dispatchEvent(Event pEvent);

		/// <summary>
		/// Checks whether the <see cref="EventDispatcher"/> object has any listeners registered for a specific type of event. This allows you to determine where an <see cref="EventDispatcher"/> object has altered handling of an event type in the event flow hierarchy. To determine whether a specific event type will actually trigger an event listener, use <see cref="IEventDispatcher"/>.<see cref="willTrigger"/>().
		/// </summary>
		/// <param name="type">The type of event</param>
		/// <returns>A value of <see langword="true"/> if a listener of the specified type is registered; <see langword="false"/> otherwise</returns>
		bool hasEventListener(string type);

		/// <summary>
		/// Removes a listener from the <see cref="EventDispatcher"/> object. If there is no matching listener registered with the <see cref="EventDispatcher"/> object, a call to this method has no effect.
		/// </summary>
		/// <param name="type">The type of event</param>
		/// <param name="handler">The listener object to remove</param>
		void removeEventListener(string type, Action<Event> handler);

		/// <summary>
		/// Removes a listener from the <see cref="EventDispatcher"/> object. If there is no matching listener registered with the <see cref="EventDispatcher"/> object, a call to this method has no effect.
		/// </summary>
		/// <param name="type">The type of event</param>
		/// <param name="handler">The listener object to remove</param>
		/// <param name="useCapture">Specifies whether the listener was registered for the capture phase or the target and bubbling phases. If the listener was registered for both the capture phase and the target and bubbling phases, two calls to removeEventListener() are required to remove both: one call with <paramref name="useCapture"/> set to <see langword="true"/> , and another call with <paramref name="useCapture"/> set to <see langword="false"/>.</param>
		void removeEventListener(string type, Action<Event> handler, bool useCapture);

		/// <summary>
		/// Checks whether an event listener is registered with this <see cref="EventDispatcher"/> object or any of its ancestors for the specified event type. This method returns <see langword="true"/> if an event listener is triggered during any phase of the event flow when an event of the specified type is dispatched to this <see cref="EventDispatcher"/> object or any of its descendants.
		/// </summary>
		/// <param name="type">The type of event.</param>
		/// <returns>A value of <see langword="true"/> if a listener of the specified type will be triggered; <see langword="false"/> otherwise</returns>
		bool willTrigger(string type);


	}
}
