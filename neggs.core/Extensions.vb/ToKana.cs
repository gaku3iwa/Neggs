namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// 指定に従って文字列型の値を返します。
    /// </summary>
    /// <param name="Value"></param>
    /// <param name="Conversion"></param>
    /// <returns></returns>
    public static string ToKana(this string Value, Microsoft.VisualBasic.VbStrConv Conversion)
    {
      if (Value.IsEmpty()) return string.Empty;
      return Value.Phonetic().StrConv(Conversion);
    }

  }
}
