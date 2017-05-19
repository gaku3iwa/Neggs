using System;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class ValCon
  {

    public static bool ToBool(bool Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(char Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(byte Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(short Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(long Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(int Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(float Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(double Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(decimal Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(string Value)
    {
      if (Information.IsNumeric(Value) == false)
      {
        return false;
      }
      return Convert.ToBoolean(Convert.ToInt32(Value));
    }

    public static bool ToBool(object Value)
    {
      if (Information.IsDBNull(Value))
      {
        return false;
      }
      if (Information.IsNumeric(Value) == false)
      {
        return false;
      }
      return Convert.ToBoolean(Convert.ToInt32(Value));
    }

  }
}