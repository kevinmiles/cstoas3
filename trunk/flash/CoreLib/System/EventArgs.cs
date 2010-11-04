namespace System {
	public class EventArgs {
		//public object Target { get; private set; }
	}
}

namespace System {
	public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs;
	public delegate void EventHandler(object sender, EventArgs e);
}