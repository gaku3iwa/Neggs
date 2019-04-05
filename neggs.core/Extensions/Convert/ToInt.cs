using System;

namespace neggs.core
{
  partial class Extensions
  {

    public static int ToInt(this bool Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this char Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this byte Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this short Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this long Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this double Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this decimal Value)
    {
      return Convert.ToInt32(Value);
    }

    public static int ToInt(this string Value)
    {
      return Convert.ToInt32(Value.ToDec());
    }

  }
}
