package System.Collections {
	public interface IEnumerator {
		function get_Current():*;
		function MoveNext():Boolean;
		function Reset():void;
	}
}