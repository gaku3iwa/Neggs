using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace neggs.core
{
	partial class Extensions
	{

		/// <summary>
		/// 指定の日付から元号、年を求め、文字列型の値を返します。
		/// </summary>
		/// <param name="Value">基準日</param>
		/// <returns>文字列型の元号、年</returns>
		public static (string Era, string Year) ToEra(this System.DateTime Value)
		{
			CultureInfo culture = new CultureInfo(JP, true);
			culture.DateTimeFormat.Calendar = new JapaneseCalendar();
			try
			{
				int iYear = Value.ToString("yy", culture).ToInt();
				string sYear = iYear.ToString();
				if (iYear < 10)
				{
					switch (iYear)
					{
					case 1:
						sYear = "元";
						break;
					default:
						sYear = iYear.ToString().StrConv(VbStrConv.Wide);
						break;
					}
				}
				return (Era: Value.ToString("gg", culture), Year: sYear);
			}
			catch (Exception)
			{
				return (string.Empty, string.Empty);
			}
		}

	}
}
