namespace flash.utils {
	using events;

	public class Timer : EventDispatcher {
		/// <summary>
		/// Dispatched whenever a Timer object reaches an interval specified according to the delay property.
		/// </summary>
		[As3Event(TimerEvent.TIMER)]
		public event TimerEventDelegate timer;

		/// <summary>
		/// Dispatched whenever it has completed the number of requests set by <see cref="repeatCount"/>.
		/// </summary>
		[As3Event(TimerEvent.TIMER_COMPLETE)]
		public event TimerEventDelegate timerComplete;

		/// <summary>
		/// Stops the timer, if it is running, and sets the <see cref="currentCount"/> property back to 0, like the reset button of a stopwatch.
		/// </summary>
		public void reset() {}

		/// <summary>
		/// Starts the timer, if it is not already running.
		/// </summary>
		public void start() {}

		/// <summary>
		/// Stops the timer.
		/// </summary>
		public void stop() {}

		/// <summary>
		/// Constructs a new Timer object with the specified delay and <paramref name="repeatCount"/> states.
		/// </summary>
		public Timer(double delay, int repeatCount) {}

		/// <summary>
		/// Constructs a new Timer object with the specified delay and <see cref="repeatCount"/> states.
		/// </summary>
		public Timer(double delay) {}

		/// <summary>
		/// [read-only] The total number of times the timer has fired since it started at zero.
		/// </summary>
		public int currentCount {
			get;
			private set;
		}

		/// <summary>
		/// The delay, in milliseconds, between timer events.
		/// </summary>
		public double delay {
			get;
			set;
		}

		/// <summary>
		/// The total number of times the timer is set to run.
		/// </summary>
		public int repeatCount {
			get;
			set;
		}

		/// <summary>
		/// [read-only] The timer's current state; true if the timer is running, otherwise false.
		/// </summary>
		public bool running {
			get;
			private set;
		}
	}
}