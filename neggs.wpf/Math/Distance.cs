using System;

namespace neggs.core
{
  public static partial class Extensions
  {

    /// <summary>
    /// ２点間の距離を求める
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <returns></returns>
    public static double Distance(this System.Windows.Input.StylusPoint p1, System.Windows.Input.StylusPoint p2)
    {
      return Math.Sqrt(p1.X.Distance(p2.X) * p1.X.Distance(p2.X)
                     + p1.Y.Distance(p2.Y) * p1.Y.Distance(p2.Y));
    }

  }
}
