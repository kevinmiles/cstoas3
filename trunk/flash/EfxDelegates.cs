namespace flash {
	using events;

	public delegate void EventDelegate(Event eventObject);

	public delegate void ActivityEventDelegate(ActivityEvent eventObject);

	public delegate void AsyncErrorEventDelegate(AsyncErrorEvent eventObject);

	public delegate void ContextMenuEventDelegate(ContextMenuEvent menuSelectEvent);

	public delegate void DataEventDelegate(DataEvent eventObject);

	public delegate void ErrorEventDelegate(ErrorEvent eventObject);

	public delegate void FocusEventDelegate(FocusEvent eventObject);

	public delegate void FullScreenEventDelegate(FullScreenEvent eventObject);

	public delegate void HTTPStatusEventDelegate(HTTPStatusEvent eventObject);

	public delegate void IMEEventDelegate(IMEEvent eventObject);

	public delegate void IOErrorEventDelegate(IOErrorEvent eventObject);

	public delegate void KeyboardEventDelegate(KeyboardEvent eventObject);

	public delegate void MouseEventDelegate(MouseEvent eventObject);

	public delegate void NetStatusEventDelegate(NetStatusEvent eventObject);

	public delegate void ProgressEventDelegate(ProgressEvent eventObject);

	public delegate void SecurityErrorEventDelegate(SecurityErrorEvent eventObject);

	public delegate void StatusEventDelegate(StatusEvent eventObject);

	public delegate void SyncEventDelegate(SyncEvent eventObject);

	public delegate void TextEventDelegate(TextEvent eventObject);

	public delegate void TimerEventDelegate(TimerEvent eventObject);
}