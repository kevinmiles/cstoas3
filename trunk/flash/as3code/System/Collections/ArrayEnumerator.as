package System.Collections {
	import System.*;
	import System.Collections.*;

	public final class ArrayEnumerator implements IEnumerator {
		private  var _theArray:Array;
		private var _index:int;
		public function ArrayEnumerator(pArray:Array) {
			_theArray = pArray;
			Reset();
		}

		public function MoveNext():Boolean {
			++_index;
			return _index < _theArray.length;
		}

		public function Reset():void {
			_index = -1;
		}

		public function get_Current():* {
			return _theArray[_index];
		}
	}
}
