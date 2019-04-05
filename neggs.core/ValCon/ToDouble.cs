using System;
using System.Globalization;

namespace neggs.core
{
  partial class ValCon
  {

    public static double ToDouble(bool Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(char Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(byte Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(short Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(long Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(int Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(float Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(double Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(decimal Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(string Value)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo(Extensions.JP).NumberFormat;
      bool bResult = double.TryParse(Value
        , NumberStyles.Currency
        , numberFormat
        , out double returnValue);
      return bResult ? returnValue : 0d;
    }

  }
}