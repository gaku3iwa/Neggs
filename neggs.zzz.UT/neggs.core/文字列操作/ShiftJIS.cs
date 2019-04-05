using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.core
{
  [TestClass]
  public class ShiftJIS
  {

    [TestMethod]
    public void ShiftJIS_01()
    {
      var s = "十二月一日　実篤";

      WriteLine("\ntarget：" + s);
      WriteLine(s.SJISLength().ToString());
      WriteLine(s.SJISSubString(2, 6).ToString());
    }

  }
}
