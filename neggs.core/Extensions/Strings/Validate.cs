using System.Globalization;
using System.Text.RegularExpressions;

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
      NumberFormatInfo numberFormat = CultureInfo.GetCultureInfo(Extensions.JP).NumberFormat;
      bool bResult = decimal.TryParse(self
        , NumberStyles.Currency
        , numberFormat
        , out decimal returnValue);
      return bResult;
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
