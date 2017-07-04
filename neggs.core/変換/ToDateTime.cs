using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class Extensions
	{

		/// <summary>
		/// 日付文字列から時刻を含んだDateTime型の値を返します。
		/// </summary>
		/// <param name="Value">基準日</param>
		/// <returns>時刻を含んだDateTime型の値</returns>
		public static System.DateTime ToDateTime(this string Value)
		{
			System.DateTime ReturnValue = System.DateTime.MinValue;
			System.DateTime ErrorValue = System.DateTime.MinValue;

			if (Value == null)
				return ErrorValue;

			string DateuValue = Value.Trim();
			string DefDate = System.DateTime.MinValue.ToString("yyyyMMddHHmmss");

			if (Information.IsNumeric(Value) || string.IsNullOrEmpty(Value))
			{
				if (DateuValue.Length >= 14)
					DateuValue = Strings.Left(DateuValue, 14);
				else
					DateuValue = DateuValue + Strings.Mid(DefDate, DateuValue.Length + 1);

				DateuValue = Strings.Mid(DateuValue, 0x01, 4) + "/"
						   + Strings.Mid(DateuValue, 0x05, 2) + "/"
						   + Strings.Mid(DateuValue, 0x07, 2) + " "
						   + Strings.Mid(DateuValue, 0x09, 2) + ":"
						   + Strings.Mid(DateuValue, 0x0B, 2) + ":"
						   + Strings.Mid(DateuValue, 0x0D, 2);

				return System.DateTime.TryParse(DateuValue, out ReturnValue) ? ReturnValue : ErrorValue;
			}
			return System.DateTime.TryParse(Value, out ReturnValue) ? ReturnValue : ErrorValue;
		}

		/// <summary>
		/// 日付文字列から時刻を除いたDateTime型の値を返します。
		/// </summary>
		/// <param name="Value">基準日</param>
		/// <returns>時刻を除いたDateTime型の値</returns>
		public static System.DateTime ToDate(this string Value)
		{
			return Value.ToDateTime().Date;
		}

	}
}
