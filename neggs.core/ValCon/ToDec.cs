using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static decimal ToDec(bool Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(char Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(byte Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(short Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(long Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(int Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(float Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(double Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(decimal Value)
    {
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(string Value)
    {
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDecimal(Value);
    }

    public static decimal ToDec(object Value)
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
