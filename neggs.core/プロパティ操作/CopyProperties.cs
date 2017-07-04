using System;
using System.Reflection;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// <para>継承関係のあるクラスのプロパティをコピーする</para>
    /// <para>継承関係は処理内部で検証していないので、無関係なクラスの場合には例外発生する可能性はあります</para>
    /// </summary>
    /// <param name="self">プロパティのコピー先</param>
    /// <param name="your">プロパティのコピー元</param>
    public static T CopyProperties<T, U>(this T self, U your)
      where T : class
      where U : class
    {
      if (self == null || your == null)
        return self;
      try
      {
        foreach (var ypi in your.GetType().GetProperties())
        {
          var spi = self.GetType().GetProperty(ypi.Name);
          if (spi != null && ypi.CanRead && spi.CanWrite)
          {
            self.GetType().InvokeMember(
              ypi.Name,
              BindingFlags.SetProperty,
              Type.DefaultBinder,
              self,
              new object[]
              {
                your.GetType().InvokeMember(ypi.Name, BindingFlags.GetProperty, Type.DefaultBinder, your, new object [] {})
              }
            );
          }
        }
      }
      catch(Exception ex)
      {
        throw ex;
      }
      return self;
    }

  }
}