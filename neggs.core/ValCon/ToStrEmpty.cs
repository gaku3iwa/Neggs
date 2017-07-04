using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class ValCon
	{

		public static string ToStrEmpty(byte Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(byte Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(short Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(short Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(long Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(long Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(int Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(int Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(float Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(float Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(double Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(double Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(decimal Value)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(decimal Value, string Format)
		{
			if (Value == 0)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(string Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(DateTime Value, string Format)
		{
			if (Value == DateTime.MinValue)
			{
				return "";
			}
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(DateTime Value)
		{
			if (Value == DateTime.MinValue)
			{
				return "";
			}
			string tmp = Value.ToString();
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStrEmpty(DateTime Value, bool DateSlash)
		{
			if (Value == DateTime.MinValue)
			{
				return "";
			}
			if (DateSlash == false)
			{
				string tmp = Value.ToString("yyyyMMddHHmmss");
				return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
			}
			else
			{
				string tmp = Value.ToString();
				return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
			}
		}

	}
}
