using System;
using System.Globalization;

namespace neggs.core
{
  partial class Extensions
  {

    public static decimal ToDec(this bool Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this char Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this byte Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this short Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this long Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this int Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this double Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(this string Value)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo(JP).NumberFormat;
      bool bResult = decimal.TryParse(Value
        , NumberStyles.Currency
        , numberFormat
        , out decimal returnValue);
      return bResult ? returnValue : 0m;
    }

  }
}
