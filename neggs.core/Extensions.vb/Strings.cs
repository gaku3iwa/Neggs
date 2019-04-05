using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// 指定に従って文字列型の値を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <param name="Conversion"></param>
    /// <returns></returns>
    public static string StrConv(this string self, Microsoft.VisualBasic.VbStrConv Conversion)
    {
      return Strings.StrConv(self, Conversion);
    }

    /// <summary>
    /// 独自にstring.Empty文字列を判定します。
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static bool IsEmpty(this string self)
    {
      if (string.IsNullOrEmpty(self)) return true;
      if (self.Equals(ControlChars.NullChar)) return true;

      string str = self.Trim();
      if (str.Equals(string.Empty)) return true;

      str = Strings.Replace(str, "　", string.Empty);
      if (str.Equals(string.Empty)) return true;

      return false;
    }

  }
}
