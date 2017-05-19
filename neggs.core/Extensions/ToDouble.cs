using System;

namespace neggs.core
{
  partial class Extensions
  {

    public static double ToDouble(this bool Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this char Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this byte Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this short Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this long Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this int Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this decimal Value)
    {
      return Convert.ToDouble(Value);
    }

    public static double ToDouble(this string Value)
    {
      return Convert.ToDouble(Value.ToDecimal());
    }

  }
}