using System;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// 年齢計算し、null許容整数型の値を返します。
    /// </summary>
    /// <param name="self">基準日</param>
    /// <param name="StartDay">生年月日、購入年月日、または導入年月日</param>
    /// <returns>年齢 or null（計算不能）</returns>
    public static int? AgeOfYear(this DateTime self, DateTime StartDay)
    {
      if (self < StartDay) return null;
      return (self.ToString("yyyyMMdd").ToInt() - StartDay.ToString("yyyyMMdd").ToInt()) / 10000;
    }

  }
}
