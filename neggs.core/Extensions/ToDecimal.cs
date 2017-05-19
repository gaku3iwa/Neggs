using System;
using System.Globalization;

namespace neggs.core
{
  partial class Extensions
  {

    public static decimal ToDecimal(this bool Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this char Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this byte Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this short Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this long Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this int Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this double Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(this string Value)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo("ja-JP").NumberFormat;
      decimal returnValue = 0;
      bool bResult = decimal.TryParse(Value
        , NumberStyles.Currency
        , numberFormat
        , out returnValue);
      return bResult ? returnValue : 0m;
    }

  }
}