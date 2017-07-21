using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace neggs.core
{
  partial class Extensions
  {

    public static bool IsNullOrEmpty(this string self)
    {
      return string.IsNullOrEmpty(self);
    }

    public static bool IsNullOrWhiteSpace(this string self)
    {
      return string.IsNullOrWhiteSpace(self);
    }

    public static bool IsNumeric(this string self)
    {
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo("ja-JP").NumberFormat;
      decimal returnValue = 0;
      bool bResult = decimal.TryParse(self
        , NumberStyles.Currency
        , numberFormat
        , out returnValue);
      return bResult;
    }

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

    /// <summary>
    /// 全角／半角の数字文字を抽出した文字列型の値を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static string InNumberChar(this string self)
    {
      return (new Regex("\\D")).Replace(self, string.Empty);
    }

    /// <summary>
    /// 全角／半角の空白文字を除去した文字列型の値を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static string RemovalSpace(this string self)
    {
      return self.Replace(" ", string.Empty).Replace("　", string.Empty);
    }

  }
}