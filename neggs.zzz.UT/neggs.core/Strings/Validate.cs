using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;
using static System.Console;

namespace neggs.core
{
  public partial class Strings
  {

    [TestMethod]
    public void Strings_01()
    {
      string a = null;
      WriteLine(a.IsNullOrEmpty());
    }

    [TestMethod]
    public void Strings_02()
    {
      var s = "株式会社　ＡＢＣ　TEL:011-123-4567 FAX:011-123-4568 ";

      WriteLine("\ntarget：" + s);
      WriteLine(s.RemovalSpace());
      WriteLine(s.RemovalSpace().InNumberChar());
    }

  }
}
