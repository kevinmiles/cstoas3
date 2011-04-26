namespace Javascript.Global {
	using System;

	public sealed class Date {
		/// <summary>
		/// Constructs a new Date object that holds the specified date and time.
		/// </summary>
		public Date(int year, int month, int day, int hour = 0, int minute = 0, int second = 0,
					int millisecond = 0) {
		}

		///<summary>
		/// Constructs a new Date object.
		///</summary>
		///<param name="milliseconds">The number of milliseconds since midnight January 1, 1970, universal time.</param>
		public Date(long milliseconds) {
		}

		/// <summary>
		/// Constructs a new Date object.
		/// </summary>
		/// <param name="dateString">String value representing a date. The string should be in a format recognized by the parse method (IETF-compliant RFC 1123 timestamps).</param>
		public Date(string dateString) {
		}

		public Date() {
			return;
		}

		/// <summary>
		/// Parses a string representation of a date, and returns the number of milliseconds since January 1, 1970, 00:00:00 UTC.
		/// </summary>
		/// <param name="dateString">A string representing a date.</param>
		/// <returns></returns>
		public static int parse(string dateString) {
			return 0;
		}

		public static long operator -(Date date1, Date date2) {
			return default(long);
		}

		/// <summary>
		/// Returns the year value in the Date object using local time.
		/// </summary>
		/// <returns>the year as an absolute number. For example, the year 1976 is returned as 1976.</returns>
		public int getFullYear() {
			return default(int);
		}


		/// <summary>
		/// Returns the month value in the Date object using local time.
		/// </summary>
		/// <returns>integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00" is stored in a Date object, getMonth returns 0.</returns>
		public int getMonth() {
			return default(int);
		}

		/// <summary>
		/// Returns the day-of-the-month value in a Date object using local time.
		/// </summary>
		/// <returns>an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
		public int getDate() {
			return default(int);
		}

		/// <summary>
		/// Returns the hours value in a Date object using local time.
		/// </summary>
		/// <returns>an integer between 0 and 23, indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 am, or the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		public int getHours() {
			return default(int);
		}

		/// <summary>
		/// Returns the minutes value in a Date object using local time.
		/// </summary>
		/// <returns>integer between 0 and 59 equal to the minutes value stored in the Date object. A zero is returned in two situations: when the time is less than one minute after the hour, or when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		public int getMinutes() {
			return default(int);
		}

		/// <summary>
		/// Returns the seconds value in a Date object using local time.
		/// </summary>
		/// <returns>integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero is returned in two situations. One occurs when the time is less than one second into the current minute. The other occurs when the time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and minutes for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		public int getSeconds() {
			return default(int);
		}

		///<summary>
		///Returns the milliseconds value in a Date object using local time.
		///</summary>
		///<returns>The millisecond value returned can range from 0-999.</returns>
		public int getMilliseconds() {
			return default(int);
		}

		///<summary>
		///Sets the month value in the Date object using local time.
		///</summary>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		public void setMonth(int numMonth) {
		}

		///<summary>
		///Sets the month value in the Date object using local time.
		///</summary>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		///<param name="dateVal">A numeric value representing the day of the month. If this value is not supplied, the value from a call to the getDate method is used.</param>
		public void setMonth(int numMonth, int dateVal) {
		}

		///<summary>
		///Sets the hour value in the Date object using local time.
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		public void setHours(int numHours) {
		}

		///<summary>
		///Sets the hour value in the Date object using local time.
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value. </param>
		public void setHours(int numHours, int numMin) {
		}

		///<summary>
		///Sets the hour value in the Date object using local time.
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value. </param>
		///<param name="numSec">A numeric value equal to the seconds value. </param>
		public void setHours(int numHours, int numMin, int numSec) {
		}

		///<summary>
		///Sets the hour value in the Date object using local time.
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value. </param>
		///<param name="numSec">A numeric value equal to the seconds value. </param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setHours(int numHours, int numMin, int numSec, int numMilli) {
		}

		///<summary>
		///Sets the minutes value in the Date object using local time.
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		public void setMinutes(int numMinutes) {
		}

		///<summary>
		///Sets the minutes value in the Date object using local time.
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		///<param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
		public void setMinutes(int numMinutes, int numSeconds) {
		}

		///<summary>
		///Sets the minutes value in the Date object using local time.
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value. Must be supplied if either of the following arguments is used.</param>
		///<param name="numSeconds">A numeric value equal to the seconds value. Must be supplied if the numMilli argument is used.</param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setMinutes(int numMinutes, int numSeconds, int numMilli) {
		}

		///<summary>
		///Sets the seconds value in the Date object using local time.
		///</summary>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		public void setSeconds(int numSeconds) {
		}

		///<summary>
		///Sets the seconds value in the Date object using local time.
		///</summary>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setSeconds(int numSeconds, int numMilli) {
		}

		///<summary>
		///Sets the milliseconds value in the Date object using local time.
		///</summary>
		///<param name="value">A numeric value equal to the millisecond value.</param>
		public void setMilliseconds(int value) {
		}

		///<summary>
		///Sets the date and time value in the Date object.
		///</summary>
		///<param name="milliseconds">A numeric value representing the number of elapsed milliseconds since midnight, January 1, 1970 GMT.</param>
		public void setTime(int milliseconds) {
		}

		///<summary>
		///Sets the numeric day of the month in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numDate">A numeric value equal to the day of the month.</param>
		public void setUTCDate(int numDate) {
		}

		///<summary>
		///Sets the year value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		public void setUTCFullYear(int numYear) {
		}

		///<summary>
		///Sets the year value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		public void setUTCFullYear(int numYear, int numMonth) {
		}

		///<summary>
		///Sets the year value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		///<param name="numDate">A numeric value equal to the day of the month.</param>
		public void setUTCFullYear(int numYear, int numMonth, int numDate) {
		}

		///<summary>
		///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		public void setUTCHours(int numHours) {
		}

		///<summary>
		///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value.</param>
		public void setUTCHours(int numHours, int numMin) {
		}

		///<summary>
		///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value.</param>
		///<param name="numSec">A numeric value equal to the seconds value</param>
		public void setUTCHours(int numHours, int numMin, int numSec) {
		}

		///<summary>
		///Sets the hours value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numHours">A numeric value equal to the hours value.</param>
		///<param name="numMin">A numeric value equal to the minutes value.</param>
		///<param name="numSec">A numeric value equal to the seconds value</param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setUTCHours(int numHours, int numMin, int numSec, int numMilli) {
		}

		///<summary>
		///Sets the milliseconds value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMilli">A numeric value equal to the millisecond value.</param>
		public void setUTCMilliseconds(int numMilli) {
		}

		///<summary>
		///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value.</param>
		public void setUTCMinutes(int numMinutes) {
		}

		///<summary>
		///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value.</param>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		public void setUTCMinutes(int numMinutes, int numSeconds) {
		}

		///<summary>
		///Sets the minutes value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMinutes">A numeric value equal to the minutes value.</param>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setUTCMinutes(int numMinutes, int numSeconds, int numMilli) {
		}

		///<summary>
		///Sets the month value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		public void setUTCMonth(int numMonth) {
		}

		///<summary>
		///Sets the month value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively.</param>
		///<param name="dateVal">A numeric value representing the day of the month. If it is not supplied, the value from a call to the getUTCDate method is used.</param>
		public void setUTCMonth(int numMonth, int dateVal) {
		}

		///<summary>
		///Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		public void setUTCSeconds(int numSeconds) {
		}

		///<summary>
		///Sets the seconds value in the Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<param name="numSeconds">A numeric value equal to the seconds value.</param>
		///<param name="numMilli">A numeric value equal to the milliseconds value.</param>
		public void setUTCSeconds(int numSeconds, int numMilli) {
		}

		///<summary>
		///Sets the year value in the Date object.
		///</summary>
		///<param name="numYear">This method is obsolete, and is maintained for backwards compatibility only. Use the setFullYear method instead. For the years 1900 through 1999, this is a numeric value equal to the year minus 1900. For dates outside that range, this is a 4-digit numeric value.</param>
		[Obsolete]
		public void setYear(int numYear) {
		}

		///<summary>
		///Returns the number of milliseconds between midnight, January 1, 1970 Universal Coordinated Time (UTC) (or GMT) and the supplied date.
		///</summary>
		///<param name="year">The full year designation is required for cross-century date accuracy. If year is between 0 and 99 is used, then year is assumed to be 1900 + year.</param>
		///<param name="month">The month as an integer between 0 and 11 (January to December).</param>
		///<param name="day"> The date as an integer between 1 and 31.</param>
		///<param name="hours">An integer from 0 to 23 (midnight to 11pm) that specifies the hour.</param>
		///<param name="minutes"> An integer from 0 to 59 that specifies the minutes.</param>
		///<param name="seconds">An integer from 0 to 59 that specifies the seconds.</param>
		///<param name="ms">An integer from 0 to 999 that specifies the milliseconds.</param>
		///<returns>The number of milliseconds between midnight, January 1, 1970 UTC and the supplied date. This return value can be used in the setTime method and in the Date object constructor. If the value of an argument is greater than its range, or is a negative number, other stored values are modified accordingly. For example, if you specify 150 seconds, JScript redefines that number as two minutes and 30 seconds.</returns>
		public static string UTC(int year, int month, int day = 0, int hours = 0, int minutes = 0, int seconds = 0, int ms = 0) {
			return default(string);
		}

		///<summary>
		///Returns the time value in a Date object.
		///</summary>
		///<returns>
		///An integer value representing the number of milliseconds between midnight, January 1, 1970 and the time value in the Date object.
		///The range of dates is approximately 285,616 years from either side of midnight, January 1, 1970.
		///Negative numbers indicate dates prior to 1970. </returns>
		public int getTime() {
			return default(int);
		}

		///<summary>
		///Returns the day of the week value in a Date object using local time.
		///</summary>
		///<returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows:
		///0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
		public int getDay() {
			return default(int);
		}

		///<summary>
		///Returns the difference in minutes between the time on the host computer and Universal Coordinated Time (UTC).
		///</summary>
		///<returns>An integer value representing the number of minutes between the time on the current machine and UTC. These values are appropriate to the computer the script is executed on. If it is called from a server script, the return value is appropriate to the server. If it is called from a client script, the return value is appropriate to the client.</returns>
		public int getTimezoneOffset() {
			return default(int);
		}

		///<summary>
		///Returns the day-of-the-month value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>an integer between 1 and 31 that represents the day-of-the-month value in the Date object.</returns>
		public int getUTCDate() {
			return default(int);
		}

		///<summary>
		///Returns the day of the week value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>an integer between 0 and 6 representing the day of the week and corresponds to a day of the week as follows:
		///0 Sunday 1 Monday 2 Tuesday 3 Wednesday 4 Thursday 5 Friday 6 Saturday</returns>
		public int getUTCDay() {
			return default(int);
		}

		///<summary>
		///Returns the year value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>The year as an absolute number. This avoids the year 2000 problem where dates beginning with January 1, 2000 are confused with those beginning with January 1, 1900.</returns>
		public int getUTCFullYear() {
			return default(int);
		}

		///<summary>
		///Returns the hours value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>An integer between 0 and 23 indicating the number of hours since midnight. A zero occurs in two situations: the time is before 1:00:00 A.M., or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		public int getUTCHours() {
			return default(int);
		}

		///<summary>
		///Returns the milliseconds value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>The millisecond value returned can range from 0-999.</returns>
		public int getUTCMilliseconds() {
			return default(int);
		}

		///<summary>
		///Returns the minutes value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>An integer between 0 and 59 equal to the number of minutes value in the Date object. A zero occurs in two situations: the time is less than one minute after the hour, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the hours and seconds for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object.</returns>
		public int getUTCMinutes() {
			return default(int);
		}

		///<summary>
		///Returns the month value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>An integer between 0 and 11 indicating the month value in the Date object. The integer returned is not the traditional number used to indicate the month. It is one less. If "Jan 5, 1996 08:47:00.0" is stored in a Date object, getUTCMonth returns 0.</returns>
		public int getUTCMonth() {
			return default(int);
		}

		///<summary>
		///Returns the seconds value in a Date object using Universal Coordinated Time (UTC).
		///</summary>
		///<returns>An integer between 0 and 59 indicating the seconds value of the indicated Date object. A zero occurs in two situations: the time is less than one second into the current minute, or a time was not stored in the Date object when the object was created. The only way to determine which situation you have is to also check the minutes and hours for zero values. If they are all zeroes, it is nearly certain that the time was not stored in the Date object..</returns>
		public int getUTCSeconds() {
			return default(int);
		}

		///<summary>
		///Returns the year value in a Date object. This method is obsolete, and is provided for backwards compatibility only. Use the getFullYear method instead. For the years 1900 though 1999, the year is a 2-digit integer value returned as the difference between the stored year and 1900. For dates outside that period, the 4-digit year is returned. For example, 1996 is returned as 96, but 1825 and 2025 are returned as-is.
		///</summary>
		[Obsolete]
		public int getYear() {
			return default(int);
		}

		///<summary>
		///Sets the numeric day-of-the-month value of the Date object using local time.
		///</summary>
		///<param name="numDate">A numeric value equal to the day of the month.</param>
		public void setDate(int numDate) {
		}

		///<summary>
		///Sets the year value in the Date object using local time.
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		public void setFullYear(int numYear) {
		}

		///<summary>
		///Sets the year value in the Date object using local time.
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		public void setFullYear(int numYear, int numMonth) {
		}

		///<summary>
		///Sets the year value in the Date object using local time.
		///</summary>
		///<param name="numYear">A numeric value equal to the year.</param>
		///<param name="numMonth">A numeric value equal to the month. The value for January is 0, and other month values follow consecutively. Must be supplied if numDate is supplied.</param>
		///<param name="numdate">A numeric value equal to the day of the month.</param>
		public void setFullYear(int numYear, int numMonth, int numdate) {
		}
	}
}