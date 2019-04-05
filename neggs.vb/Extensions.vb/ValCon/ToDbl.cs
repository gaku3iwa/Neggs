using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static double ToDbl(bool Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(char Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(byte Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(short Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(long Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(int Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(float Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(double Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(decimal Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(string Value)
    {
      if (Information.IsNumeric(Value) == false)
      {
        return 0;
      }
      return Convert.ToDouble(Value);
    }

    public static double ToDbl(object Value)
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
