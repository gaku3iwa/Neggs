namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// Shift_JIS換算～文字列長を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static int sjisLength(this string self)
    {
      if (self.IsEmpty())
        return 0;

      System.Text.Encoding sjisEnc = System.Text.Encoding.GetEncoding("Shift_JIS");
      return sjisEnc.GetByteCount(self);
    }

    /// <summary>
    /// Shift_JIS換算～指定に従って部分文字列を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <param name="Index">ゼロ基準の開始位置</param>
    /// <param name="byteLength">Shift_JIS換算バイト長</param>
    /// <returns></returns>
    public static string sjisSubString(this string self, int Index, int byteLength)
    {
      if (self.IsEmpty())
        return string.Empty;

      System.Text.Encoding sjisEnc = System.Text.Encoding.GetEncoding("Shift_JIS");
      string retValue = string.Empty;
      int strIndex = 0;
      //-----------------------------------------------------------------------
      //  開始位置を取得
      if (Index > 0)
      {
        int byteCount = 0;
        int i = 0;
        while (i < self.Length)
        {
          byteCount += sjisEnc.GetByteCount(self.Substring(i, 1));
          if (byteCount > Index)
          {
            break;
          }
          strIndex += 1;
          i += 1;
        }
      }
      //-----------------------------------------------------------------------
      //  開始位置から1文字ずつ取得し、指定バイト数を超えるまで取得
      int j = strIndex;
      while (j < self.Length)
      {
        string tmp = self.Substring(j, 1);
        if (sjisEnc.GetByteCount(retValue + tmp) > byteLength)
        {
          break;
        }
        retValue += tmp;
        j += 1;
      }
      return retValue;
    }

    /// <summary>
    /// Shift_JIS換算～指定に従って部分文字列を返します。
    /// </summary>
    /// <param name="self"></param>
    /// <param name="Index">ゼロ基準の開始位置</param>
    /// <param name="byteLength">Shift_JIS換算バイト長</param>
    /// <returns></returns>
    public static string sjisRemove(this string self, int Index, int byteLength)
    {
      if (self.IsEmpty())
        return string.Empty;

      if (byteLength == 0)
        return self;

      System.Text.Encoding sjisEnc = System.Text.Encoding.GetEncoding("Shift_JIS");
      string retValue = string.Empty;
      int strIndex = 0;
      //-----------------------------------------------------------------------
      //  開始位置を取得
      if (Index > 0)
      {
        int byteCount = 0;
        int i = 0;
        while (i < self.Length)
        {
          byteCount += sjisEnc.GetByteCount(self.Substring(i, 1));
          if (byteCount > Index)
          {
            break;
          }
          strIndex += 1;
          i += 1;
        }
      }
      //-----------------------------------------------------------------------
      //  開始位置から1文字ずつ取得し、指定バイト数を超えるまで削除個数を取得
      retValue = self;
      int remCount = 0;
      int strCount = 0;
      int j = strIndex;
      while (j < self.Length)
      {
        string tmp = retValue.Substring(j, 1);
        remCount += sjisEnc.GetByteCount(tmp);
        strCount += 1;
        if (remCount == byteLength)
        {
          retValue = retValue.Remove(strIndex, strCount);
          break;
        }
        else if (remCount > byteLength)
        {
          retValue = retValue.Remove(strIndex, strCount - 1);
          break;
        }
        j += 1;
      }
      return retValue;
    }

  }
}