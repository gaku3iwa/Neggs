using System;
using System.Globalization;

namespace neggs.core
{
  partial class Extensions
  {

    public static double ToDbl(this bool Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this char Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this byte Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this short Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this long Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this int Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this decimal Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(this string Value)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo(JP).NumberFormat;
      bool bResult = double.TryParse(Value
        , NumberStyles.Currency
        , numberFormat
        , out double returnValue);
      return bResult ? returnValue : 0d;
    }

  }
}
