using System;
using Microsoft.VisualBasic;

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
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(object Value)
    {
      if (Information.IsDBNull(Value))
      {
        return 0;
      }
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDouble(Value);
    }

  }
}