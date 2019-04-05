using System.Reflection;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// <para>内包するプロパティ値を比較する</para>
    /// <para>内包するクラス、配列、リストなどは比較対象外です</para>
    /// </summary>
    /// <return>true:不一致、false:一致</return>
    public static bool IsDiff<T, U>(this T self, U your)
      where T : class
      where U : class
    {
      bool rcd = false;
      if (self == null || your == null)
        return true;

      MemberInfo[] members = self.GetType().GetProperties();
      foreach (var m in members)
      {
        var spi = self.GetType().GetProperty(m.Name);
        var ypi = your.GetType().GetProperty(m.Name);
        if (spi == null || ypi == null)
          continue;

        var self_value = spi.GetValue(self, null);
        var your_value = ypi.GetValue(your, null);
        if (self_value != null && your_value != null)
        {
          if (self_value.GetType().IsArray && your_value.GetType().IsArray)
            continue;
          else
            rcd = !self_value.Equals(your_value);
        }
        else if (self_value == null && your_value == null)
          rcd = false;
        else
          rcd = true;

        if (rcd) break;
      }
      return rcd;
    }

  }
}
