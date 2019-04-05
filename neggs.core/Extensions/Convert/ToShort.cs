using System;

namespace neggs.core
{
  partial class Extensions
  {

    public static short ToShort(this string Value)
    {
      return Convert.ToInt16(Value.ToDec());
    }

  }
}
