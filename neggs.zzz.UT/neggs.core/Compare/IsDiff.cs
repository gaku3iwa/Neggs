using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using neggs.core;

namespace neggs.core
{
  public partial class Compare
  {

    class HogeA
    {
      public string name { get; set; }
      public int age { get; set; }
    }

    [Serializable]
    class HogeB
    {
      public string name { get; set; }
      public int age { get; set; }
      public int sex { get; set; }
    }

    [TestMethod]
    public void IsDiff_01()
    {
      Assert.AreEqual(((object)null).IsDiff((object)null), true);
    }

    [TestMethod]
    public void IsDiff_02()
    {
      HogeA aaa = new HogeA { name = "岩倉　学", age = 46 };
      Assert.AreEqual(aaa.IsDiff((object)null), true);
    }

    [TestMethod]
    public void IsDiff_03()
    {
      HogeA aaa = new HogeA { name = "岩倉　学", age = 46 };
      Assert.AreEqual(((object)null).IsDiff(aaa), true);
    }

    [TestMethod]
    public void IsDiff_04()
    {
      HogeA aaa = new HogeA { name = "岩倉　学", age = 46 };
      HogeB bbb = new HogeB { name = "岩倉　学", age = 46, sex = 1 };
      Assert.AreEqual(aaa.IsDiff(bbb), false);
    }

    [TestMethod]
    public void IsDiff_05()
    {
      HogeA aaa = new HogeA { name = "岩倉　学", age = 46 };
      HogeB bbb = new HogeB { name = "岩倉　学", age = 46, sex = 1 };
      Assert.AreEqual(bbb.IsDiff(aaa), false);
    }

  }
}
