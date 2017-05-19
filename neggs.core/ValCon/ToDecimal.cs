using System;
using Microsoft.VisualBasic;

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
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDecimal(object Value)
    {
      if (Information.IsDBNull(Value))
      {
        return 0;
      }
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDecimal(Value);
    }

  }
}