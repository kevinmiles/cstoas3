﻿namespace flash.Global {
	public class Object {
		/// <summary>
		/// Indicates whether an object has a specified property defined.
		/// </summary>
		/// <param name="pName">The property of the object.</param>
		/// <returns>If the target object has the property specified by the name parameter this value is <c>true</c>, otherwise <c>false</c></returns>
		public bool HasOwnProperty(string pName) {
			return false;
		}

		/// <summary>
		/// Indicates whether an instance of the Object class is in the prototype chain of the object specified as the parameter.
		/// </summary>
		/// <param name="pTheClass">The class to which the specified object may refer.</param>
		/// <returns>If the object is in the prototype chain of the object specified by the theClass parameter this value is <c>true</c>, otherwise <c>false</c>.</returns>
		public bool IsPrototypeOf(object pTheClass) {
			return false;
		}

		/// <summary>
		/// Indicates whether the specified property exists and is enumerable.
		/// </summary>
		/// <param name="pName">The property of the object.</param>
		/// <returns>If the property specified by the name parameter is enumerable this value is <c>true</c>, otherwise <c>false</c>.</returns>
		public bool PropertyIsEnumerable(string pName) {
			return false;
		}

		/// <summary>
		/// Sets the availability of a dynamic property for loop operations. The property must exist on the target object because this method does not check the target object's prototype chain.
		/// </summary>
		/// <param name="pName">The property of the object.</param>
		/// <param name="pIsEnum">If set to <c>false</c>, the dynamic property does not show up in for..in loops, and the method <see cref="PropertyIsEnumerable"/>() returns <c>false</c></param>
		public void SetPropertyIsEnumerable(string pName, bool pIsEnum) {
			
		}

		/// <summary>
		/// Returns the string representation of the specified object.
		/// </summary>
		/// <returns></returns>
		public new string ToString() {
			return "";
		}

		/// <summary>
		/// Returns the primitive value of the specified object. If this object does not have a primitive value, the object itself is returned.
		/// </summary>
		/// <returns></returns>
		public object ValueOf() {
			return null;
		}

		public object this[string pName] {
			get {
				return null;
			}

			set {
				value = pName;
			}
		}
	}
}