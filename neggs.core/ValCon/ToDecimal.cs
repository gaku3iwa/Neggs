using System;
using System.Globalization;

namespace neggs.core
{
  partial class ValCon
  {

    public static decimal ToDecimal(bool Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(char Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(byte Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(short Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(long Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(int Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(float Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(double Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(decimal Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(string Value)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo(Extensions.JP).NumberFormat;
      bool bResult = decimal.TryParse(Value
        , NumberStyles.Currency
        , numberFormat
        , out decimal returnValue);
      return bResult ? returnValue : 0m;
    }

  }
}