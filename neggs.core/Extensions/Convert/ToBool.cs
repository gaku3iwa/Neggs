using System;

namespace neggs.core
{
  partial class Extensions
  {

    public static bool ToBool(this char Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this byte Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this short Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this long Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this int Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this double Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this decimal Value)
    {
      return Convert.ToBoolean(Value);
    }

    public static bool ToBool(this string Value)
    {
      return Convert.ToBoolean(Value.ToDec());
    }

  }
}

