package System.Collections {
	import System.*;
	import System.Collections.*;

	public final class ObjectEnumerator implements IEnumerator {
		private var _keys:Array;
		private  var _object:Object;
		private var _index:int;

		public function ObjectEnumerator(pObject:Object) {
			_object = pObject;
			Reset();
		}

		public function MoveNext():Boolean {
			++_index;
			return _index < _keys.length;
		}

		public function Reset():void {
			var keys:Array = [];
			for (var s:String in _object){
				if (!_object.hasOwnProperty(s)) continue;
				keys.push(s);
			}

			_keys = keys;
			_index = -1;
		}

		public function get_Current():* {
			var k:String = _keys[_index];
			return (new KeyValuePair(k, _object[k]));
		}
	}
}
