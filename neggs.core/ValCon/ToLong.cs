using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class ValCon
	{

		public static long ToLong(bool Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(char Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(byte Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(short Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(long Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(int Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(float Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(double Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(decimal Value)
		{
			return Convert.ToInt64(Value);
		}

		public static long ToLong(string Value)
		{
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			return Convert.ToInt64(Value);
		}

		public static long ToLong(object Value)
		{
			if (Information.IsDBNull(Value))
			{
				return 0;
			}
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			return Convert.ToInt64(Value);
		}

		public static long ToLongTerrible(string Value)
		{
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			Value = Value.Replace(":", "");
			Value = Value.Replace("/", "");
			Value = Value.Replace(",", "");
			Value = Value.Replace(";", "");
			return Convert.ToInt64(Value);
		}

	}
}
