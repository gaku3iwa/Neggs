using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.core
{
  public partial class Convert
  {

    [TestMethod]
    public void ToKana_01()
    {
      var s = "四月朔日　一";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void ToKana_02()
    {
      var s = "一　千歳";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void ToKana_03()
    {
      var s = "十二月一日　実篤";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

    [TestMethod]
    public void ToKana_04()
    {
      var s = "岩倉　学";

      WriteLine("\ntarget：" + s);
      WriteLine(s.ToKana());
    }

  }
}
