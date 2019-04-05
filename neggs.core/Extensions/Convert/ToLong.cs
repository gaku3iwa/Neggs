using System;

namespace neggs.core
{
  partial class Extensions
  {

    public static long ToLong(this bool Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this char Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this byte Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this short Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this int Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this double Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this decimal Value)
    {
      return Convert.ToInt64(Value);
    }

    public static long ToLong(this string Value)
    {
      return Convert.ToInt64(Value.ToDec());
    }

  }
}
