using System;
using System.Globalization;

namespace neggs.core
{
  partial class Extensions
  {

    public static double ToDouble(this bool Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this char Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this byte Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this short Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this long Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this int Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this float Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this double Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this decimal Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this string Value)
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