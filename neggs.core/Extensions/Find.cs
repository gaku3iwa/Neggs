using System;
using System.Collections.Generic;
using System.Linq;

namespace neggs.core
{
  public static partial class Extensions
  {

    /// <summary>
    /// 最小値を持つ要素を返します
    /// </summary>
    public static IEnumerable<TSource> FindMin<TSource, TResult>(
        this IEnumerable<TSource> self,
        Func<TSource, TResult> selector)
    {
      return self.Where(c => selector(c).Equals(self.Min(selector)));
    }

    /// <summary>
    /// 最大値を持つ要素を返します
    /// </summary>
    public static IEnumerable<TSource> FindMax<TSource, TResult>(
        this IEnumerable<TSource> self,
        Func<TSource, TResult> selector)
    {
      return self.Where(c => selector(c).Equals(self.Max(selector)));
    }

  }
}
