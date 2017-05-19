using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace neggs.core
{
  partial class Extensions
  {

    /// <summary>
    /// <para>拡張メソッド版ディープコピー</para>
    /// <para>但し、シリアライズ可能なクラスで利用して下さい</para>
    /// </summary>
    /// <typeparam name="T">シリアライズ可能なクラス</typeparam>
    /// <param name="self">シリアライズ可能なオブジェクト</param>
    /// <returns>null、またはコピーしたオブジェクト</returns>
    public static T DeepCopy<T>(this T self)
      where T : class
    {
      T result = default(T);
      if (self == null || !self.GetType().IsSerializable)
        return result;
      using (MemoryStream ms = new MemoryStream())
      {
        var formatter = new BinaryFormatter();
        formatter.Serialize(ms, self);
        ms.Position = 0;
        result = (T)formatter.Deserialize(ms);
      }
      return result;
    }

  }
}