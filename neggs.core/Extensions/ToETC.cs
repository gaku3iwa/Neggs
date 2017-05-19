using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class Extensions
  {

    public static byte ToByte(this string Value)
    {
      return Convert.ToByte(Value.ToDecimal());
    }

    public static short ToShort(this string Value)
    {
      return Convert.ToInt16(Value.ToDecimal());
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
    /// 指定の日付から元号、年を求め、文字列型の値を返します。
    /// </summary>
    /// <param name="Value">基準日</param>
    /// <returns>文字列型の元号、年</returns>
    public static (string Era, string Year) ToEra(this System.DateTime Value)
    {
      CultureInfo culture = new CultureInfo("ja-JP", true);
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