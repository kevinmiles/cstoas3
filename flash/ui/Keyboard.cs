namespace flash.ui {
	public class Keyboard {
		public static readonly bool capsLock;
		public static readonly bool numLock;

		public static bool isAccessible() {
			return false;
		}
	}

	[As3Name("Keyboard")]
	public enum KeyboardKey {
		ALTERNATE,
		BACKQUOTE,
		BACKSLASH ,
		BACKSPACE ,
		CAPS_LOCK,
		COMMA ,
		COMMAND ,
		CONTROL ,
		DELETE,
		DOWN,
		END,
		ENTER,
		ESCAPE,
		F1,
		F2,
		F3,
		F4,
		F5,
		F6,
		F7,
		F8,F9,F10,F11,F12,F13,F14,F15,
		HOME,
		INSERT,
		LEFT,
		NUMPAD_0,
		NUMPAD_1,
		NUMPAD_2,
		NUMPAD_3,
		NUMPAD_4,
		NUMPAD_5,
		NUMPAD_6,
		NUMPAD_7,
		NUMPAD_8,
		NUMPAD_9,
		NUMPAD_ADD,
		NUMPAD_DECIMAL,
		NUMPAD_DIVIDE,
		NUMPAD_ENTER,
		NUMPAD_MULTIPLY,
		NUMPAD_SUBTRACT,
		PAGE_DOWN,
		PAGE_UP,
		RIGHT,
		SHIFT,
		SPACE,
		TAB,
		UP
	}
}
