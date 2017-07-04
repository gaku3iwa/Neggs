using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class ValCon
	{

		public static string ToStr(bool Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(char Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(byte Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(short Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(long Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(long Value, string Format)
		{
			return Value.ToString(Format);
		}

		public static string ToStr(int Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(int Value, string Format)
		{
			return Value.ToString(Format);
		}

		public static string ToStr(float Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(float Value, string Format)
		{
			return Value.ToString(Format);
		}

		public static string ToStr(double Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(double Value, string Format)
		{
			return Value.ToString(Format);
		}

		public static string ToStr(decimal Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(decimal Value, string Format)
		{
			return Value.ToString(Format);
		}

		public static string ToStr(string Value)
		{
			string tmp = Convert.ToString(Value);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(DateTime Value, string Format)
		{
			string tmp = Value.ToString(Format);
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(DateTime Value)
		{
			string tmp = Value.ToString();
			return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
		}

		public static string ToStr(DateTime Value, bool DateSlash)
		{
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

		public static string ToStr(object Value)
		{
			return ToStr(Value, true);
		}

		public static string ToStr(object Value, bool AddDateSlash)
		{
			if (Information.IsDBNull(Value))
			{
				return "";
			}
			if (Value == null)
			{
				return "";
			}
			if (AddDateSlash == false)
			{
				DateTime TmpDate = default(DateTime);
				if (Value is DateTime)
				{
					TmpDate = (DateTime)Value;
					string tmp = TmpDate.ToString("yyyyMMddHHmmss");
					return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
				}
				if (Value is System.DateTime)
				{
					TmpDate = Convert.ToDateTime(Value);
					string tmp = TmpDate.ToString("yyyyMMddHHmmss");
					return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
				}
				if (Information.IsDate(Value))
				{
					TmpDate = Convert.ToDateTime(Value);
					string tmp = TmpDate.ToString("yyyyMMddHHmmss");
					return tmp.Replace(Strings.ChrW(12316).ToString(), "～");
				}
			}
			string tmp2 = Convert.ToString(Value);
			return tmp2.Replace(Strings.ChrW(12316).ToString(), "～");
		}

	}
}
