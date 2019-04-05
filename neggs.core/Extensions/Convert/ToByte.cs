using System;
using System.Globalization;

namespace neggs.core
{
  partial class Extensions
  {

    public static byte ToByte(this string Value)
    {
      return Convert.ToByte(Value.ToDec());
    }

  }
}
