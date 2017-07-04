using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class ValCon
	{

		public static int ToInt(bool Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(char Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(byte Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(short Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(long Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(int Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(float Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(double Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(decimal Value)
		{
			return Convert.ToInt32(Value);
		}

		public static int ToInt(string Value)
		{
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			return Convert.ToInt32(Value);
		}

		public static int ToInt(object Value)
		{
			if (Information.IsDBNull(Value))
			{
				return 0;
			}
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			return Convert.ToInt32(Value);
		}

		public static int ToIntTerrible(string Value)
		{
			if (Information.IsNumeric(Value) == false)
			{
				return 0;
			}
			Value = Value.Replace(":", "");
			Value = Value.Replace("/", "");
			Value = Value.Replace(",", "");
			Value = Value.Replace(";", "");
			return Convert.ToInt32(Value);
		}

	}
}
