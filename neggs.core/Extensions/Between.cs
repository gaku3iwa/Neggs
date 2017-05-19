using System;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// lower ～ higher の範囲内かを検査する
    /// </summary>
    /// <param name="self">比較される値</param>
    /// <param name="lower">区間(開始)</param>
    /// <param name="higher">区間(終了)</param>
    /// <param name="inclusive">閉区間か？(境界値を含む) (初期値:true)</param>
    /// <returns>範囲内であればtrue</returns>
    public static bool Between<T>(this T self, T lower, T higher, bool inclusive = true)
      where T : IComparable
    {
      // ジェネリックだと比較演算子が使えなくなってしまうので、
      // where 句で型パラメーター T が IComparable<T> インターフェイスを実装するように指定し、
      // CompareTo() メソッドにて比較する
      if (0 < lower.CompareTo(higher)) Swap(ref lower, ref higher);

      return inclusive
        ? (lower.CompareTo(self) <= 0 && self.CompareTo(higher) <= 0)
        : (lower.CompareTo(self) <  0 && self.CompareTo(higher) <  0);
    }

    /// <summary>
    /// ２つの値を交換する
    /// </summary>
    /// <param name="a">値A</param>
    /// <param name="b">値B</param>
    private static void Swap<T>(ref T a, ref T b)
    {
      T temp = a;
      a = b;
      b = temp;
    }

  }
}
