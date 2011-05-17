package System {
	import System.*;

	/**
	 * @author Marcelo Volmaro
	 */
	public final class EventHandler implements IDisposable {
		private var _handlers:Vector.<Function>;
		/**
		 * Creates a new instance of an Event Handler
		 */
		public function EventHandler() {
			_handlers = new Vector.<Function>();
		}

		/**
		 * Adds a suscriber to the event handler
		 * @param pSuscriber The suscriber to be added-
		 * @param pArgs An optional Array of arguments.
		 */
		public function add(pSuscriber:Function):void {
			if (!_handlers) return;
			remove(pSuscriber);// Just in case...
			_handlers.push(pSuscriber);
		}

		/**
		 * Removes a suscriber from the event handler list
		 * @param pSuscriber The suscriber to remove,
		 */
		public function remove(pSuscriber:Function):void {
			if (!_handlers) return;

			var idx:int = _handlers.indexOf(pSuscriber);
			if (idx != -1) _handlers.splice(idx, 1);
		}

		/**
		 * Fires an event to all suscribers
		 * @param pArgs An optional Array of arguments.
		 */
		public function fire(...args):void{
			if (!_handlers) return;

			//create a copy, so if an event handler modifies the event list, that modification does not gets
			//propagated until next firing...
			var s:Vector.<Function> = _handlers.concat();

			var l:uint = s.length, i:uint = 0;
			while (i < l){
				s[i].apply(null, args);
				i++;
			}
		}

		public function Dispose():void {
			_handlers = null;
		}
	}
}
