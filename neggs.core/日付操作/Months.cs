using System;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// 月初日を求め、DateTime型の値を返します。
    /// </summary>
    /// <param name="self">基準日</param>
    /// <returns>月初日</returns>
    public static System.DateTime BeginOfMonth(this DateTime self)
    {
      return new DateTime(self.Year, self.Month, 1);
    }

    /// <summary>
    /// 月末日を求め、DateTime型の値を返します。
    /// </summary>
    /// <param name="self">基準日</param>
    /// <returns>月末日</returns>
    public static System.DateTime EndOfMonth(this DateTime self)
    {
      var day = DateTime.DaysInMonth(self.Year, self.Month);
      return new DateTime(self.Year, self.Month, day);
    }

  }
}