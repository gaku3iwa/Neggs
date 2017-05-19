using System;

namespace neggs.web
{
  public partial class Services
  {

    private static Lazy<Services> _instance = new Lazy<Services>(() => new Services());

    /// <summary>
    /// XML Web Service の疑似的なシングルトンメソッド
    /// </summary>
    /// <returns>XML Web Service のインスタンス</returns>
    public static Services GetInstance()
    {
      return _instance.Value;
    }

  }
}
